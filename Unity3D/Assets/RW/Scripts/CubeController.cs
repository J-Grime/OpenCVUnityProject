using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    Rigidbody rb;
    string pos;
    int xpos;
    bool _wait;
    bool current;
    public static int score;
    List<int> positions;
    // Start is called before the first frame update
    void Start()
    {
        positions = new List<int> { 12,6,0,-6,-12};
        pos = PlayerControllerScript.text;
        xpos = 2;
        score = 0;
        _wait = false;
    }

    // Update is called once per frame
    void Update()
    {
        move();
        transform.position += new Vector3(0.0f, 0.0f, -40.0f*Time.deltaTime);
    }




    private void move()
    {
       pos = PlayerControllerScript.text;
        if (pos == "left" && this.transform.position.x < 15 && this.transform.position.x != +12)
        {
            transform.position += new Vector3(+12.0f*Time.deltaTime, 0.0f, 0.0f);
        }
        else if (pos == "right" && this.transform.position.x > -15 && this.transform.position.x != -12)
        {
            transform.position += new Vector3(-12.0f * Time.deltaTime, 0.0f, 0.0f);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit" + collision.gameObject);
    }
}


