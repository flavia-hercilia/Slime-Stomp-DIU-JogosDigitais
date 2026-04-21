using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;
    public GameObject collected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.CompareTag("Player"))
        {
            GameController.instance.PlayEffect(GameController.instance.fruitSound);
            
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);

            GameController.instance.GainLife();

            Destroy(gameObject,0.3f);
        }
    }

}
