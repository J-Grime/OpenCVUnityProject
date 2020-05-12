using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    Text countdown;
    // Start is called before the first frame update
    void Start()
    {
        countdown = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (StartMenu.playTarget < 5)
        { countdown.text = StartMenu.playTarget.ToString(); }
        else
        { countdown.text = StartMenu.quitTarget.ToString(); }
        
    }
}
