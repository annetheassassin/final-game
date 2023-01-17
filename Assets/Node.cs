using System.Collections;

using UnityEngine;

public class Node : MonoBehaviour
{
    private GameObject turret;
    buildmanager buildmanager;
     void Start()
    {
        buildmanager = buildmanager.instance;
    }
    void OnMouseDown()
    {
        if (buildmanager.GetTurrentTobluid() == null) 
        return; 

        if(turret != null)
        {
            Debug.Log("cant place here");
            return;
        }
        GameObject turrentToBuilt = buildmanager.GetTurrentTobluid();
        turret = (GameObject) Instantiate(turrentToBuilt, transform.position, transform.rotation);

    }
}
