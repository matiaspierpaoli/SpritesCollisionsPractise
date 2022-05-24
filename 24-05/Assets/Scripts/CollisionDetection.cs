using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private SpriteRenderer spr;
    private float timer;
    private float maxSeconds;

    private void Awake()
    {
        timer = 0f;
        maxSeconds = 5;
        spr = GetComponent<SpriteRenderer>();
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        for (int i = 0; i < maxSeconds; i++)
            FlashAfterCollision();
                
        spr.color = Color.red;
        
    }

    private void FlashAfterCollision()
    {
        timer += Time.deltaTime;

    }

}
