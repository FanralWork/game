using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public Transform player;
    [SerializeField] private int coins;
    public Text coinsText;

    void Update()
    {
        coinsText.text = coins.ToString("0");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coins++;
            Destroy(other.gameObject);
        }

    }
}
