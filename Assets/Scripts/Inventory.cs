using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject inventoryPanel, closeButton;

    public GameObject hiddenDoor, cover, keyButton, drawOpen, otherDrawOpen, victory;

    public AudioSource buttonSound;

    public void DisplayInventory()
    {
        buttonSound.Play();
        inventoryPanel.SetActive(true);
        closeButton.SetActive(true);
    }

    public void CloseInventory()
    {
        buttonSound.Play();
        inventoryPanel.SetActive(false);
        closeButton.SetActive(false);
    }

    public void UseKey()
    {
        buttonSound.Play();
        hiddenDoor.SetActive(false);
        cover.SetActive(false);
    }

    public void Victory()
    {
        victory.SetActive(true);
    }

}
