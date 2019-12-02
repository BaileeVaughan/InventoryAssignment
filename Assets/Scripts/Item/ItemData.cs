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
        int _slotIndex = 0;
        ItemType _type = ItemType.Hat;

        switch (itemID)
        {
            case 0:
                _name = "Epic Hat";
                _description = "Very cool and epic hat. Only for cool and epic people. Grants the wearer +69 attractiveness.";
                _type = ItemType.Hat;
                _icon = "Head/EpicHat";
                _mesh = "Head/EpicHat";
                _slotIndex = 0;
                break;
            case 1:
                _name = "Epic Shades";
                _description = "Shades once worn by the most epic dude. If worn by a non-epic, death is instant. Grants worthy wearers +420 future sight";
                _type = ItemType.Glasses;
                _icon = "Face/EpicShades";
                _mesh = "Face/EpicShades";
                _slotIndex = 1;

                break;
            case 2:
                _name = "Epic Glove";
                _description = "Glove once worn by Sir Epic, the coolest of the kids. Grants the wearer +666 arm strength on the chosen arm";
                _type = ItemType.Glove;
                _icon = "Hand/EpicGlove";
                _mesh = "Hand/EpicGlove";
                _slotIndex = 2;

                break;
            default:
                _name = "Epic Hat";
                _description = "Very cool and epic hat. Only for cool and epic people. Grants the wearer +69 attractiveness.";
                _type = ItemType.Hat;
                _icon = "Head/EpicHat";
                _mesh = "Head/EpicHat";
                _slotIndex = 0;

                break;
        }

        Item temp = new Item
        {
            ID = itemID,
            SlotIndex = _slotIndex,
            Name = _name,
            Description = _description,
            Icon = Resources.Load("Icons/" + _icon) as Texture2D,
            ItemMesh = Resources.Load("Mesh/" + _mesh) as GameObject,
            Type = _type
        };
        return temp;
    }
}