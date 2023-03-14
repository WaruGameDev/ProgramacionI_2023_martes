using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    public float speedBasket = 20;
    public float min = -8, max = 8;
    private void Update()
    {
        if(Input.GetKey(KeyCode.D)) 
        { 
            transform.Translate(Vector3.right* speedBasket * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left* speedBasket * Time.deltaTime);
        }
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, min, max);   
        transform.position = pos;
    }
    
}
