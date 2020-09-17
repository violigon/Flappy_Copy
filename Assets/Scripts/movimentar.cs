using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentar : MonoBehaviour
{
    public Vector2 direcao;
    public float velocidade;

  
    private void Update()
    {
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }
}
