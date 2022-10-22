using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemy : MonoBehaviour
{
  [SerializeField] private Transform player;
  [SerializeField] private Transform shootPosition;
  [SerializeField] private GameObject bulletPrefab;

  void Start(){
    InvokeRepeating("Shoot",0.5f,0.5f);

  }

  void Update(){
    transform.up = player.transform.position - transform.position;

  }

  private void Shoot(){
    GameObject bullet = Instantiate(bulletPrefab,shootPosition.position,Quaternion.identity);
    Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
    bulletRb.velocity = (player.transform.position - transform.position);
  }
}
