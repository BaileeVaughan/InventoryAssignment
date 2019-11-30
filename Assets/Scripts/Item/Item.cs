using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private int _id;
    private int _amount;
    private string _name;
    private string _description;

    private Texture2D _icon;
    private GameObject _mesh;
    private ItemType _type;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }
    public int Amount
    {
        get { return _amount; }
        set { _amount = value; }
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