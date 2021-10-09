using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDissapear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject coin = new GameObject();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
