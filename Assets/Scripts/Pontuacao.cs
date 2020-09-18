using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    void Start() {
        Controlador = FindObjectOfType<ControladorJogo>();
    }
    public ControladorJogo Controlador;
  void OnTriggerEnter2D(Collider2D Colisor_pontuar) {
      Controlador.pontos++;
      Controlador.TxtPontos.text = Controlador.pontos.ToString();
  }
}
