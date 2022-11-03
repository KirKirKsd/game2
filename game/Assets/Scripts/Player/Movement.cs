using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    public float speed = 10;

    private void Update() {
        transform.position += Vector3.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime; 

        if (Input.GetAxis("Horizontal") > 0) {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetAxis("Horizontal") < 0) {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
