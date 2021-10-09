using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetCoins : MonoBehaviour
{
    public int coinCounter=0;
    public Text coinDisplay;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerCoins = new GameObject();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coinCounter = coinCounter + 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        coinDisplay.text = coinCounter.ToString();
        if (coinCounter>=10)
        {
            SceneManager.LoadScene("End");
        }
    }
}
