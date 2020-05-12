using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        score.text = "score : " + CubeController.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
