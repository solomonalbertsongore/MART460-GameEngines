using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = .1f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      // Allows the player to move side to side
      float playerHorizontal = Input.GetAxis("Horizontal");

      // Transform the position of the player by taking the access (Vector3.example) * the assigned player speed * the Input value
      transform.Translate(Vector3.right * speed * playerHorizontal);
    }
}
