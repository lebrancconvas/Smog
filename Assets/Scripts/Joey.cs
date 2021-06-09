using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joey : MonoBehaviour
{
    Vector2 _startPosition;
    Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update 

    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();  
    }
    void Start()
    {
        _startPosition = _rigidbody2D.position; 
       _rigidbody2D.isKinematic = true; 
    }

    void OnMouseDown() 
    {
        GetComponent<SpriteRenderer>().color = Color.red; 
    }

    void OnMouseUp() 
    {
        Vector2 currentPosition = _rigidbody2D.position;
        Vector2 direction = _startPosition - currentPosition; 
        direction.Normalize();
        _rigidbody2D.isKinematic = false;  
        _rigidbody2D.AddForce(direction * 500);  
        GetComponent<SpriteRenderer>().color = Color.white;  
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);  
        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
