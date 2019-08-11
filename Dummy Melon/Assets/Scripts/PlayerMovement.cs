using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody Player;


    void Start ()
    {
        Player = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {

        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        Player.AddForce (movement * speed);

        if (Player.position.y < -1.4f)
        {
            Debug.Log("Player is dead! TRY AGAIN!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    
    }

}
