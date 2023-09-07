using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Rigidbody2D>().AddForce(transform.position * 5, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
