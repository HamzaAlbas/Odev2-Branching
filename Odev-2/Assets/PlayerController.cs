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

        transform.Translate(movementSpeed * moveX * Time.deltaTime * Vector3.right);
        
    }
}
