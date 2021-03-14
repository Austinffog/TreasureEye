using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("InventoryController").GetComponent<Inventory>();
        //assign the inventory variable to the InventoryController gameObject with the Inventory script
    }

    // Update is called once per frame
    void Update()
    {
        PickUpItem();
    }

    private void PickUpItem()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //gets the vector3 mouse position
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y); //gets the x and y axis of the mousePos position

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero); //raycast to the target mousePos2D
            if (hit.collider != null) //check if the gameobject has a collider
            {
                //if the collider object matches the name and the gameobject name, destroy it and include it in the inventory
                if (hit.collider.gameObject.name == "Blood" && gameObject.name == "Blood" || hit.collider.gameObject.name == "PoisonDagger"
                    && gameObject.name == "PoisonDagger" || hit.collider.gameObject.name == "BrokenLamp" && gameObject.name == "BrokenLamp"
                    || hit.collider.gameObject.name == "Carpet" && gameObject.name == "Carpet"
                    || hit.collider.gameObject.name == "Book" && gameObject.name == "Book"
                    || hit.collider.gameObject.name == "Key" && gameObject.name == "Key"
                    || hit.collider.gameObject.name == "Bucket" && gameObject.name == "Bucket"
                    || hit.collider.gameObject.name == "Compass" && gameObject.name == "Compass"
                    || hit.collider.gameObject.name == "Vase" && gameObject.name == "Vase")
                {
                    for (int i = 0; i < inventory.slots.Length; i++) //loop through the amount of slots in the inventory available
                    {
                        if (inventory.isFull[i] == false) //check if the inventory slot is full
                        {
                            inventory.isFull[i] = true; //if it isn't set it to full and instantiate the gameobject image in the slot
                            Instantiate(item, inventory.slots[i].transform.position, Quaternion.identity, inventory.slots[i].transform);
                            Destroy(gameObject);

                            if (inventory.isFull[5] == true)
                            {
                                Transform cabinet = GameObject.Find("Cabinet").GetComponent<Transform>();
                                cabinet.position = new Vector3(-0.17f, 1.15f, 0f);
                            }

                            if (inventory.isFull[8] == true)
                            {
                                inventory.Victory();
                            }
                            break;
                        }
                    }
                }

                if (hit.collider.gameObject.name == "Key" && gameObject.name == "Key")
                {
                    inventory.keyButton.SetActive(true);
                }

                if (hit.collider.gameObject.name == "Draw" && gameObject.name == "Draw")
                {
                    inventory.drawOpen.SetActive(true);
                }

                if (hit.collider.gameObject.name == "Draw (1)" && gameObject.name == "Draw (1)")
                {
                    inventory.otherDrawOpen.SetActive(true);
                }

                if (hit.collider.gameObject.name == "DrawClose" && gameObject.name == "DrawClose")
                {
                    inventory.drawOpen.SetActive(false);
                    inventory.otherDrawOpen.SetActive(false);
                }
            }
        }
    }
}
