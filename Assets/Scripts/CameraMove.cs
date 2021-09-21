using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMove : MonoBehaviour
{
    CameraPositions camPositions;
    Vector3 camCurrPosition;
    Vector3 velocity;
    float smoothTime = 1.5f;

    void Start()
    {
        camCurrPosition = Camera.main.transform.position;
        camPositions = Camera.main.gameObject.GetComponent<CameraPositions>();
    }

    void Update()
    {
        if (camCurrPosition != camPositions.target)
        {
            Camera.main.transform.position = Vector3.SmoothDamp(Camera.main.transform.position, camPositions.target, ref velocity, smoothTime);
            if (Camera.main.transform.position == camPositions.target) camCurrPosition = camPositions.target;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.name)
        {
            case "Dominooooo":
                if (camPositions.index == 0) camPositions.UpdatePosition();
                break;
            case "Marble 2":
                if (camPositions.index == 1) camPositions.UpdatePosition();
                break;
            case "Wheel":
                if (camPositions.index == 2) camPositions.UpdatePosition();
                break;
            case "Domino 2":
                if (camPositions.index == 3) camPositions.UpdatePosition();
                break;
        }
    }
}
