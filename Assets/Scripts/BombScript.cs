using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    [SerializeField] private float bombExplode = 5;
    [SerializeField] private GameObject explodeEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bombExplodeCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
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
