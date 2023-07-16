using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isDiv5 : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if(Score.score % 5 == 0 && Score.score != 0)
        {
            animator.SetBool("is5", true);
        }
        else
        {
            animator.SetBool("is5", false);
        }
    }
}
