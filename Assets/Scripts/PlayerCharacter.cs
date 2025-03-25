using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Chama o script playermovement.cs
    private float horizontalInput; // Pegando se o idiota apertou nos botoens left arrow et right arrow
    private Rigidbody2D rb;
    private float moveSpeed = 3f;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
    }


    //private void FixedUpdate()
    //{
    //}
}