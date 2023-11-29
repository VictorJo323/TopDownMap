using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingController : MonoBehaviour
{
    public Animator animator;
    private Vector2 moveInput = Vector2.zero;

    public void SetMoveInput(Vector2 input)
    {
        moveInput = input;
        UpdateAnimator();
    }

    private void UpdateAnimator()
    {
        // Speed 파라미터를 설정
        float speed = moveInput.magnitude;
        animator.SetFloat("Speed", speed);
    }
}
