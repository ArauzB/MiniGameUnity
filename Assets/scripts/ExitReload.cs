using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitReload : MonoBehaviour {
    public void Reload() {

            Debug.Log("Hola");

            SceneManager.LoadScene("SampleScene");


        }


        public void Exit(){
                Debug.Log("Adios");
                Application.Quit();

            }

    }
