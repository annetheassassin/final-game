using System.Collections;

using UnityEngine;
using UnityEngine.UIElements;

public class tile : MonoBehaviour
{
    private GameObject Tower;
    public GameObject currentturret;
    public Vector3 positionOffset;
   

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
        buildManager.BuildTowerOn(this);

       if (Tower != null)
       {
            Debug.Log("cant place here");
           return;
       }
         

    }
}
