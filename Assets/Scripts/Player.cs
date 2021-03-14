using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private static float moveSpeed;
    private float horizontal, vertical;
    private static Vector2 moveDirection;
    private static Rigidbody2D rigidBody;

    private static int poisonAmount;
    public static float health = 100f;
    public Text healthAmount;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveInput();
    }

    private void FixedUpdate()
    {
        MovementSpeed(3f);
        rigidBody.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    #region Movement 
    private void MoveInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(horizontal, vertical).normalized;
    }

    public static float MovementSpeed(float speed)
    {
        moveSpeed = speed;
        return speed;
    }
    #endregion

    public static int Poison(int poison)
    {
        poisonAmount = poison;
        return poison;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == ("PoisonDagger"))
        {
            Poison(2);
            health -= poisonAmount;
            healthAmount.text = "Health: " + health.ToString();

        }
    }
}

/*
 * Reference Sound
 * Freesound. 2021. Mystery_Chime by Unaxete, 29 November 2015. [Online]. Available at: 
 * https://freesound.org/people/Unaxete/sounds/329795/. [Accessed 11 March 2021].
 */
