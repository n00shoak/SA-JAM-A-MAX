using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MN_manager : MonoBehaviour
{
    private static MN_manager instance;

    [SerializeField]
    public List<CL_Manager> managers;

    public void Awake()
    {
        if (MN_manager.instance == null)
        {
            MN_manager.instance = this;
        }
        else
        {
            Debug.LogError("error : two main manager detected");
            Destroy(gameObject);
            return;
        }

        managers = new List<CL_Manager>();
        managers = GetComponentsInChildren<CL_Manager>().ToList();
        DontDestroyOnLoad(gameObject);
    }

    public static T GetManagerfromGeneral<T>() where T : CL_Manager
    {
        foreach (var manager in instance.managers)
        {
            if (manager.GetType() == typeof(T))
            {
                return (T)manager;
            }
        }
        return null;
    }
}
