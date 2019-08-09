using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int count; 
    public Text countText;

    
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        
    }
    void FixedUpdate ()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(MoveHorizontal, 0.0f, MoveVertical);
        
        rb.AddForce(movement * speed, ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Cosito"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();

        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
}
