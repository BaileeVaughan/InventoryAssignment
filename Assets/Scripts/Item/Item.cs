using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item
{
    private int _id;
    private string _name;
    private string _description;

    private Texture2D _icon;
    private GameObject _mesh;
    private ItemType _type;
    private int _slotIndex;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }
    public int SlotIndex
    {
        get { return _slotIndex; }
        set { _slotIndex = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public Texture2D Icon
    {
        get { return _icon; }
        set { _icon = value; }
    }
    public GameObject ItemMesh
    {
        get { return _mesh; }
        set { _mesh = value; }
    }
    public ItemType Type
    {
        get { return _type; }
        set { _type = value; }
    }
}

public enum ItemType
{
    Hat,
    Glasses,
    Glove
}