using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BalaEnemiga : MonoBehaviour {
    public float VelX;
    public float VelY;

    [SerializeField] Transform target;
    [SerializeField] Camera mainCamera;

    public Rigidbody2D rb;







    // Start is called before the first frame update
    void Start() {


        rb = GetComponent<Rigidbody2D>();



             //velocidad de la bala
             VelX = rb.velocity.x;
             VelY = rb.velocity.y;

             rb.velocity = new Vector2(VelX, VelY).normalized;

             rb.velocity = rb.velocity * 10;


    }

    void Update() {

        if (rb.position.y < -20 || rb.position.y > 60) {

            Destroy(gameObject);

        }

        if (rb.position.x < -20 || rb.position.x > 60) {

            Destroy(gameObject);

        }

        Destroy(gameObject,2f);


    }

    void OnCollisionEnter2D() {

        Destroy(gameObject,0.1f);
    }



}