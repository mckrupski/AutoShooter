using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        //pobiera stan kontrolera (poziom)
        float x = Input.GetAxis("Horizontal");
        //wylicz docelowy ruch poziomu
        Vector3 movement = Vector3.right * x * Time.deltaTime;
        //na³ó¿ zmiane polozenia na obiekt gracza

        float y = Input.GetAxis("Vertical");
        movement += Vector3.forward * y * Time.deltaTime;

        movement = movement.normalized;

        movement = moveSpeed;

        transform.position = movement;
    }
}
