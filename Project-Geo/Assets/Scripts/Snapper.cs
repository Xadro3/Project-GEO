using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapper : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Transform> snapPoints;
    public List<Drag> objects;
    public float snapRange = 0.5f;
    void Start()
    {
        foreach(Drag drag in objects)
        {
            drag.dragEndedCallback = OnDragEnded;
        }
    }

    private void OnDragEnded (Drag drag)
    {
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach(Transform snapPoint in snapPoints)
        {
            float currentDistance = Vector2.Distance(drag.transform.localPosition, snapPoint.localPosition);
            if(closestSnapPoint == null || currentDistance < closestDistance)
            {
                closestSnapPoint = snapPoint;
                closestDistance = currentDistance;
            }
        }

        if(closestSnapPoint != null && closestDistance <= snapRange)
        {
            drag.transform.localPosition = closestSnapPoint.localPosition;
        }
    }
}
