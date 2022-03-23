using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2f;
    Vector3 mouse;
    protected Rigidbody2D playerRB;
    // Start is called before the first frame update
    void Awake() 
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    void Rotate()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        playerRB.MoveRotation(Quaternion.Euler(0,0, Mathf.Atan2(mouse.y - playerRB.position.y, mouse.x - playerRB.position.x) * Mathf.Rad2Deg));

    }

    void Move()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        playerRB.MovePosition(playerRB.position + input * Time.fixedDeltaTime * moveSpeed);
    }

    void FixedUpdate()
    {
        
    }
}
