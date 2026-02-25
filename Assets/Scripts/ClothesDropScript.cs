using UnityEngine;

public class ClothesDropScript : MonoBehaviour, ISnapScript
{
    public void OnCardDrop(DragScript dragScript)
    {
        dragScript.transform.position = transform.position;
    }
}
