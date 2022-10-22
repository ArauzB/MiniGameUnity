using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirJugador : MonoBehaviour {

    public int vida = 3;

    void OnCollisionEnter2D(Collision2D otherObj) {

        if (otherObj.gameObject.tag == "BalaEnemiga") {

            vida++;
        }

        if (vida == 3) {
            Destroy(gameObject, 0.2f);

        }
    }
}
