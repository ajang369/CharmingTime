using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> inventory = new List<Item>();
    private itemDatabase db;
    // Start is called before the first frame update
    void Start()
    {
        db = GameObject.FindGameObjectWithTag("Item Database").GetComponent<itemDatabase>();
        
        for(int i = 0;i<20;i++)
        {
            inventory.Add(db.items[i]);
        }
    }

    private void OnGUI()
    {
        for(int i=0;i<inventory.Count;i++)
        {
            GUI.Label(new Rect(10, i * 20, 200, 50), inventory[i].itemName);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
