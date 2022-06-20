using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    // Start is called before the first frame update
        public CharacterController controller;

       public float speed = 2;
       private Vector3 rotation;

void Update()
{
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(x, 0, z);
    transform.Translate(movement * speed * Time.deltaTime);
    if (Input.GetKey(KeyCode.Q)) rotation = Vector3.up;
    else if (Input.GetKey(KeyCode.E)) rotation = Vector3.down;
    else rotation = Vector3.zero;

    transform.Rotate(rotation * speed * Time.deltaTime);

}
}
