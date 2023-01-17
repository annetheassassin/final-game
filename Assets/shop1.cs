
using UnityEngine;

public class shop1 : MonoBehaviour 

{   Buildmanager buildmanager;
    void Start()
    {
        buildmanager = Buildmanager.instance;

    }
    public void PurchasesintTurrut ()
    {
        Debug.Log("sint bought");
        buildmanager.SetTurretToBuild(buildmanager.sintprefab);
    }
   public void purchaseLevel1piet()
    {
        Debug.Log("pietlevel1 bought");
        buildmanager.SetTurretToBuild(buildmanager.Level1piet);
    }
    public void purchaseLevel2piet()
    {
        Debug.Log("pietlevel2 bought");
        buildmanager.SetTurretToBuild(buildmanager.Level2piet);
    }
    public void purchaseLevel3piet()
    {
        Debug.Log("pietlevel3 bought");
        buildmanager.SetTurretToBuild(buildmanager.Level3piet);
    }
    public void purchaseLevel4piet()
    {
        Debug.Log("pietlevel4 bought");
        buildmanager.SetTurretToBuild(buildmanager.Level4piet);
    }
}
