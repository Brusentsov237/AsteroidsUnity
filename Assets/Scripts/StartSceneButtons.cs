using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneButtons : MonoBehaviour
{
    public void StartGame()
    {
      SceneManager.LoadScene("MainScene");
    }
}
