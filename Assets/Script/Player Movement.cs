using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    float inputHorizontal;
    float inputVertical;
    public float speed = 3f; // Kecepatan gerakan objek
    bool facingRight = true;
    private SpriteRenderer sprite;

    private void Start()
    {
        // sprite = GetComponent<SpriteRenderer>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Input dari pemain
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Gerakan objek
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * speed * Time.deltaTime;
        transform.Translate(movement);

        
        // //flip direction
        // dirX =  Input.GetAxisRaw("Horizontal");

        //new
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        // if (inputHorizontal != 0)
        // {
        //     rb.AddForce(new Vector2(inputHorizontal * speed, 0f));
        // }

        if (inputHorizontal > 0 && !facingRight)
        {
            Flip();
        }

        if (inputHorizontal < 0 && facingRight)
        {
            Flip();
        }

        void Flip()
        {
            Vector3 currentScale = gameObject.transform.localScale;
            currentScale.x *= -1;
            gameObject.transform.localScale = currentScale;

            facingRight = !facingRight;
        }
    }
    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     // ukuranIkan = gameObject.transform.localScale;
    //     if (other.gameObject.CompareTag("Makan1")){
    //         Destroy(other.gameObject);
    //         // ukuranIkan.x = ukuranIkan.x + 1;
    //         // ukuranIkan.y = ukuranIkan.y + 1;
            
    //     }
    // }
}
