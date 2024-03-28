using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class totalPrice : MonoBehaviour
{
    private List<Price> itemsInTrolley = new List<Price>();
    public TMP_Text totalAmountText;
    public GameObject setActive2;
    public GameObject update1;
    float maxAmount = 20;

    float totalAmount;

    private void Start()
    {
        UpdateTotalAmountText();
    }

    private void OnTriggerEnter(Collider other)
    {
        Price item = other.GetComponent<Price>();
        if (item != null && !itemsInTrolley.Contains(item))
        {
            itemsInTrolley.Add(item);
            UpdateTotalAmountText();
            if (totalAmount < maxAmount && update1.activeSelf)
            {
                setActive2.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Price item = other.GetComponent<Price>();
        if (item != null && itemsInTrolley.Contains(item))
        {
            itemsInTrolley.Remove(item);
            UpdateTotalAmountText();

        }
    }

    private void UpdateTotalAmountText()
    {
        float totalAmount = CalculateTotalAmount();
        totalAmountText.text = "£" + totalAmount.ToString("F2");
    }

    public float CalculateTotalAmount()
    {
        float totalAmount = 0f;
        foreach (Price item in itemsInTrolley)
        {
            totalAmount += item.price;
        }
        return totalAmount;
    }
}
