using UnityEngine;

public class HeadCheck : MonoBehaviour
{
    public float jumpForce = 7f;
    public GameObject itemDropPrefab; 

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.instance.PlayEffect(GameController.instance.enemyDeathSound);
            
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            }

            if (itemDropPrefab != null)
            {
                Vector3 offsetItem = new Vector3(0.5f, 0.2f, 0); 
                Instantiate(itemDropPrefab, transform.parent.position + offsetItem, Quaternion.identity);
            }

            Destroy(transform.parent.gameObject);
        }
    }
}