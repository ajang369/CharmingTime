using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int itemID;      // 아이템 고유 ID값
    public string itemName; // 아이템 이름
    public string itemDes;  // 아이템 설명
    public int itemCount;   // 아이템 개수
    public Sprite itemIcon; // 아이템 아이콘
    public ItemType itemType;
    public enum ItemType
    {
        // 열거
        Use,
        Quest,
        Equip
    }

    public Item(int ID, string Name, string Des, ItemType Type, int Count = 1)
    {
        itemID = ID;
        itemName = Name;
        itemDes = Des;
        itemType = Type;
        itemCount = Count;
        itemIcon = Resources.Load("itemIcon/" + itemID.ToString(), typeof(Sprite)) as Sprite;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
