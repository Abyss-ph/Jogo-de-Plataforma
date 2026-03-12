using UnityEngine;

public class Poder : MonoBehaviour
{

    public float velocidade;
    public string tagAgressor = "Inimigo";
    private Rigidbody2D rb;
    
        private void OnCollisionEnter2D(Collision2D collision)
        {
            
         if (collision.gameObject.CompareTag(tagAgressor))
         {
                    Destroy(gameObject);
         }
        }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * velocidade, ForceMode2D.Impulse);
        Destroy(gameObject, 3f);
        }
    }

}
