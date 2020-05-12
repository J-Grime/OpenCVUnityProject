using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCount : MonoBehaviour
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
        if (EndScreenScript.end_playTarget < 5)
        { countdown.text = EndScreenScript.end_playTarget.ToString(); }
        else
        { countdown.text = EndScreenScript.end_quitTarget.ToString(); }
    }
}
