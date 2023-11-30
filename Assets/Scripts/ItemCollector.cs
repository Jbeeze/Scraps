using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int yumMeter = 0;

    [SerializeField] private TMP_Text yumText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        
        if (collision.gameObject.CompareTag("Good_Item"))
        {
            yumMeter += 1;
        }
        
        else
        {
            yumMeter -= 1;
        }

        yumText.text = "Yum Meter: " + yumMeter;
    }

}
