
using UnityEngine;

public class buildmanager : MonoBehaviour
{
    public static buildmanager instance;
    void Awake ()
    {
        if (instance != null)
        {
            Debug.LogError("more than one builmaneger");
            return;
        }
    instance = this;
    }

    public GameObject sintprefab;
    public GameObject Level4piet;
    public GameObject Level1piet;
    public GameObject Level2piet;
    public GameObject Level3piet;
    private GameObject TurretTobuild;
    public GameObject GetTurrentTobluid ()
    {
        return TurretTobuild;
    }
    public void SetTurrentToBuild(GameObject Tower)
    {
        TurretTobuild= Tower;
    }
}
