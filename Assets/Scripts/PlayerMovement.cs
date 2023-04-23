using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController CharacterController;
    [SerializeField] float speed;

    Vector2 direction;

    private void Update()
    {
        MovementInputs();
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    void MovementInputs()
    {
        float horizontal = Input.GetAxis("Horizontal");

        direction = new Vector2 (horizontal, 0);
    }

    void PlayerMove()
    {
        CharacterController.Move(direction * Time.deltaTime * speed);
    }


}
