using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] Transform target;
    [SerializeField] Camera mainCamera;
    public Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        if (target == null)
        {
            target = transform;
        }
        if(mainCamera == null)
        {
            mainCamera = Camera.main;
        }

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX,moveY).normalized;


        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        Vector3 lookDir = mousePos - transform.position;
        target.right = lookDir;

        


    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }





}
