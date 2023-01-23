using System.Collections;

using UnityEngine;

public class tile : MonoBehaviour
{
    private GameObject Tower;

  //  public Color hovercolor;
   // private Color startcolor;
  //  private Renderer rend;
    buildManager buildManager;
    void Start()
   {
       buildManager = buildManager.instance;
       // rend = GetComponent<Renderer>();
       // startcolor = rend.Sprite.color;
   }
   void OnMouseEnter()
   {
      // rend.Sprite.color = hovercolor;

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
    void OnMouseExit()
   {
     //  rend.Sprite.color = startcolor;
   }
}
