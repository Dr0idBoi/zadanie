using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot : MonoBehaviour
{
    private Inventory inventory;
    public GameObject slotButton;
    public int i;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }
    }
    public void dropItem()
    {
        foreach(Transform child in transform)
        {
            child.GetComponent<spawn>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
        }
    }
}
