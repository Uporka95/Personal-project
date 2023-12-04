using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerControll : MonoBehaviour
{

    public float speed = 10;
    private float horizontalInput, verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(new Vector3(horizontalInput * speed * Time.deltaTime, 0,
            verticalInput * speed * Time.deltaTime));
        if (transform.position.x < -20 || transform.position.x > 20
                                      || transform.position.z < -20
                                      || transform.position.z > 20)
            transform.position = new Vector3(0,2,0);

    }

    void BeforeUpdate()
    {
       
    }

}
