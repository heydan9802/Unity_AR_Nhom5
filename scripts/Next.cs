using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public GameObject obj;

    public void ShowHideMenu()
    {
        if (obj != null)
        {
            Animator animator = obj.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Show");
                animator.SetBool("Show", !isOpen);
                animator.SetBool("Back", !isOpen);
            }
        }
    }
}
