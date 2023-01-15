
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
    void Start()
    {
        TurretTobuild = sintprefab;
    }
    private GameObject TurretTobuild;
    public GameObject GetTurrentTobluid ()
    {
        return TurretTobuild;
    }
}
