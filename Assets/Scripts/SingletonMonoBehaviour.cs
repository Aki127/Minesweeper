using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T :
 SingletonMonoBehaviour<T>
{
    protected static T instance;

    public static T Instance
    {
        get
        {
            if(instance == null)
            {
                instance = (T) FindObjectOfType(typeof(T));
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.AddComponent<T>();
                    obj.name = "_singleton" + typeof(T).ToString();
                    Debug.LogWarning(typeof(T) + " is noting");
                }
            }
            return instance;
        }
    }

    protected void Awake()
    {
        OnAwake();
        CheckInstance();
    }

	 public void InstanceSingleton() 
     {
        if(instance == null)
        {
            instance = (T)FindObjectOfType(typeof(T));
            GameObject obj = new GameObject();
            obj.AddComponent<T>();
            obj.name = " _singleton" + typeof(T).ToString();
            if(instance == null)
            {
                Debug.LogWarning(typeof(T) + "is noting");
            }
        }
		
	}

    virtual protected void OnAwake()
    {     
    }

    protected bool CheckInstance()
    {
        if(instance == null)
        {
        instance = (T)this;
        return true;
        }

    Destroy(this.gameObject);
        return false;
            

	}
}
