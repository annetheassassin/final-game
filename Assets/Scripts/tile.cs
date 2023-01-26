using System.Collections;

using UnityEngine;
using UnityEngine.UIElements;

public class tile : MonoBehaviour
{
    private GameObject turret;
    public GameObject currentturret;
    public Vector3 positionOffset;
   
  // public void SelectTile (tile tile){
  //      SelectTile = tile;
   //     TowerToBuild = null;
   //     nodeUI.SetTarget(tile);
   // }

    buildManager buildManager;
    void Start()
   {
       buildManager = buildManager.instance;
       
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
        Debug.Log("click");
     

       if (turret != null)
       {
            Debug.Log("dubbel");
       buildManager.selecttile(this);
           return;
       }
           
    if (!buildManager.CanBuild)
           return;
        buildManager.BuildTowerOn(this); 
        
    }
}
