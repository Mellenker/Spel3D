using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{

    [SerializeField] private Animator playerModelAnimator;

    [SerializeField] private PlayerControls controls;
    // private KeyCode jumpKey;
    private KeyCode sprintKey;
   
    private void Start()
    {
        // jumpKey = controls.getJumpKey();
        sprintKey = controls.getSprintKey();
    }

    private void Update()
    {

        if (Input.GetAxis("Horizontal") > .1f || Input.GetAxis("Vertical") > .1f)
        {

            if (Input.GetKey(sprintKey))
            {
                // Sprint kod här
            }
            else
            {
                playerModelAnimator.ResetTrigger("idle");
                playerModelAnimator.SetTrigger("walk");
            }

        }

        else
        {
            playerModelAnimator.ResetTrigger("walk");
            playerModelAnimator.SetTrigger("idle");
        }

    }
}
