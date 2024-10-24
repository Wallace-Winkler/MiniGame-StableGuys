using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{

    [SerializeField] private float bombExplode = 5;
    [SerializeField] private GameObject explodeEffect;
    void Start()
    {
        StartCoroutine(explomb());
    }

    IEnumerator explomb() {
        yield return new WaitForSeconds(bombExplode);

        Destroy(gameObject);

        explosion();
    }

    void explosion() {
        Instantiate(explodeEffect, transform.position, explodeEffect.transform.rotation);
        
    }

    IEnumerator bombExplodeCoroutine()
    {
        yield return new WaitForSeconds(bombExplode);

        explode();
        
    }

    void explode()
    {
        Destroy(gameObject);
        
        Instantiate(explodeEffect, transform.position, explodeEffect.transform.rotation);
    }
}
