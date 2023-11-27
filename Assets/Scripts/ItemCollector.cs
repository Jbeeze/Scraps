using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int yumMeter = 0;

    [SerializeField] private TMP_Text cheeseText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Good_Item"))
        {
            Destroy(collision.gameObject);
            yumMeter += 1;
            cheeseText.text = "Yum Meter: " + yumMeter;
        }
    }

}
