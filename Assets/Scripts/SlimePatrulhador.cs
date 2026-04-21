using UnityEngine;

public class InimigoPatrulha : MonoBehaviour
{

    //anda de um ponto A até um ponto B, sempre nesse loop
    public Transform pontoA;
    public Transform pontoB;
    public float velocidade = 2f;
    
    private Transform destinoAtual;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        destinoAtual = pontoB;
    }

    void Update()
    {
        Vector2 destinoHorizontal = new Vector2(destinoAtual.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, destinoHorizontal, velocidade * Time.deltaTime);

        if (Mathf.Abs(transform.position.x - destinoAtual.position.x) < 0.1f)
        {
            if (destinoAtual == pontoA)
            {
                destinoAtual = pontoB;
                sr.flipX = false;
            }
            else
            {
                destinoAtual = pontoA;
                sr.flipX = true;
            }
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