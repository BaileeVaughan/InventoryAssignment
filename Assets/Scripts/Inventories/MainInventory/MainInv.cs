using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainInv : MonoBehaviour
{
    public bool showInv;
    public GameObject mainInv;
    public Item selectedItem;
    public Transform dropLocation;
    public static List<Item> inv = new List<Item>();
    public Vector2 scr;
    public Vector2 scrollPos;

    [System.Serializable]
    public struct equiptment
    {
        public string name;
        public Transform location;
        public GameObject curItem;
    }

    public static equiptment[] equiptmentSlots;

    public ScrollRect view;
    public RectTransform content;
    public GameObject itemButton;

    [Header("UI")]
    public static RawImage itemIcon;
    public static Text itemName;
    public static Text itemDesc;

    public void Start()
    {
        content.sizeDelta = new Vector2(2, 20);
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        mainInv.SetActive(false);
    }

    public void Update()
    {
        content.sizeDelta = new Vector2(2, 20 * inv.Count);

        if (showInv == false && Input.GetKeyDown(KeyCode.Alpha1))
        {
            showInv = true;
            mainInv.SetActive(true);
        }
        else if (showInv == true && Input.GetKeyDown(KeyCode.Alpha1))
        {
            showInv = false;
            mainInv.SetActive(false);
        }

        if (showInv == true && Input.GetKeyDown(KeyCode.I))
        {
            inv.Add(ItemData.CreateItem(Random.Range(0, 3)));
            GameObject clone = Instantiate(itemButton, content);
            clone.GetComponent<ButtonData>().elementIndex = inv.Count - 1;
            clone.name = inv[inv.Count - 1].Name;
            clone.GetComponentInChildren<Text>().text = inv[inv.Count - 1].Name;
        }
    }

}
