using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_InputAnim : MonoBehaviour
{
    [SerializeField] Animator animator;
    private bool isSit = false;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            isSit = !isSit;
            animator.SetBool("Sit", isSit);
        }
    }
}
