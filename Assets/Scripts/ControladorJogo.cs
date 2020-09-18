using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ControladorJogo : MonoBehaviour
{
    public Text TxtPontos;
    public int pontos;
    public void RestartJogo(){
        SceneManager.LoadScene(0);
    }
}
