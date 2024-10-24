using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAutoDestruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(AutoDestruction());
    }

    IEnumerator AutoDestruction()
    {
        yield return new WaitForSeconds(5f);
        
        Destroy(gameObject);
    }
}
