using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Character4Animation : MonoBehaviour
{
    private Animator animator;
    private float speed;
    public float acc;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && speed < 2f)
        {
            speed += Time.deltaTime * acc;
        }

        if (!(Input.GetKey(KeyCode.LeftShift)) && speed > 0f)
        {
            speed -= Time.deltaTime * acc;
        }

        animator.SetFloat("Blend", speed);
    }
}
