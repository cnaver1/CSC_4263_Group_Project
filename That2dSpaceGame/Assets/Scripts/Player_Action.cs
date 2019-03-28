using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Action : Character
{

    public Animator animator;
    int directionAttacking;  /* 1 = up 2 = down 3 = left 4 = right */

   protected override void Update()
    {

        GetInput();

        base.Update();
    }
      /*{
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

          animator.SetFloat("Horizontal", movement.x);
          animator.SetFloat("Vertical", movement.y);
          animator.SetFloat("Magnitude", movement.magnitude);
          transform.position = transform.position + movement * Time.deltaTime;

     
      }*/

    private void GetInput()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) { direction += Vector2.up; }
        if (Input.GetKey(KeyCode.A)) { direction += Vector2.left; }
        if (Input.GetKey(KeyCode.S)) { direction += Vector2.down; }
        if (Input.GetKey(KeyCode.D)) { direction += Vector2.right; }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            direction += Vector2.left;
            directionAttacking = 3;
            StartCoroutine(Attack());
        }

        if (Input.GetButtonDown("Fire")
        {
            direction += Vector2.right;
            directionAttacking = 4;
            StartCoroutine(Attack());
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector2.up;
            directionAttacking = 1;
            StartCoroutine(Attack());
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
            directionAttacking = 2;
            StartCoroutine(Attack());
        }

    }

    private IEnumerator Attack()
    {
        isAttacking = true;
        myAnimator.SetBool("attack", isAttacking);
        isAttacking = true;
        yield return new WaitForSeconds(1);
        isAttacking = false;
    }
}