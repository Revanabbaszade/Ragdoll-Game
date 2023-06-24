using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Balance : MonoBehaviour
{
    public float targetRotation;
    public Rigidbody2D rb;
    public float force;
    public GameObject restartButton;
 

    public void Update()
    {
        rb.MoveRotation(Mathf.LerpAngle(rb.rotation, targetRotation, force * Time.fixedDeltaTime)); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Asit")
        {
            Time.timeScale = 0;
            restartButton.SetActive(true);
            Debug.Log("xiyarrrrr");





        }
        if (collision.CompareTag("End"))
        {
            Debug.Log("Winn");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//level atlmaaaaa
        }

    }
}

