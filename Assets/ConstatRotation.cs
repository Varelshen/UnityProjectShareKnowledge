using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstatRotation : MonoBehaviour
{

    public Rigidbody2D RotationObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotationObject.rotation = RotationObject.rotation + 2;
    }
}
