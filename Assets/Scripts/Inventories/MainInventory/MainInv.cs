using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MainInv : MonoBehaviour
{
    public bool showInv;
    public Item selectedItem;
    public Transform dropLocation;
    public List<Item> inv = new List<Item>();
    public Vector2 scr;
    public Vector2 scrollPos;

    [System.Serializable]
    public struct equiptment
    {
        public string name;
        public Transform location;
        public GameObject curItem;
    }

    public equiptment[] equiptmentSlots;

    public ScrollRect view;
    public RectTransform content;
    public GameObject itemButton;

    public void Start()
    {
        content.sizeDelta = new Vector2(2, 1);
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void Update()
    {
        content.sizeDelta = new Vector2(2, 1 * inv.Count);

        if (Input.GetKey(KeyCode.I))
        {
            inv.Add(ItemData.CreateItem(0));
            GameObject clone = Instantiate(itemButton, content);
            clone.name = inv[inv.Count - 1].Name;
            clone.GetComponentInChildren<Text>().text = inv[inv.Count - 1].Name;
        }
    }
}
