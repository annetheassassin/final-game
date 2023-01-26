
using UnityEngine;

public class shop1 : MonoBehaviour 

{
    public TowerBlueprint sintTower;
    public TowerBlueprint level1tower;
    public TowerBlueprint level2tower;
    public TowerBlueprint level3tower;
    public TowerBlueprint level4tower;
    buildManager buildManager;
   void Start()
   {
      buildManager = buildManager.instance;

   }
    public void selectsintTurret ()
    {
        Debug.Log("sint select");
      buildManager.SelectTowerToBuild(sintTower);
    }
   public void selectLevel1piet()
    {
        Debug.Log("pietlevel1 select");
      buildManager.SelectTowerToBuild(level1tower);
    }
    public void selectLevel2piet()
    {
        Debug.Log("pietlevel2  select");
       buildManager.SelectTowerToBuild(level2tower);
    }
    public void selectLevel3piet()
    {
        Debug.Log("pietlevel3 select");
       buildManager.SelectTowerToBuild(level3tower);
    }
    public void selectLevel4piet()
    {
        Debug.Log("pietlevel4 select");
       buildManager.SelectTowerToBuild(level4tower);
    }
}
