using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeController : MonoBehaviour
{
    Rigidbody rb;
    string pos;
    int xpos;
    float _wait;
    bool current;
    public static int score;
    List<int> positions;
    // Start is called before the first frame update
    void Start()
    {
        _wait = 10.0f;
        score = 0;
        positions = new List<int> { 12,6,0,-6,-12};
        pos = PlayerControllerScript.text;
        xpos = 2;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        move();
        transform.position += new Vector3(0.0f, 0.0f, -40.0f*Time.deltaTime);
        if (_wait<0)
        {
            GameObject NoCol = GameObject.Find("NoCollision");
            NoCol.SetActive(false);
        }
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
        _wait -= Time.deltaTime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit" + collision.gameObject);
        if (_wait<0)
        { LoadScene("EndScreen");}
        
    }

    public void LoadScene(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }
}


