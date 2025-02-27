using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneAfterSecond : MonoBehaviour
{
    public  LoadScene ls;
    public float second;
    public string sceneName;
    void Start()
    {
        Invoke("ChangeAfterSecond", second);
    }

    private void ChangeAfterSecond()
    {
        ls.ChangeScene(sceneName);
    }
 
}
