using UnityEngine;

public class Trofeu : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.instance.ShowVictoryScreen();
            Destroy(gameObject); 
        }
    }
}