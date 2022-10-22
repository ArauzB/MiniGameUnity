using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bala : MonoBehaviour {
    public float VelX;
    public float VelY;

    [SerializeField] Transform target;
    [SerializeField] Camera mainCamera;

    Rigidbody2D rb;







    // Start is called before the first frame update
    void Start() {
        if (target == null)
        {
            target = transform;
        }
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }

        rb = GetComponent<Rigidbody2D>();


        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        Vector3 lookDir = mousePos - transform.position;
        target.right = lookDir;

        //velocidad de la bala
        VelX = lookDir.x;
        VelY = lookDir.y;

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


    }

    void OnCollisionEnter2D() {

        Destroy(gameObject,0.1f);
    }



}