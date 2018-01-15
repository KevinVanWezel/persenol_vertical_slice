/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private PlayerInput inputManager;
    [SerializeField]
    private float movementSpeed = 5;


    void Start()
    {
       
        if (!(inputManager = this.GetComponent<PlayerInput>()))
        {
            inputManager = this.gameObject.AddComponent<PlayerInput>();
        }
    }

    void Update()
    {
        Vector3 movement = new Vector3();
        if (inputManager.Up())
        {
            movement += this.transform.forward;
        }
        if (inputManager.Down())
        {
            movement -= this.transform.forward;
        }
        if (inputManager.Right())
        {
            movement += this.transform.right;
        }
        if (inputManager.Left())
        {
            movement -= this.transform.right;
        }
        movement.Normalize();
        this.transform.position += (movement * Time.deltaTime * movementSpeed);
    }
}
*/