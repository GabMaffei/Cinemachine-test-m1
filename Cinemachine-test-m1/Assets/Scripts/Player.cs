using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float movementSpeed = 1.0f;
    float horizontalAxis = 0.0f;
    float verticalAxis = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        verticalAxis = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        transform.Translate(horizontalAxis,0,verticalAxis);
    }
}
