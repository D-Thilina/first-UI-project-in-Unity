using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManaegr : MonoBehaviour
{
    public GameObject HomePanel;
    public GameObject Inventory;
    public GameObject SettingsPanel;

    public void openHome()
    {
        closeAllPanal();
        HomePanel.SetActive(true);
    }

    public void openInventory()
    {
        closeAllPanal();
        Inventory.SetActive(true);
    }

    public void openSettings()
    {
        closeAllPanal();
        SettingsPanel.SetActive(true);
    }

    void closeAllPanal()
    {
        HomePanel.SetActive(false);
        Inventory.SetActive(false);
        SettingsPanel.SetActive(false);
    }

}
