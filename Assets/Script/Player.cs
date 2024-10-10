using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] string nextLevelName;
    Camera playerCamera;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    private Vector3 originalPosition;
    private int fruitCounter;
    TMP_Text fruitsInLevel;
    public TMP_Text vic;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = rb.GetComponentInChildren<SpriteRenderer>();
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var cameraPos = playerCamera.transform.position;
        cameraPos.x = transform.position.x;
        playerCamera.transform.position = cameraPos;

        float x = Input.GetAxisRaw("Horizontal");

        var velocity = rb.velocity;
        velocity.x = 5f * x;
        rb.velocity = velocity;

        if (x != 0)
        {
            // on pese a droite, x = 1 alors 1 < 0 = false
            // on pese a gauche x = -1 alors -1 < 0 = true
            spriteRenderer.flipX = x < 0;
        }
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= -1;
            spriteRenderer.flipY = !spriteRenderer.flipY;
        }
    }

    

    

    public void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        Invoke("Reset",0.5f);
    }
    private void Reset()
    {
        rb.bodyType= RigidbodyType2D.Dynamic;
        transform.position = originalPosition;
    }

    internal void CollectFruit()
    {
        Debug.Log(fruitCounter);
        if (++fruitCounter == 5)
        {
            if (string.IsNullOrEmpty(nextLevelName)) 
            {
                FindAnyObjectByType<Timer>().StopTimer();
                vic.color = Color.green;
            }
            else
            {
                SceneManager.LoadScene(nextLevelName);
                fruitCounter = 1;
            }

            
        }
    }
}
