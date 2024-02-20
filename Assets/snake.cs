using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(moveSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, moveSpeed);
        }
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0, -moveSpeed);
        }
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(moveSpeed, 0);
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-moveSpeed, 0);
        }
        
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class snake : MonoBehaviour
// {
//     public GameObject tailPrefab; // Prefab for the tail segment
//     public float moveSpeed;
//     private List<Transform> tail = new List<Transform>(); // List to hold references to tail segments
//     private Rigidbody2D rb;

//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//         rb.velocity = new Vector2(moveSpeed, 0);
//     }

//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.W))
//         {
//             if (rb.velocity.y <= 0) // Ensure the snake cannot reverse direction instantly
//                 rb.velocity = new Vector2(0, moveSpeed);
//         }
//         else if (Input.GetKeyDown(KeyCode.S))
//         {
//             if (rb.velocity.y >= 0) // Ensure the snake cannot reverse direction instantly
//                 rb.velocity = new Vector2(0, -moveSpeed);
//         }
//         else if (Input.GetKeyDown(KeyCode.D))
//         {
//             if (rb.velocity.x <= 0) // Ensure the snake cannot reverse direction instantly
//                 rb.velocity = new Vector2(moveSpeed, 0);
//         }
//         else if (Input.GetKeyDown(KeyCode.A))
//         {
//             if (rb.velocity.x >= 0) // Ensure the snake cannot reverse direction instantly
//                 rb.velocity = new Vector2(-moveSpeed, 0);
//         }
//     }

//     void OnTriggerEnter2D(Collider2D other)
//     {
//         if (other.CompareTag("Food"))
//         {
//             Destroy(other.gameObject); // Destroy the food
//             GrowSnake(); // Grow the snake
//             // Here you can instantiate a new food item
//             // Example: Instantiatefood();
//         }
//     }

//     void GrowSnake()
//     {
//         Vector2 tailPosition;

//         if (tail.Count == 0)
//         {
//             tailPosition = transform.position;
//         }
//         else
//         {
//             tailPosition = tail[tail.Count - 1].position;
//         }

//         GameObject newTailSegment = Instantiate(tailPrefab, tailPosition, Quaternion.identity);
//         tail.Add(newTailSegment.transform);
//     }
// }
