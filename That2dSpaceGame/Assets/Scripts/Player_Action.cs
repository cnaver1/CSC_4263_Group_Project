using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Action : Character
{

    public Animator animator;
    bool isAttacking;  
    public  GameObject isAttack;

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

        if (isAttacking == false)
        {
            if (Input.GetButtonDown("leftfire"))
            {
                GameObject shurken = Instantiate(isAttack, transform.position, Quaternion.identity);
                shurken.GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f, 0.0f);
                shurken.tag = "Bullets";
                StartCoroutine(Attack());
                Destroy(shurken, 1.0f);
                isAttacking = true;
                StartCoroutine(Attack());
            }
            if (Input.GetButtonDown("rightfire"))
            {
                GameObject shurken = Instantiate(isAttack, transform.position, Quaternion.identity);
                shurken.GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, 0.0f);
                shurken.tag = "Bullets";
                StartCoroutine(Attack());
                Destroy(shurken, 1.0f);
                isAttacking = true;
                StartCoroutine(Attack());
            }
            if (Input.GetButtonDown("upfire"))
            {
                GameObject shurken = Instantiate(isAttack, transform.position, Quaternion.identity);
                shurken.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 1.0f);
                shurken.tag = "Bullets";
                StartCoroutine(Attack());
                Destroy(shurken, 1.0f);
                isAttacking = true;
                StartCoroutine(Attack());
            }
            if (Input.GetButtonDown("downfire"))
            {
                GameObject shurken = Instantiate(isAttack, transform.position, Quaternion.identity);
                shurken.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, -1.0f);
                shurken.tag = "Bullets";
                StartCoroutine(Attack());
                Destroy(shurken, 1.0f);
                isAttacking = true;
                StartCoroutine(Attack());
            }

        }
    }

    private IEnumerator Attack()
    {


        yield return new WaitForSeconds(1);
        isAttacking = false;

    }
}