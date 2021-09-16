using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositions : MonoBehaviour
{
    public int index = 0;
    public Vector3 target;
    Vector3[] positions;

    private void Start()
    {
        positions = new Vector3[]
        {
            new Vector3(0f, 0f, -10f),
            new Vector3(14f, -6f, -10f),
            new Vector3(7f, -11f, -10f)
        };
        target = positions[index];
    }

    public void UpdatePosition()
    {
        index++;
        target = positions[index];
    }
}
