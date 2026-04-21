using UnityEngine;

public class SlimeCaminhante : MonoBehaviour
{

    //anda para a esquerda apartir de um ponto 
    public float velocidade = 2f;
    public float limiteEsquerdo = -15f;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);

        if (transform.position.x < limiteEsquerdo)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameController.instance.LoseLife();
        }
    }
}