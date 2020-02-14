using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Start()
    {
        items.Add(new Item("White String", 0001, "흰색 텅스텐", Item.ItemType.Quest));
        items.Add(new Item("Yellow String", 0002, "노란색 텅스텐", Item.ItemType.Quest));
        items.Add(new Item("Brown String", 0003, "갈색 텅스텐", Item.ItemType.Quest));
        items.Add(new Item("Black String", 0004, "검은색 텅스텐", Item.ItemType.Quest));
    }
}
