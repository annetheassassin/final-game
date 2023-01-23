using System.Collections;
using UnityEngine;

public class Tilescript : MonoBehaviour
{
    //buildmanager buildmanager;
    //private GameObject Tower;
  
    //public Color hovercolor;
   // private Color startcolor;
   // private Renderer rend;
    void Start()
    {
        //buildmanager = buildmanager.instance;
       // rend = Getcomponent<Renderer>();
       // startcolor = rend.sprite.color;
    }
   // void OnMouseEnter()
   // {
       // rend.sprite.color = hovercolor;

   // }

    void OnMouseDown()
   {
       Debug.Log("click");
      //  if (buildmanager.GetTowerTobluid() == null)
       //     return;

     //   if (Tower != null)
      //  {
      //      Debug.Log("cant place here");
       //     return;
     //   }
      //  GameObject TowerToBuilt = buildmanager.GetTowerTobluid();
      //  Tower = (GameObject)Instantiate(TowerToBuilt, transform.position, transform.rotation);

   }
    //void OnMouseExit()
   // {
       // rend.sprite.color = startcolor;
    //}
}
