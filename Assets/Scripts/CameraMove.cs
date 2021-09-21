using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMove : MonoBehaviour
{
    CameraPositions camPositions;

    void Start()
    {
        camPositions = Camera.main.gameObject.GetComponent<CameraPositions>();
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
            case "Small domino (32)":
                if (camPositions.index == 4) camPositions.UpdatePosition();
                break;
            case "Pachinko wheel":
                if (camPositions.index == 5) camPositions.UpdatePosition();
                break;
            case "Pachinko circle (51)":
                if (camPositions.index == 6) camPositions.UpdatePosition();
                break;
        }
    }
}
