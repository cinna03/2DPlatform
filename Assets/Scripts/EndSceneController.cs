using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneController : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("GameScene-ALU");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
