using UnityEngine;
using UnityEngine.UI;

public class MovimientoEnemy : MonoBehaviour {



    public float speed= 3f;

    public Rigidbody2D rb;


//create a AI enemy movement script
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }



    void Update()
    {

        Vector2 movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        rb.AddForce(movement * speed);

      


    }



}

