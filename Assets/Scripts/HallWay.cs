using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallWay : MonoBehaviour
{
    public float speed = 5f;
    public float restTo = 40.57f;
    Vector3 startpos;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        if(transform.position.y > 26)
        {
            pos.y -= restTo;
        }
        transform.position = pos;
    }
}
