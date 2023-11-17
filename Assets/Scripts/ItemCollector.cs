using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int cheese = 0;

    [SerializeField] private TMP_Text cheeseText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cheese"))
        {
            Destroy(collision.gameObject);
            cheese += 1;
            cheeseText.text = "Cheese: " + cheese;
        }
    }

}
