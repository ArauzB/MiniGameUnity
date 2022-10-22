using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bullet;

   

    public float fireRate = 0.1f;
    float nextFire = 0f;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, transform.position, transform.rotation);
        }

    }


}
