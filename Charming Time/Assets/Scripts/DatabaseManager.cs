using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public string[] var_name;
    public float[] var;

    public string[] switch_name;
    public bool[] switches;

    public List<Item> itemList = new List<Item>();
    // Start is called before the first frame update
    void Start()
    {
        itemList.Add(new Item(10001, "흰색 텅스텐", "텅스텐", Item.ItemType.Quest));
        itemList.Add(new Item(10002, "검은색 텅스텐", "텅스텐", Item.ItemType.Quest));
        itemList.Add(new Item(10003, "갈색 텅스텐", "텅스텐", Item.ItemType.Quest));
        itemList.Add(new Item(10004, "노란색 텅스텐", "텅스텐", Item.ItemType.Quest));
    }

    
}
