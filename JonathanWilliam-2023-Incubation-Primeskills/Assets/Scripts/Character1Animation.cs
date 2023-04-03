using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character1Animation : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            animator.SetTrigger("Dancing");
        }
        if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("Idle");
        }
    }
}
