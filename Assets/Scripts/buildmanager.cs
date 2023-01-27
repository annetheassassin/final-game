
using UnityEngine;

public class buildManager : MonoBehaviour
{
    public static buildManager instance;

    void Awake()
    { 
        if (instance != null)
        {
            Debug.LogError("more than one buildmanager");
            return;
        }
       instance = this;
    }

     public GameObject sintprefab;
    public GameObject Level1piet;
    public GameObject Level2piet;
    public GameObject Level3piet;
    public GameObject Level4piet;

    private TowerBlueprint TowerToBuild;

    public bool CanBuild { get { return TowerToBuild != null; } }
 
    public void BuildTowerOn(tile tile)
    {
        if (PlayerStats.Money < TowerToBuild.Tower.Cost)
        {
            Debug.Log("not enough money");
            return;
        }
        if (tile.currentturret != null)
        {
            Debug.Log("There is already a turret on this tile");
            return;
        }
        PlayerStats.Money = PlayerStats.Money - TowerToBuild.Tower.Cost;
        GameObject turret = Instantiate(TowerToBuild.prefab, tile.GetBuildPosition(), Quaternion.identity);
        tile.currentturret = turret;
        TowerToBuild = null;
    }
    public void SelectTowerToBuild(TowerBlueprint turret)
    {
        TowerToBuild = turret;
    }
}
