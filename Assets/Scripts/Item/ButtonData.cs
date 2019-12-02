using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonData : MonoBehaviour
{
    public Text buttonName;
    public RawImage itemIcon;
    public Text itemName;
    public Text itemDesc;
    public int elementIndex;

    public Transform bodyPart;

    public void Update()
    {
        buttonName = GetComponentInChildren<Text>();
        itemIcon = GameObject.FindGameObjectWithTag("Icon").GetComponent<RawImage>();
        itemName = GameObject.FindGameObjectWithTag("ItemName").GetComponent<Text>();
        itemDesc = GameObject.FindGameObjectWithTag("ItemDescription").GetComponent<Text>();
    }

    public void DisplayInfo()
    {
        buttonName.text = MainInv.inv[elementIndex].Name;
        itemIcon.texture = MainInv.inv[elementIndex].Icon;
        itemName.text = MainInv.inv[elementIndex].Name;
        itemDesc.text = MainInv.inv[elementIndex].Description;
    }

    public void DisplayMesh()
    {
        bodyPart = MainInv.equiptmentSlots[MainInv.inv[elementIndex].SlotIndex].location.transform;

        Instantiate(MainInv.inv[elementIndex].ItemMesh).transform.position = bodyPart.transform.position;
    }
}
