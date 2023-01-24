using System.Collections;

using UnityEngine;

public class tile : MonoBehaviour
{
    private GameObject Tower;
    public GameObject turret;

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
       if (!buildManager.CanBuild)
           return;

       if (Tower != null)
       {
            Debug.Log("cant place here");
           return;
       }
         buildManager.BuildTowerOn(this);

    }
}
