using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField]private float speed;  //G�re s�dan s� at jeg kan �ndre spilleren hastighed i Unity 

    private void Awake()
    {
        body= GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(horizontalInput*speed, body.velocity.y);  // G�r s� spilleren bev�ger sig h�jre eller vestre 


        if (horizontalInput > 0)
            transform.localScale = Vector3.one;

        else if (horizontalInput < 0)
            transform.localScale = new Vector3(-1,1,1);      // G�re s�dan s� at spillerens sprite kigger den retning man bev�ger sig imod

        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);  // Spilleren hopper hvis man trykker Space//

        if (Input.GetKey(KeyCode.W))
            body.velocity = new Vector2(body.velocity.x, speed);   // Spiller hopper hvis man trykker W //

        if (Input.GetKey(KeyCode.UpArrow))
            body.velocity = new Vector2(body.velocity.x, speed);   // Spiller hopper hvis man trykker Up knap //
    }
} 
