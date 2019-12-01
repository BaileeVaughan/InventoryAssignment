using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Radial : MonoBehaviour
{
    public bool showInv;
    public GameObject radialInv;
    public GameObject player;

    [System.Serializable]
    public struct equiptment
    {
        public string name;
        public Transform location;
        public GameObject curItem;
    }

    public equiptment[] equiptmentSlots;


    public Image itemIcon;
    public GameObject itemButton;

    private void Start()
    {
        radialInv.SetActive(false);
        player.SetActive(false);
    }

    public void Update()
    {
        if (showInv == false && Input.GetKey(KeyCode.Alpha2))
        {
            showInv = true;
            radialInv.SetActive(true);
            player.SetActive(true);            
        }        
        else if (showInv == true && Input.GetKeyUp(KeyCode.Alpha2))
        {
            radialInv.SetActive(false);
            player.SetActive(false);
            showInv = false;
        }
    }
}
