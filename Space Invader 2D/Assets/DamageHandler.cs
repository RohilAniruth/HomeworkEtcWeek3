using UnityEngine;
using System.Collections;

public class DamagedByCollisions : MonoBehaviour
{

    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");
    }
}