using UnityEngine;
using System.Collections;

public class DamagedByCollisions : MonoBehaviour
{


    private AudioSource audioSource;
    public AudioClip Scored;


    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");
        GetComponent<AudioSource>().Play();

        }
    }


