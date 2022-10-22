using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirEnemigo : MonoBehaviour {


    public int vidaEnemy = 0;
    void OnCollisionEnter2D(Collision2D otherObj) {

        if (otherObj.gameObject.tag == "Calculadora") {
            vidaEnemy ++;
        }

        if (vidaEnemy == 3){
            Destroy(gameObject, 0.2f);

        }

    }
}
