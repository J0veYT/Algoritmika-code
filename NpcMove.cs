using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMove : MonoBehaviour
{
    //health of NPC
    public int health = 10;
    //level NPC
    public int level = 1;
    //speed NPC
    public float speed = 1.1f;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
