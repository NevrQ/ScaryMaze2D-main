using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public string NextScene;

    private void OnCollisionEnter2D (Collision2D collision)
    {
        SceneManager.LoadScene(NextScene);
        return;
    }
}
