using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDeletionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameRoads.CarZpos<(this.transform.position.z))
        {
            Destroy(this);
        }
        
    }
}
