
using UnityEngine;

public class buildManager : MonoBehaviour
{
    public static buildManager instance;
    void Awake()
    { 
        if (instance != null)
        {
            Debug.LogError("more than one buildmaneger");
            return;
        }
       instance = this;
    }

     public GameObject sintprefab;
    public GameObject Level4piet;
    public GameObject Level1piet;
    public GameObject Level2piet;
    public GameObject Level3piet;

    private TowerBlueprint TowerToBuild;
    //private tile selectedtile;
   

    //public void Selecttile(tile tile)
   // {
    ///    selectedtile = tile;
    //    TowerTobuild = null;

  //  }

   

    public bool CanBuild { get { return TowerToBuild != null; } }
 
    public void BuildTowerOn(tile tile)
    {
        if (PlayerStats.Money < TowerToBuild.cost)
        {
            Debug.Log("not enough money");
            return;
        }
        PlayerStats.Money = PlayerStats.Money - TowerToBuild.cost;
        GameObject turret = (GameObject)Instantiate(TowerToBuild.prefab, tile.GetBuildPosition(), Quaternion.identity);
        tile.currentturret = turret;
        Debug.Log("Tower build money left" + PlayerStats.Money);
    }
    public void SelectTowerToBuild(TowerBlueprint turret)
    {
        TowerToBuild = turret;
    }
}
