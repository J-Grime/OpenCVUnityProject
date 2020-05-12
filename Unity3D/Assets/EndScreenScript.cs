using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenScript : MonoBehaviour
{
    string pos;
    GameObject player;
    Vector2 play;
    Vector2 quit;
    public static float end_playTarget = 5.0f;
    public static float end_quitTarget = 5.0f;
    string temp;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        play = GameObject.Find("PlayAgain").transform.position;
        quit = GameObject.Find("Quit").transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        pos = PlayerControllerScript.text;
        Debug.Log(pos);

        if (pos == "right" && temp == pos)
        {
            player.transform.position = play;
            end_playTarget -= Time.deltaTime;
        }
        else if (pos == "centre")
        {
            player.transform.position = new Vector2(574, 266);
        }
        else if (pos == "left" && temp == pos)
        {
            player.transform.position = quit;
            end_quitTarget -= Time.deltaTime;
        }


        if (temp != pos)
        {
            end_playTarget = 5.0f;
            end_quitTarget = 5.0f;
        }



        if (end_quitTarget < 0f)
        {
            Application.Quit();
        }
        if (end_playTarget < 0f)
        {
            LoadScene("Main");
        }

        temp = pos;
    }

    public void LoadScene(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }
}
