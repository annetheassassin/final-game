using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;

    private tile target;

    public void SetTarget(tile _target){
       target = _target;
            transform.position = target.GetBuildPosition();
          //  ui.SetActive(true);
    }

   // public void Hide(){

   //     ui.SetActive(false);
  //  }

   // public void SellTurret(){
   //     PlayerStats.Money += TowerBlueprint.GetSellAmount;

    //    TowerBlueprint = null;
    //}

  //  public void Sell(){
    //    target.SellTurrert();
    //        buildManager.instance.DeselectTile();
        
    //}
}
