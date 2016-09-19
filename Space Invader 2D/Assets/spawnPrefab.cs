using UnityEngine;
using System.Collections;

public class spawnPrefab : MonoBehaviour
{



    public GameObject bluemisc;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //    if (Input.GetKeyDown( KeyCode.T))
        //  {
        //    Debug.Log("make tracks!");
        //Spawn the prefab here
        //  Instantiate(bluemisc, transform.position, transform.rotation);
        //}
        // }

        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject temp = Instantiate(bluemisc, transform.position, transform.rotation) as GameObject;
            temp.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
        }
    }
}