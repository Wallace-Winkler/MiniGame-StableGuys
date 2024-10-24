using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{

    [SerializeField] private GameObject explosionPrefab;
    [SerializeField] private float timeForExplosion = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(explomb());
    }

    IEnumerator explomb() {
        yield return new WaitForSeconds(timeForExplosion);

        Destroy(gameObject);

        explosion();
    }

    void explosion() {
        Instantiate(explosionPrefab, transform.position, explosionPrefab.transform.rotation);
    }
}
