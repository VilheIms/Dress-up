using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class SnapScript : MonoBehaviour
{
    public List<Transform> snapPoints;
    public List<DragScript> draggableObjects;
    public float snapRange = 0.5f;

    private void Start()
    {
        foreach (DragScript draggable in draggableObjects)
        {
            draggable.dragEndedCallBack = OnDragEnded;
        }
    }
    private void OnDragEnded(DragScript draggable)
    {
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach (Transform snapPoint in snapPoints)
        {
            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.localPosition);
            if (currentDistance == null || currentDistance < closestDistance)
            {
                closestSnapPoint = snapPoint;
                closestDistance = currentDistance;
            }
        }
        if (closestSnapPoint != null && closestDistance <= snapRange)
        {
            draggable.transform.localPosition = closestSnapPoint.localPosition;
        }
    }
}
