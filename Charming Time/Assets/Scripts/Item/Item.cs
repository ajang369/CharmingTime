using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Item
{
    public string itemName;             //아이템 이름
    public int itemID;                  //아이템 고유번호
    public string itemDes;              //아이템 설명
    public Texture2D itemIcon;          //아이템 아이콘
    public ItemType itemType;

    public enum ItemType
    {
        Quest, Use
    }

    public Item()
    {

    }

    public Item(string name, int id, string desc, ItemType type)
    {
        itemName = name;
        itemID = id;
        itemDes = desc;
        itemType = type;
    }

}
    

