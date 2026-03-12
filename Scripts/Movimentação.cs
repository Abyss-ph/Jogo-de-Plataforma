using UnityEngine;

public class Movimentação : MonoBehaviour
{
    public float velocidade = 5.0f;
    public float forcaPulo = 5f;
    public bool estaNoChao;
    private Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    
    private GameObject prota;
    //private bool destroy = false;
    public GameObject power;
    int mana = 10;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Captura entrada horizontal (A/D ou Setas)
        float moverHorizontal = Input.GetAxis("Horizontal");
        // Captura entrada vertical (W/S ou Setas)
        float moverVertical = Input.GetAxis("Vertical");

        // Calcula o vetor de movimento
        Vector3 movimento = new Vector3(moverHorizontal, 0.0f, moverVertical);

        // Move o objeto transform.Translate(direção * velocidade * tempo)
        transform.Translate(movimento * velocidade * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao) 
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
            estaNoChao = false; // Impede pulo no ar
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            spriteRenderer.flipX = true; // Vira para a esquerda
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            spriteRenderer.flipX = false; // Vira para a direita
        }
    
         
    
         if (Input.GetKeyDown(KeyCode.R)&& mana > 0)
         {
            Instantiate(power, transform.position, Quaternion.identity);

            mana--;

            Debug.Log("Mana restante: "+ mana);

         }

        if  (Input.GetKeyDown(KeyCode.R)&& 0 == mana)
        {
            Debug.Log("Aperte R para recarregar a mana");
        }


         if (Input.GetKeyDown(KeyCode.L))
         {
            mana = 10;

            Debug.Log("Mana restaurada!!");
         }
 }
         void OnCollisionEnter2D(Collision2D col) 
         {
        if (col.gameObject.CompareTag("chao")) 
        {
            estaNoChao = true; // Permite pular novamente
        }
         }
  























          //if(!destroy){
           // transform.Translate(direcao * velocidade * Time.deltaTime);
           // direcao = Vector2.zero;

           // if (Input.GetKey(KeyCode.Space))
           // {
           //     direcao += Vector2.up;
           // }


          //  if (Input.GetKey("d"))
           //// {
         //       direcao += Vector2.right;
          //  }


            //if (Input.GetKey("a"))
           // {
             //   direcao += Vector2.left;
           // }
    
}
