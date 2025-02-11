using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButton : MonoBehaviour
{
    public void BackMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    
}
