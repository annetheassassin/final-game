
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

    public GameObject sintprefab;
    public GameObject Level1piet;
    public GameObject Level2piet;
    public GameObject Level3piet;
    public GameObject Level4piet;
    private GameObject TowerTobuild;
    public GameObject GetTowerTobuild ()
    {
        return TowerTobuild;
    }
    public void SetTowerToBuild(GameObject Tower)
    {
        TowerTobuild= Tower;
    }
}
