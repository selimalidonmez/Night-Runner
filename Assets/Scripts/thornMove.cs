using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thornMove : MonoBehaviour
{

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
