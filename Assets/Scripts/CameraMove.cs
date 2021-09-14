using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Vector3 camCurrPosition;
    Vector3 camTargetPosition;
    Vector3 velocity;
    float smoothTime = 1.5f;

    void Start()
    {
        camCurrPosition = Camera.main.transform.position;
        camTargetPosition = Camera.main.transform.position;
    }

    void Update()
    {
        if (camCurrPosition != camTargetPosition)
        {
            Camera.main.transform.position = Vector3.SmoothDamp(Camera.main.transform.position, camTargetPosition, ref velocity, smoothTime);
            if (Camera.main.transform.position == camTargetPosition) camCurrPosition = camTargetPosition;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.name)
        {
            case "Dominooooo":
                //camTargetPosition = new Vector3(14f, -6f, -10f);
                break;
        }
    }
}
