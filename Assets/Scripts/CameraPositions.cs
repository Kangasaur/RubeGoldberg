using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositions : MonoBehaviour
{
    public int index = 0;
    public Vector3 target;
    Vector3 camCurrPosition;
    Vector3 velocity;
    float smoothTime = 0.7f;
    Vector3[] positions;

    private void Start()
    {
        positions = new Vector3[]
        {
            new Vector3(0f, 0f, -10f),
            new Vector3(14f, -6f, -10f),
            new Vector3(7f, -11f, -10f),
            new Vector3(-0.5f, -16f, -10f),
            new Vector3(-0.5f, -25f, -10f),
            new Vector3(19.5f, -29f, -10f),
            new Vector3(22f, -36.2f, -10f),
            new Vector3(22f, -45f, -10f)
        };
        target = positions[index];
        camCurrPosition = Camera.main.transform.position;
    }

    public void UpdatePosition()
    {
        index++;
        target = positions[index];
    }

    void Update()
    {
        if (camCurrPosition != target)
        {
            Camera.main.transform.position = Vector3.SmoothDamp(Camera.main.transform.position, target, ref velocity, smoothTime);
            if (Camera.main.transform.position == target) camCurrPosition = target;
        }
    }
}
