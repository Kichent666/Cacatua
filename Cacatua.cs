using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cacatua : MonoBehaviour
{
    //NPC Health
    public int health = 5;

    //NPC Level
    public int level = 1;

    //NPC Speed
    public float speed = 4f;

    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        newPosition = transform.position;
        level += health;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
