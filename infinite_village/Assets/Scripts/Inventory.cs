using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;

public class Inventory : MonoBehaviour
{
    private StarterAssetsInputs _input;
    List<Item> item;
    public GameObject cellContainer;
    public KeyCode showInventory;
    void Start()
    {
        item = new List<Item>();

        cellContainer.SetActive(false);
        for(int i = 0; i < cellContainer.transform.childCount; i++)
        {
            item.Add(new Item());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(showInventory))
        {
            if (cellContainer.activeSelf)
            {
                cellContainer.SetActive(false);
            }
            else
            {
                cellContainer.SetActive(true);
            }
        }
    }
}
