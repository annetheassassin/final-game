
using UnityEngine;

public class shop1 : MonoBehaviour 

{  buildManager buildManager;
   void Start()
   {
      buildManager = buildManager.instance;

   }
    public void PurchasesintTurret ()
    {
        Debug.Log("sint bought");
      buildManager.SetTowerToBuild(buildManager.sintprefab);
    }
   public void purchaseLevel1piet()
    {
        Debug.Log("pietlevel1 bought");
      buildManager.SetTowerToBuild(buildManager.Level1piet);
    }
    public void purchaseLevel2piet()
    {
        Debug.Log("pietlevel2 bought");
       buildManager.SetTowerToBuild(buildManager.Level2piet);
    }
    public void purchaseLevel3piet()
    {
        Debug.Log("pietlevel3 bought");
       buildManager.SetTowerToBuild(buildManager.Level3piet);
    }
    public void purchaseLevel4piet()
    {
        Debug.Log("pietlevel4 bought");
       buildManager.SetTowerToBuild(buildManager.Level4piet);
    }
}
