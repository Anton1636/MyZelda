using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 chenge;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        chenge = Vector3.zero;
        chenge.x = Input.GetAxisRaw("Horizontal");
        chenge.y = Input.GetAxisRaw("Vertical");

        UpdateAnimationAndMove();
    }

    void UpdateAnimationAndMove()
    {
        if (chenge != Vector3.zero)
        {
            MoveCharacter();

            animator.SetFloat("moveX", chenge.x);
            animator.SetFloat("moveY", chenge.x);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(transform.position + chenge * speed * Time.deltaTime);
    }
}
