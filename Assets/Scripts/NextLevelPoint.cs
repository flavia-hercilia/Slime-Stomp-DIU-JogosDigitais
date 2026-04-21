using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelPoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            int indexAtual = SceneManager.GetActiveScene().buildIndex;
            int proximoIndex = indexAtual + 1;

            if (proximoIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(proximoIndex);
            }
            else
            {
                GameController.instance.ShowVictoryScreen();
            }
        }
    }
}
