using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public Vector3 oldPos;
    public Vector3 newPos;
    public float speed = 10;
    public float step;
    Boolean standStill = false;

    // Start is called before the first frame update
    void Start()
    {
        positionSaver();
        step = speed * Time.deltaTime;
        StartCoroutine(CubeCoroutine());

    }


    // Update is called once per frame
    void Update()
    {
        if (standStill == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPos, step);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, oldPos, step);
        }
    }

    void positionSaver()
    {
        oldPos = transform.position;
        newPos = new Vector3((oldPos.x + 20), oldPos.y, oldPos.z);
    }

    IEnumerator CubeCoroutine()
    {
        while (true)
        {
            print("Start");
            standStill = false;
            yield return new WaitForSeconds(1.0f);
            standStill = true;
            print("End");
            yield return new WaitForSeconds(1.0f);
        }
    }

}
