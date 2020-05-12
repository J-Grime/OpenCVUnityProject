using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    string pos;
    GameObject player;
    Vector2 play;
    Vector2 quit;
    public static float playTarget = 5.0f;
    public static float quitTarget = 5.0f;
    string temp;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        play = GameObject.Find("Play").transform.position;
        quit = GameObject.Find("Quit").transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = PlayerControllerScript.text;
        //Debug.Log(pos);

        if (pos == "right" && temp == pos)
        {
            //Debug.Log("right side");
            player.transform.position = play;
            playTarget -= Time.deltaTime;
        }
        else if (pos == "centre")
        {
            player.transform.position = new Vector2(574, 266);
        }
        else if (pos == "left" && temp == pos)
        {
            player.transform.position = quit;
            quitTarget -= Time.deltaTime;
        }


        if (temp != pos)
        {
            playTarget = 5.0f;
            quitTarget = 5.0f;
        }

        

        if (quitTarget<0f)
        {
            Application.Quit();
        }
        if (playTarget < 0f)
        {
            LoadScene("Main");
        }
        Debug.Log(playTarget);

        temp = pos;
    }

    public void LoadScene(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }
}
