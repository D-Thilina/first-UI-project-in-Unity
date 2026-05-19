using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManaegr : MonoBehaviour
{
    public GameObject HomePanel;
    public GameObject Inventory;
    public GameObject SettingsPanel;
    public GameObject MailPanel;
    public GameObject CalenderPanel;

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

    public void openmailPanel()
    {
        closeAllPanal();
        MailPanel.SetActive(true);
    }

    public void openCalender(){
        closeAllPanal();
        CalenderPanel.SetActive(true);
    }


    void closeAllPanal()
    {
        HomePanel.SetActive(false);
        Inventory.SetActive(false);
        SettingsPanel.SetActive(false);
        MailPanel.SetActive(false);
        CalenderPanel.SetActive(false);
    }

}
