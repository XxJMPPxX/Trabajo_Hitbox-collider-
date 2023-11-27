using UnityEngine;

public class Amogus : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private SpriteRenderer _compSpriteRenderer;

    public float velocidadX;
    public float velocidadY;
    public int direccionX = 1; 
    public int direccionY = 1; 

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "VERTICAL")
        {
            if (direccionX == 1)
            {
                direccionX = -1;
                _compSpriteRenderer.flipX = true;
            }
            else if (direccionX == -1)
            {
                direccionX = 1;
                _compSpriteRenderer.flipX = false;
            }
        }

        
        if (collision.gameObject.tag == "HORIZONTAL")
        {
            if (direccionY == 1)
            {
                direccionY = -1;
                _compSpriteRenderer.flipY = true;
            }
            else if (direccionY == -1)
            {
                direccionY = 1;
                _compSpriteRenderer.flipY = false;
            }
        }
    }

    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(velocidadX * direccionX * Time.deltaTime, velocidadY * direccionY * Time.deltaTime);
    }
}