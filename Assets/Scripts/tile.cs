using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tile : MonoBehaviour
{
    public GameObject currentturret;
    public Vector3 positionOffset;
    private static Canvas Canvas;
    public Canvas canvas;
    private static bool IsMenuOpen = false;
    private static int ThisMenuId;

    public GameObject ThisTower;
   

    buildManager buildManager;
    void Start()
    {
       buildManager = buildManager.instance;
       Canvas = canvas;   

        
    }

  

    void OnMouseEnter()
    {
        if (!buildManager.CanBuild)
            return;
    }
    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }
   

    void OnMouseDown()
    {
        if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            Debug.Log("dede");
            return;
        }
       Debug.Log("click");

        if ((IsMenuOpen && currentturret == null) || (currentturret != null && ThisMenuId == currentturret.GetInstanceID()))
        {
            Debug.Log("Close menu");
            CloseMenu();
            ThisMenuId = 0;
            return;
        }
        if ((!IsMenuOpen && currentturret != null) || (IsMenuOpen && currentturret != null))
        {
            OpenMenu(currentturret);
            ThisMenuId = currentturret.GetInstanceID();
            return;
        }

            if (!buildManager.CanBuild)
           return;
        buildManager.BuildTowerOn(this);
    }




    public void OpenMenu(GameObject turret)
    {
        Canvas.GetComponent<Transform>().Find("TowerInfo").gameObject.SetActive(true);
        Canvas.GetComponent<Transform>().Find("TowerInfoText").gameObject.SetActive(true);
        Canvas.GetComponent<Transform>().Find("TowerInfo").GetComponent<Transform>().Find("TowerImage").GetComponent<Image>().sprite = turret.GetComponent<SpriteRenderer>().sprite;
        Canvas.GetComponent<Transform>().Find("TowerInfo").GetComponent<tile>().ThisTower = currentturret;
        int price = turret.GetComponent<Tower>().Cost / 2;
        Canvas.GetComponent<Transform>().Find("TowerInfoText").GetComponent<Transform>().Find("Price").GetComponent<TMP_Text>().text = price.ToString();
        IsMenuOpen = true;
    }
    public void CloseMenu()
    {
        Canvas.GetComponent<Transform>().Find("TowerInfo").gameObject.SetActive(false);
        Canvas.GetComponent<Transform>().Find("TowerInfoText").gameObject.SetActive(false);
        IsMenuOpen = false;
    }

    public void SellTower()
    {
        PlayerStats.Money += ThisTower.GetComponent<Tower>().Cost/2;
        Destroy(ThisTower);
        currentturret = null;
        if (IsMenuOpen)
        {
            CloseMenu();
        }
    }
}

