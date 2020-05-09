using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoads : MonoBehaviour
{
    public GameObject road;
    public static float CarZpos;
    List<GameObject> References;
    public List<GameObject> vehicles;
    List<int> Lanes;
    List<GameObject> vehiclesOnRoad;
    // Start is called before the first frame update
    void Start()
    {
        vehiclesOnRoad = new List<GameObject>();
        Lanes = new List<int>{ 12, 6, 0,-6,-12};
        References = new List<GameObject>();
        _Instantiate(0);
        _Instantiate(-50);
        _Instantiate(-100);
        _Instantiate(-150);
        _Instantiate(-200);
        _Instantiate(-250);
    }

    // Update is called once per frame
    void Update()
    {
        for (int v = 0; v < vehiclesOnRoad.Count; v++)
        {
            if ((vehiclesOnRoad[v].transform.position.z - 50) > this.transform.position.z)
            {
            vehiclesOnRoad[v].SetActive(false);
            DestroyImmediate(vehiclesOnRoad[v].gameObject);
            vehiclesOnRoad.RemoveAt(v);
                CubeController.score += 10;
            }
            
        }


        for (int i = 0; i<References.Count; i++)
        {
            
            //Debug.Log(References[i].transform.position.z);
            if ((References[i].transform.position.z-50) > this.transform.position.z)
            {
                _Instantiate((References[i].transform.position.z - 250));
                References[i].SetActive(false);
                DestroyImmediate(References[i].gameObject);
                References.RemoveAt(i);
            }
            
        }
    }

    private void _Instantiate(float temp)
    {
        References.Add(Instantiate(road, new Vector3(0, 0, temp), Quaternion.identity) as GameObject);
        for (int l = 0; l<Random.Range(1,3); l++)
        {
        vehiclesOnRoad.Add(Instantiate(vehicles[Random.Range(0,vehicles.Count)].gameObject, new Vector3(Lanes[(Random.Range(0,Lanes.Count))], this.transform.position.y, temp-Random.Range(-10,10)), this.transform.rotation)as GameObject);
        for (int v = 0; v < vehiclesOnRoad.Count; v++)
        {
            vehiclesOnRoad[v].SetActive(true);
            }
        }
        
        
    }
}
