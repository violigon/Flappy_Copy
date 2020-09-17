using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour
{
    public float diferencaX;

    public float minX;
    private void Update() {
        if(transform.position.x <= minX){
            transform.position = new Vector3(
                transform.position.x + diferencaX * 2,
                transform.position.y,
                transform.position.z
            );
        }
    }
}
