using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField]private float speed;  //Gøre sådan så at jeg kan ændre spilleren hastighed i Unity 

    private void Awake()
    {
        body= GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(horizontalInput*speed, body.velocity.y);  // Gør så spilleren bevæger sig højre eller vestre 


        if (horizontalInput > 0)
            transform.localScale = Vector3.one;

        else if (horizontalInput < 0)
            transform.localScale = new Vector3(-1,1,1);      // Gøre sådan så at spillerens sprite kigger den retning man bevæger sig imod

        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);  // Spilleren hopper hvis man trykker Space//

        if (Input.GetKey(KeyCode.W))
            body.velocity = new Vector2(body.velocity.x, speed);   // Spiller hopper hvis man trykker W //

        if (Input.GetKey(KeyCode.UpArrow))
            body.velocity = new Vector2(body.velocity.x, speed);   // Spiller hopper hvis man trykker Up knap //
    }
} 
