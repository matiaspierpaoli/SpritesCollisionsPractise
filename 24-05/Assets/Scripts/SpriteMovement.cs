using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        this.transform.Translate(moveHorizontal * speed * Time.deltaTime, moveVertical * speed * Time.deltaTime, 0.0f);     
    }

}
