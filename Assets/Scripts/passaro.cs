using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passaro : MonoBehaviour
{
    public float velocidade = 1f;
    private Rigidbody2D rig;

    public GameObject GameOver;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

        void Update()
    {
        if(Input.GetMouseButtonDown(0)){

            rig.velocity = Vector2.up * velocidade;

        }
    }
    private void OnCollisionEnter2D(Collision2D colisor) {
        
        GameOver.SetActive(true);
        Time.timeScale = 0;

    }
}
