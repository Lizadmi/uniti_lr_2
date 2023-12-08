using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonController : MonoBehaviour
{
    public Animator animator;
    private int _state;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _state = 2;
            }
            else
            {
                _state = 1;

            }

        }
        else
        {
            _state = 0;

        }
        animator.SetInteger("state", _state);
    }
}
