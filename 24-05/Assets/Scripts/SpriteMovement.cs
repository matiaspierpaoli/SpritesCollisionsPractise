using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private SpriteRenderer spr;
    Vector3 worldBounds;

    private void Awake()
    {
        spr = GetComponent<SpriteRenderer>();       
        worldBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        this.transform.Translate(moveHorizontal * speed * Time.deltaTime, moveVertical * speed * Time.deltaTime, 0.0f);

        ChechForBounds();
    }

    private void ChechForBounds()
    {
        Vector3 maxPosWorld = spr.bounds.max;
        Vector3 maxPosViewPort = Camera.main.WorldToViewportPoint(maxPosWorld);

        Vector3 minPosWorld = spr.bounds.min;
        Vector3 minPosViewPort = Camera.main.WorldToViewportPoint(minPosWorld);

        if (maxPosViewPort.x >= 1)
            spr.transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);

        if (minPosViewPort.x <= 0)
            spr.transform.position = new Vector3(transform.position.x + worldBounds.x, transform.position.y, transform.position.z);

        if (maxPosViewPort.y >= 1)
            spr.transform.position = new Vector3(transform.position.x, transform.position.y - worldBounds.y, transform.position.z);
        
        if (minPosViewPort.y <= 0)
            spr.transform.position = new Vector3(transform.position.x, -transform.position.y, transform.position.z);


    }

}
