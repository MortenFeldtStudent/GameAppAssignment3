﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject barrelPoint;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("q"))
        {
            GameObject bullet = Instantiate(bulletPrefab, barrelPoint.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 5000);
            Destroy(bullet, 3);
        }

    }


}
