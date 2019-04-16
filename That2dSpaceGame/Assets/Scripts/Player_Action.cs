using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Action : Character
{

    public Animator animator;
    bool isAttacking;  
    public GameObject attack;
    public GameObject special;
    public float currentMana;
    public bool equipWeapon = false;

    public static float attackSpeed = 0.7f;

   protected override void Update()
    {
        currentMana = PlayerStats.mana;
        equipWeapon = WeaponDialogue.equipWeapon;
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
        float accuracy = Random.Range(-0.1f, 0.2f);
        float distance = Random.Range(0.5f, 1.0f);
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) { direction += Vector2.up; }
        if (Input.GetKey(KeyCode.A)) { direction += Vector2.left; }
        if (Input.GetKey(KeyCode.S)) { direction += Vector2.down; }
        if (Input.GetKey(KeyCode.D)) { direction += Vector2.right; }

        if (isAttacking == false)
        {
            if (Input.GetButtonDown("leftfire"))
            {
              

                GameObject shurken = Instantiate(attack, transform.position, Quaternion.identity);
                shurken.GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f, accuracy);
                shurken.tag = "Bullets";
                StartCoroutine(Attack());
                Destroy(shurken, distance);
                isAttacking = true;
                StartCoroutine(Attack());
            }
            if (Input.GetButtonDown("rightfire"))
            {
                GameObject shurken = Instantiate(attack, transform.position, Quaternion.identity);
                shurken.GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, accuracy);
                shurken.tag = "Bullets";
                StartCoroutine(Attack());
                Destroy(shurken, distance);
                isAttacking = true;
                StartCoroutine(Attack());
            }
            if (Input.GetButtonDown("upfire"))
            {
                GameObject shurken = Instantiate(attack, transform.position, Quaternion.identity);
                shurken.GetComponent<Rigidbody2D>().velocity = new Vector2(accuracy, 1.0f);
                shurken.tag = "Bullets";
                StartCoroutine(Attack());
                Destroy(shurken, distance);
                isAttacking = true;
                StartCoroutine(Attack());
            }
            if (Input.GetButtonDown("downfire"))
            {
                GameObject shurken = Instantiate(attack, transform.position, Quaternion.identity);
                shurken.GetComponent<Rigidbody2D>().velocity = new Vector2(accuracy, -1.0f);
                shurken.tag = "Bullets";
                StartCoroutine(Attack());
                Destroy(shurken, distance);
                isAttacking = true;
                StartCoroutine(Attack());
            }

            if (Input.GetButtonDown("special"))
            { if(currentMana >= 25 && equipWeapon == true)
                {
                    GameObject specialShurken = Instantiate(special, transform.position, Quaternion.identity);
                    GameObject specialShurken1 = Instantiate(special, transform.position, Quaternion.identity);
                    GameObject specialShurken2 = Instantiate(special, transform.position, Quaternion.identity);
                    GameObject specialShurken3 = Instantiate(special, transform.position, Quaternion.identity);
                    GameObject specialShurken4 = Instantiate(special, transform.position, Quaternion.identity);
                    GameObject specialShurken5 = Instantiate(special, transform.position, Quaternion.identity);
                    GameObject specialShurken6 = Instantiate(special, transform.position, Quaternion.identity);
                    GameObject specialShurken7 = Instantiate(special, transform.position, Quaternion.identity);

                    specialShurken.GetComponent<Rigidbody2D>().velocity = new Vector2(accuracy, -1.0f);
                    specialShurken1.GetComponent<Rigidbody2D>().velocity = new Vector2(accuracy, 1.0f);
                    specialShurken2.GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, accuracy);
                    specialShurken3.GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f, accuracy);
                    specialShurken4.GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, 1.5f);
                    specialShurken5.GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, -1.5f);
                    specialShurken6.GetComponent<Rigidbody2D>().velocity = new Vector2(1.5f, 1.0f);
                    specialShurken7.GetComponent<Rigidbody2D>().velocity = new Vector2(-1.5f, 1.0f);

                    specialShurken.tag = "Bullets";
                    specialShurken1.tag = "Bullets";
                    specialShurken2.tag = "Bullets";
                    specialShurken3.tag = "Bullets";
                    specialShurken4.tag = "Bullets";
                    specialShurken5.tag = "Bullets";
                    specialShurken6.tag = "Bullets";
                    specialShurken7.tag = "Bullets";

                    StartCoroutine(Attack());

                    Destroy(specialShurken, 2.0f);
                    Destroy(specialShurken1, 2.0f);
                    Destroy(specialShurken2, 2.0f);
                    Destroy(specialShurken3, 2.0f);
                    Destroy(specialShurken4, 2.0f);
                    Destroy(specialShurken5, 2.0f);
                    Destroy(specialShurken6, 2.0f);
                    Destroy(specialShurken7, 2.0f);

                    isAttacking = true;
                    currentMana -= 25;
                    PlayerStats.mana = currentMana;
                    StartCoroutine(Attack());
                }

            }

        }
    }

     IEnumerator Attack()
    {


        yield return new WaitForSeconds(attackSpeed);
        isAttacking = false;

    }
}