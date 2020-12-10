using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] cars;
    int carNo;
    public float maxpos = 2f;
    public float delayTimer = 2f;
    float timer;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 carPos = new Vector3(Random.Range(-2f, 2f), transform.position.y, transform.position.z);
            carNo = Random.Range (0,4);
            Instantiate(cars[carNo], carPos, transform.rotation);
            timer = delayTimer;
        }
        
       
    }
}
