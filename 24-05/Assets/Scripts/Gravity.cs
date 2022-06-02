using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float force;

    public void Update()
    {
        Absorb();
    }

    private void Absorb()
    {
        Vector3 absorbVector = (gameObject.transform.position - player.transform.position).normalized;
        player.transform.position += absorbVector* Time.deltaTime * force;
    }
}
