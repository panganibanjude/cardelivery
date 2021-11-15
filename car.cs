using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{

    private float move, moveSpeed, rotation, rotationSpeed;//DECLARING VARIABLES
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 4f;
        rotationSpeed = 75f;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;//CODE FOR THE MOVEMENT VERTICAL
        rotation = Input.GetAxis("Horizontal") * - rotationSpeed * Time.deltaTime;//CODE FOR THE MOVEMENT HORIZONTAL

    }
    
    private void LateUpdate() 
    {
        transform.Translate (0f, move, 0f);//UPDATING THE MOVEMENT AND ROTATION BY USING TRANSLATE
        transform.Rotate(0f, 0f, rotation);
    }

}
