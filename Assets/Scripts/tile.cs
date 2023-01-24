using System.Collections;

using UnityEngine;

public class tile : MonoBehaviour
{
    private GameObject Tower;

    buildManager buildManager;
    void Start()
   {
       buildManager = buildManager.instance;
       
   }

    void OnMouseDown()
    {
        Debug.Log("click");
       if (buildManager.GetTowerTobuild() == null)
           return;

       if (Tower != null)
       {
            Debug.Log("cant place here");
           return;
       }
        GameObject TowerToBuild = buildManager.GetTowerTobuild();
        Tower = (GameObject)Instantiate(TowerToBuild, transform.position, transform.rotation);

    }
}
