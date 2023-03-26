using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5;
    private float moveX, moveY;


    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        transform.Translate(movementSpeed * moveX * Time.deltaTime * Vector3.right);
        transform.Translate(movementSpeed * moveY * Time.deltaTime * Vector3.forward);
        
    }
}
