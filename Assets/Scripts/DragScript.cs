using UnityEngine;

public class DragScript : MonoBehaviour
{
    private Collider2D col;

    private Vector3 startDragPosition;
    private Vector3 startPosition;
    private Transform startParent;

    private void Start()
    {
        col = GetComponent<Collider2D>();
    }
    private void OnMouseDown()
    {
        startDragPosition = transform.position;
        transform.position = GetMousePositionInWorldSpace();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePositionInWorldSpace();
        startPosition = transform.position;
        startParent = transform.parent;
    }

    private void OnMouseUp()
    {
        col.enabled = false;
        Collider2D hitCollider = Physics2D.OverlapPoint(transform.position);
        col.enabled = true;
        if(hitCollider != null && hitCollider.TryGetComponent(out ISnapScript cardDropArea))
        {
            if (hitCollider.CompareTag(this.tag) || hitCollider.CompareTag("Untagged"))
            {
                transform.SetParent(hitCollider.transform);

                if (hitCollider.CompareTag(this.tag))
                {
                    transform.localPosition = Vector3.zero;
                }
                cardDropArea.OnCardDrop(this);
            }
            else
            {
                ReturnToStart();
            }
        }
        else
        {
            ReturnToStart();
        }

    }
    private void ReturnToStart()
    {
        transform.SetParent(startParent);
        transform.position = startPosition;
    }
    public Vector3 GetMousePositionInWorldSpace()
    {
        Vector3 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        p.z = 0f;
        return p;
    }
}
