using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentar : MonoBehaviour
{
    public Vector2 direcao;
    public float velocidade;

  void Start() {
      Time.timeScale = 1;
  }
    private void Update()
    {
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }
}
