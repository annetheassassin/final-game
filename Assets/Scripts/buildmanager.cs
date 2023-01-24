
using UnityEngine;

public class buildManager : MonoBehaviour
{
    public static buildManager instance;
    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogError("more than one buildmaneger");
            return;
        }
    instance = this;
    }

    private Node selectedNode;
    public void SelectNode(Node node){
        selectedNode = node;
        TowerTobuild = null;

    }

    public GameObject sintprefab;
    public GameObject Level4piet;
    public GameObject Level1piet;
    public GameObject Level2piet;
    public GameObject Level3piet;
    private GameObject TowerTobuild;
    public GameObject GetTowerTobuild ()
    {
        return TowerTobuild;
    }
    public void SetTowerToBuild(GameObject Tower)
    {
        TowerTobuild= Tower;
        selectedNode= null;
    }
}
