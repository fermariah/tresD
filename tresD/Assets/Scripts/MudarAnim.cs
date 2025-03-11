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
        if (Input.GetKeyDown(KeyCode.W))
        {
            controller.SetTrigger("muda");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            controller.SetTrigger("desmuda");
        }
    }
}
