
using UnityEngine;

public class buildManager : MonoBehaviour
{
    public static buildManager instance;
     public GameObject sintprefab;
    public GameObject Level4piet;
    public GameObject Level1piet;
    public GameObject Level2piet;
    public GameObject Level3piet;

    private TowerBlueprint TowerToBuild;
    private tile selectedtile;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("more than one buildmaneger");
            return;
        }
        instance = this;
    }


    //public void Selecttile(tile tile)
   // {
    ///    selectedtile = tile;
    //    TowerTobuild = null;

  //  }

   

    public bool CanBuild { get { return TowerToBuild != null; } }
    public void BuildTowerOn(tile tile)
    {
        GameObject turret = (GameObject)Instantiate(TowerToBuild.prefab, tile.GetBuildPosition(), Quaternion.identity);
        tile.turret = turret;
    }
    public void SelectTowerToBuild(TowerBlueprint turret)
    {
        TowerToBuild = turret;
    }
}
