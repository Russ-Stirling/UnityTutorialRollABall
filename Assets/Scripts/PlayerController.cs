using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speedMultipier;
    private Rigidbody rb;
    private int Score;
    public Text ScoreText;
    public Text VictoryText;

    void Start()
    {
        Score = 0;
        rb = GetComponent<Rigidbody>();
        SetTextOfScore();
        VictoryText.text = string.Empty;
    }
    void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHoriz, 0, moveVert);

        rb.AddForce(movement * speedMultipier);
    }

    private void SetTextOfScore()
    {
        ScoreText.text = string.Format("Score: {0}", Score);
    }

    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            Score++;
            SetTextOfScore();
            if(Score>=6)
            {
                VictoryText.text = "Congratulations!!";
            }
        }

        
        //Destroy(other.gameObject);
    }
}
