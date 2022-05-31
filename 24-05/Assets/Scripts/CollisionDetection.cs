using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private SpriteRenderer spr;
    private Color originalColor;
    private float timer;
    private float maxSeconds;

    private void Awake()
    {
        timer = 0f;
        maxSeconds = 5;
        spr = GetComponent<SpriteRenderer>();
        originalColor = GetComponent<Color>();


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {               
        spr.color = Color.red;
       
        FlashAfterCollision();

    }

    private void FlashAfterCollision()
    {
        timer += Time.deltaTime;
        //float a = Mathf.Sin(timer) * 0.5 + 0.5;
        spr.material.color = new Color(originalColor.r, originalColor.g, timer);

    }

}
