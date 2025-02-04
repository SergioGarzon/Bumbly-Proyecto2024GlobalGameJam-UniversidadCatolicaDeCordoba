using UnityEngine;
using System.Collections;

public class BubbleController : MonoBehaviour
{
    public float moveSpeed = 15f; // Velocidad de movimiento horizontal
    public float verticalSpeed = 3f; // Velocidad de movimiento vertical
    public float buoyancyForce = 1.5f; // Fuerza de flotación vertical
    public int maxCollisions = 5; // Número máximo de colisiones permitidas antes de volver a la posición inicial
    public float shrinkFactor = 0.20f; // Proporción de reducción por colisión (1/5 del tamaño original)

    private Vector3 escalaOriginal;

    private Rigidbody2D rb;
    private int collisionCount = 1; // Contador de colisiones
    private int collisionCountObject = 0; // Contador de colisiones
    private Vector3 initialPosition; // Posición inicial

    public GameObject auxGObject;
    private ChangeQuitScene changeQuitScene;
    private AudioControl audioControl;

    public Sprite[] spriteBobble;

    public ParticleSystem collisionParticles;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // auxDestroy = auxGObject.GetComponent<DestroyObjects>();

        changeQuitScene = auxGObject.GetComponent<ChangeQuitScene>();
        audioControl = auxGObject.GetComponent<AudioControl>();


        initialPosition = transform.position; // Guardar la posición inicial

        escalaOriginal = transform.localScale;
    }

    void FixedUpdate()
    {
        // Movimiento horizontal y vertical controlado por el jugador
        float horizontalInput = Input.GetAxis("Horizontal"); // Flechas izquierda/derecha
        float verticalInput = Input.GetAxis("Vertical");     // Flechas arriba/abajo

        Vector2 movement = new Vector2(horizontalInput * moveSpeed, verticalInput * verticalSpeed);
        rb.AddForce(movement);

        // Flotación constante
        rb.AddForce(Vector2.up * buoyancyForce, ForceMode2D.Force);

        // Limitar velocidad horizontal y vertical
        rb.linearVelocity = new Vector2(
            Mathf.Clamp(rb.linearVelocity.x, -moveSpeed, moveSpeed),
            Mathf.Clamp(rb.linearVelocity.y, -verticalSpeed, verticalSpeed)
        );
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bobble_collection")) // Asegúrate de etiquetar los bordes como "MapEdge"
        {
            Destroy(collision.gameObject);

            audioControl.PlayAudio(1);
            HandleCollision();
        }

        if (collision.gameObject.CompareTag("MapEdge") || collision.gameObject.CompareTag("CollisionJellyfish")
            || collision.gameObject.CompareTag("CollisionOctopus") || collision.gameObject.CompareTag("CollisionOctopus")
            || collision.gameObject.CompareTag("CollisionFish") || collision.gameObject.CompareTag("CollisionTurtle")) // Asegúrate de etiquetar los bordes como "MapEdge"
        {
            CollisionWithObject();
        }


    }

    

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("AudioJellyfish"))
        {
            audioControl.PlayAudio(2);
        }

        if (collider.gameObject.CompareTag("AudioNadoPeces"))
        {
            audioControl.PlayAudio(3);
        }

        if (collider.gameObject.CompareTag("AudioOctopus"))
        {
            audioControl.PlayAudio(4);
        }

        if (collider.gameObject.CompareTag("AudioTurtle"))
        {
            audioControl.PlayAudio(5);
        }


        if (collider.gameObject.CompareTag("FumarolaArriba"))
        {
            moverArriba();
        }

        if (collider.gameObject.CompareTag("FumarolaAbajo"))
        {
            moverAbajo();
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("AudioJellyfish"))
        {
            audioControl.StopAudio(2);
        }

        if (collider.gameObject.CompareTag("AudioNadoPeces"))
        {
            audioControl.StopAudio(3);
        }
        
        if (collider.gameObject.CompareTag("AudioOctopus"))
        {
            audioControl.StopAudio(4);
        }
        if (collider.gameObject.CompareTag("AudioTurtle"))
        {
            audioControl.StopAudio(5);
        }
    }

    public void moverArriba()
    {
        Vector3 positionActual = transform.position;
        positionActual.y += 1f;
        transform.position = positionActual;
    }

    public void moverAbajo()
    {
        Vector3 positionActual = transform.position;
        positionActual.y -= 1f;
        transform.position = positionActual;
    }

    void HandleCollision()
    {
        collisionCount++;

        if(collisionCount < 10)
        {
            switch (collisionCount)
            {
                case (1): gameObject.GetComponent<SpriteRenderer>().sprite = spriteBobble[0];
                            audioControl.volumeBurbuja1();
                            break;
                case (2): gameObject.GetComponent<SpriteRenderer>().sprite = spriteBobble[1];
                            audioControl.volumeBurbuja2();
                            break;
                case (3): gameObject.GetComponent<SpriteRenderer>().sprite = spriteBobble[2];
                            audioControl.volumeBurbuja3();
                            break;
                case (4): gameObject.GetComponent<SpriteRenderer>().sprite = spriteBobble[3];
                            audioControl.volumeBurbuja4();
                            break;
                case (5): gameObject.GetComponent<SpriteRenderer>().sprite = spriteBobble[4];
                           audioControl.volumeBurbuja5();
                           break;
                case (6): gameObject.GetComponent<SpriteRenderer>().sprite = spriteBobble[5];
                          audioControl.volumeBurbuja6();
                          break;
                case (7): gameObject.GetComponent<SpriteRenderer>().sprite = spriteBobble[6]; 
                          audioControl.volumeBurbuja7();
                          break;
                case (8): gameObject.GetComponent<SpriteRenderer>().sprite = spriteBobble[7]; 
                          audioControl.volumeBurbuja8();
                          break;
            }
        }

        if(collisionCount == 9)
        {
            StartCoroutine(EsperarPasoUltimaEscena());
        }

        
    }

    public void CollisionWithObject()
    {
        collisionCountObject++;

        if (collisionCountObject < maxCollisions)
        {
            // Obtener la escala actual del objeto
            Vector3 currentScale = transform.localScale;

            // Reducir la escala en un 20% en los ejes X e Y
            currentScale.x *= 0.8f;
            currentScale.y *= 0.8f;

            // Aplicar la nueva escala al objeto
            transform.localScale = currentScale;
        }
        else
        {
            // Reiniciar posición, tamaño y contador de colisiones
            ResetBubble();
        }

    }


    IEnumerator EsperarPasoUltimaEscena()
    {
        yield return new WaitForSeconds(10.0f);

        changeQuitScene.OpenScene("EndScene");
    }

    void ResetBubble()
    {
        PlayCollisionParticles();
        // Reiniciar la posición, el tamaño y el contador

        StartCoroutine(AguardarTerminacionParticula());
    }

    IEnumerator AguardarTerminacionParticula()
    {
        yield return new WaitForSeconds(0.5f);

        if(collisionCount != 9)
        {
            transform.position = initialPosition; // Volver a la posición inicial
            transform.localScale = escalaOriginal; // Restablecer el tamaño original
            rb.linearVelocity = Vector2.zero; // Detener cualquier movimiento
            collisionCountObject = 0; // Reiniciar el contador de colisiones
        }
        
    }

    void PlayCollisionParticles()
    {
        if (collisionParticles != null)
        {
            collisionParticles.transform.position = transform.position; // Mover partículas a la posición actual
            collisionParticles.Play(); // Activar animación
        }

    }


}
