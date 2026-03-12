using UnityEngine;

public class DanoAtaque : MonoBehaviour
{
    public int health = 10; // Vida total do objeto
    public string tagAgressor = "Power"; // Tag do objeto que causa dano

    // Chamado quando a colisão física ocorre
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto que tocou tem a tag correta
        if (collision.gameObject.CompareTag(tagAgressor))
        {
            TakeDamage(15); // Recebe 1 de dano
            Debug.Log("Objeto tocado! Dano recebido. Vida restante: " + health);
        }
    }


    // Método para reduzir a vida
    void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Objeto destruído!");
        Destroy(gameObject);
    }

 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



    }
} 