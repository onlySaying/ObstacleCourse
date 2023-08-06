using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        PrintInstruction();
    }

    void Update()
    {
        MoveRocket();

    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the Game");
        Debug.Log("Move Ur character use arrows");
        Debug.Log("Don't hit the Walls");
    }

    void MoveRocket()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
