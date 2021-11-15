using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    [SerializeField] float steerspd = 1f;
    [SerializeField] float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0 , steerspd);
        transform.Rotate(0, moveSpeed, 0); 
    }
}
