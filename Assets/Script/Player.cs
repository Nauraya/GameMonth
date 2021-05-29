using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed = 6f;
    private float jumpSpeed = 5f;
    private float gravity = 5f;

    private Vector3 moveD = Vector3.zero;

    CharacterController Cac;

    private int playerHealth = 20;
   
    int damge = 4;
    int damg = 2;


    void Start()
    {
        print (playerHealth);
        Cac = GetComponent<CharacterController>();

        gameObject.tag = "Player";
    }

    void Update()
    {
        //Déplacements
        if(Cac.isGrounded)
        {
            moveD = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveD = transform.TransformDirection(moveD);
            moveD *= speed;

            if(Input.GetButton("Jump"))
            {
                moveD.y = jumpSpeed;
            }
        }

        moveD.y -= gravity * Time.deltaTime;
        Cac.Move(moveD*Time.deltaTime);

        //Camera
        transform.Rotate (Vector3.up *Input.GetAxis("Mouse X")*Time.deltaTime * speed * 10);

    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Obstacles" )
        {
            playerHealth -= damge;
            Debug.Log("Touché" + playerHealth);
        }
        else if (other.tag == "Pieges")
        {
            playerHealth -= damg;
            Debug.Log("Coulé" + playerHealth);
        }

        if(playerHealth <= 0) 
        {
        
            SceneManager.LoadScene("Gameover");
        }

        if(other.tag == "Gamewin")
        {
            SceneManager.LoadScene("Gamewin");
        }
    }

}


    