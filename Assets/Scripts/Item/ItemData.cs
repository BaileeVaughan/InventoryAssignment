using UnityEngine;
using UnityEngine.UI;

public static class ItemData
{
    public static Item CreateItem(int itemID)
    {
        string _name = "";
        string _description = "";
        string _icon = "";
        string _mesh = "";
        ItemType _type = ItemType.Hat;

        switch (itemID)
        {
            case 0:
                _name = "Epic Hat";
                _description = "Very cool and epic hat. Only for cool and epic people. Grants the wearer +69 attractiveness.";
                _type = ItemType.Hat;
                _icon = "Head/EpicHat";
                _mesh = "Head/EpicHat";
                break;
            case 1:
                _name = "Epic Shades";
                _description = "Shades once worn by the most epic dude. If worn by a non-epic, death is instant. Grants worthy wearers +420 future sight";
                _type = ItemType.Glasses;
                _icon = "Face/EpicGlasses";
                _mesh = "Face/EpicGlasses";
                break;
            case 2:
                _name = "Epic Glove";
                _description = "Glove once worn by Sir Epic, the coolest of the kids. Grants the wearer +666 arm strength on the chosen arm";
                _type = ItemType.Glove;
                _icon = "Hand/EpicGlove";
                _mesh = "Hand/EpicGlove";
                break;
            default:
                _name = "Epic Hat";
                _description = "Very cool and epic hat. Only for cool and epic people. Grants the wearer +69 attractiveness.";
                _type = ItemType.Hat;
                _icon = "Head/EpicHat";
                _mesh = "Head/EpicHat";
                break;
        }

        Item temp = new Item
        {
            ID = itemID,
            Name = _name,
            Description = _description,
            Icon = Resources.Load("Icons/" + _icon) as Image,
            ItemMesh = Resources.Load("Mesh/" + _mesh) as GameObject,
            Type = _type
        };
        return temp;
    }
}