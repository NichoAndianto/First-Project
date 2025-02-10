using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMen : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void EndingGame()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
