using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackLHand : MonoBehaviour
{
    public GameObject step1;
    public GameObject step2;
    public GameObject step3;
    public GameObject step4;
    public GameObject step5;
    public GameObject step6;
    public GameObject step7;
    public GameObject step8;


    //public GameObject[] obj ;
    int b = 1; 
    int a = 0;

    public void Continue()
    {
        a++;
        b++;
        Debug.Log(a);
        Debug.Log(b);
        if (step1 != null)
        {
            Animator animator = step1.GetComponent<Animator>();
            if (animator != null &&  a == 1)
            {
                //b = 1; n++;
                bool isOpen = animator.GetBool("Back");
                animator.SetBool("Show", !isOpen);
                animator.SetBool("Back", !isOpen);
                //Debug.Log(b);
            }
        }

        if (step2 != null)
        {
            Animator animator1 = step2.GetComponent<Animator>();
            if (animator1 != null && a==2)
            {
                //b = 1; n++;
                bool isOpen = animator1.GetBool("Back");
                
                animator1.SetBool("Show", !isOpen);
                animator1.SetBool("Back", !isOpen);
                    //Debug.Log(b);
               
            }
        }
        if (step3 != null)
        {
            Animator animator1 = step3.GetComponent<Animator>();
            if (animator1 != null && a == 3)
            {
                //b = 1; n++;
                bool isOpen = animator1.GetBool("Back");

                animator1.SetBool("Show", !isOpen);
                animator1.SetBool("Back", !isOpen);
                //Debug.Log(b);

            }
        }
        if (step4 != null)
        {
            Animator animator1 = step4.GetComponent<Animator>();
            if (animator1 != null && a == 4)
            {
                //b = 1; n++;
                bool isOpen = animator1.GetBool("Back");

                animator1.SetBool("Show", !isOpen);
                animator1.SetBool("Back", !isOpen);
                //Debug.Log(b);

            }
        }
        if (step5 != null)
        {
            Animator animator1 = step5.GetComponent<Animator>();
            if (animator1 != null && a == 5)
            {
                //b = 1; n++;
                bool isOpen = animator1.GetBool("Back");

                animator1.SetBool("Show", !isOpen);
                animator1.SetBool("Back", !isOpen);
                //Debug.Log(b);

            }
        }
        if (step6 != null)
        {
            Animator animator1 = step6.GetComponent<Animator>();
            if (animator1 != null && a == 6)
            {
                //b = 1; n++;
                bool isOpen = animator1.GetBool("Back");

                animator1.SetBool("Show", !isOpen);
                animator1.SetBool("Back", !isOpen);
                //Debug.Log(b);

            }
        }
        if (step7 != null)
        {
            Animator animator1 = step7.GetComponent<Animator>();
            if (animator1 != null && a == 7)
            {
                //b = 1; n++;
                bool isOpen = animator1.GetBool("Back");

                animator1.SetBool("Show", !isOpen);
                animator1.SetBool("Back", !isOpen);
                //Debug.Log(b);

            }
        }
        if (step8 != null)
        {
            Animator animator1 = step8.GetComponent<Animator>();
            if (animator1 != null && a == 8)
            {
                //b = 1; n++;
                bool isOpen = animator1.GetBool("Back");

                animator1.SetBool("Show", !isOpen);
                animator1.SetBool("Back", !isOpen);
                //Debug.Log(b);

            }
        }
    }
    public void Previous()
    {
        b--;
        a--;
        if (a < 0) a = 0;
        if (b < 1) b = 1;
       
        if (step1 != null)
           {
            Animator animator = step1.GetComponent<Animator>();
            if (animator != null && b == 1)
            {
                bool isOpen = animator.GetBool("Back");
                animator.SetBool("Back", !isOpen);
                animator.SetBool("Show", !isOpen);

            }
            }
        if (step2 != null)
            {
            Animator animator = step2.GetComponent<Animator>();
            if (animator != null && b == 2)
            {
                bool isOpen = animator.GetBool("Back");
                animator.SetBool("Back", !isOpen);
                animator.SetBool("Show", !isOpen);

            }
            }
        if (step3 != null)
        {
            Animator animator = step3.GetComponent<Animator>();
            if (animator != null && b == 3)
            {
                bool isOpen = animator.GetBool("Back");
                animator.SetBool("Back", !isOpen);
                animator.SetBool("Show", !isOpen);

            }
        }
        if (step4 != null)
        {
            Animator animator = step4.GetComponent<Animator>();
            if (animator != null && b == 4)
            {
                bool isOpen = animator.GetBool("Back");
                animator.SetBool("Back", !isOpen);
                animator.SetBool("Show", !isOpen);

            }
        }
        if (step5 != null)
        {
            Animator animator = step5.GetComponent<Animator>();
            if (animator != null && b == 5)
            {
                bool isOpen = animator.GetBool("Back");
                animator.SetBool("Back", !isOpen);
                animator.SetBool("Show", !isOpen);

            }
        }
        if (step6 != null)
        {
            Animator animator = step6.GetComponent<Animator>();
            if (animator != null && b == 6)
            {
                bool isOpen = animator.GetBool("Back");
                animator.SetBool("Back", !isOpen);
                animator.SetBool("Show", !isOpen);

            }
        }
        if (step7 != null)
        {
            Animator animator = step7.GetComponent<Animator>();
            if (animator != null && b == 7)
            {
                bool isOpen = animator.GetBool("Back");
                animator.SetBool("Back", !isOpen);
                animator.SetBool("Show", !isOpen);

            }
        }
        if (step8 != null)
        {
            Animator animator = step8.GetComponent<Animator>();
            if (animator != null && b == 8)
            {
                bool isOpen = animator.GetBool("Back");
                animator.SetBool("Back", !isOpen);
                animator.SetBool("Show", !isOpen);

            }
        }
    }
}

