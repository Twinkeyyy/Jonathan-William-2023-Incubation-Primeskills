using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2Animation : MonoBehaviour
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
        if (Input.GetKeyDown("y"))
        {
            animator.SetTrigger("Dancing");
        }
        if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("Idle");
        }
    }
}