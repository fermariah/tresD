using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarAnim : MonoBehaviour
{
    public Animator controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
        }

        if (Input.GetKey(KeyCode.S))
        {

        }
    }
}
