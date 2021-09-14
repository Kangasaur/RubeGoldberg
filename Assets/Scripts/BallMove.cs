using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody2D myBody;
    Vector2 mousePos;

    public Camera cam;
    public float power;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            /*mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(mousePos);
            myBody.AddForce(Vector2.MoveTowards(transform.position, mousePos, power));*/
            myBody.AddForce(Vector2.up * power);
        }
    }
}
