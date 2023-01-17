
using UnityEngine;

public class shop1 : MonoBehaviour 

{  buildmanager buildmanager;
   void Start()
   {
      buildmanager = buildmanager.instance;

   }
    public void PurchasesintTurret ()
    {
        Debug.Log("sint bought");
      buildmanager.SetTurrentToBuild(buildmanager.sintprefab);
    }
   public void purchaseLevel1piet()
    {
        Debug.Log("pietlevel1 bought");
      buildmanager.SetTurrentToBuild(buildmanager.Level1piet);
    }
    public void purchaseLevel2piet()
    {
        Debug.Log("pietlevel2 bought");
       buildmanager.SetTurrentToBuild(buildmanager.Level2piet);
    }
    public void purchaseLevel3piet()
    {
        Debug.Log("pietlevel3 bought");
       buildmanager.SetTurrentToBuild(buildmanager.Level3piet);
    }
    public void purchaseLevel4piet()
    {
        Debug.Log("pietlevel4 bought");
       buildmanager.SetTurrentToBuild(buildmanager.Level4piet);
    }
}
