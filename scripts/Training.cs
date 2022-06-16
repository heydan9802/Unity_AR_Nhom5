using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    //public GameObject step1;
    public GameObject[] Step;
    //public GameObject step2;
    // public GameObject step3;
    //public GameObject step4;
    //public GameObject step5;
    //public GameObject step6;
    // public GameObject step7;
    // public GameObject step8;
    //public GameObject step9;
    //public GameObject step10;
    // Start is called before the first frame update
    int b = 0;
    int a = 0;

    public void Continue()
    {
        a++;
        b++;

        for (int i = 0; i < Step.Length; i++)
        {

            if (Step[i] != null)
            {
                Animator animator = Step[i].GetComponent<Animator>();
                if (animator != null && a == i + 1)
                {
                    //b = 1; n++;
                    bool isOpen = animator.GetBool("Back");
                    animator.SetBool("Show", !isOpen);
                    animator.SetBool("Back", !isOpen);
                    //Debug.Log(b);
                }
            }
        }
        Debug.Log(a);
        Debug.Log(b);
    }
    public void Previous()
    {
        b--;
        a--;
        if (a < 0) a = 0;
        if (b < 0) b = 0;
        Debug.Log(a);
        Debug.Log(b);
        for (int j = 0; j < Step.Length ; j++)
        {
            if (Step[j] != null)
            {
                Animator animator = Step[j].GetComponent<Animator>();
                if (animator != null && b == j)
                {
                    bool isOpen = animator.GetBool("Back");
                    animator.SetBool("Back", !isOpen);
                    animator.SetBool("Show", !isOpen);

                }
            }
        }

    }
}
