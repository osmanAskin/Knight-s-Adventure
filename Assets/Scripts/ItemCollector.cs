using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemCollector : MonoBehaviour
{
    private int coin = 0;

    [SerializeField] private TextMeshProUGUI coinText;

    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("coin"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            coin++;
            coinText.text = "" + coin;
        }
    }
}
