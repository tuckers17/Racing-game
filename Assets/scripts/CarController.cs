using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float carSpeed;
    public float maxpos = 2.1f;
    

    Vector3 position;
    public uiManager ui;

    
    // Start is called before the first frame update
    void Start()
    {
       // ui = GetComponent<uiManager> ();
        position = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;

        position.x = Mathf.Clamp(position.x, -2.1f, 2.1f);

        transform.position = position;
    }
    void OnCollisionEnter2D(Collision2D col) { 
        if (col.gameObject.tag == "Enemy Car") { 
            Destroy(gameObject);
            ui.gameOverActivated();
        }
    }
}
