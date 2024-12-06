using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; 
    private Vector3 offset = new Vector3(-.06f,4.23f,-8.41f);
   
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
