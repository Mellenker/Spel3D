using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightAnimations : MonoBehaviour
{

    [SerializeField] private Animator flashlightAnimator;

    [SerializeField] private PlayerControls controls;

    private KeyCode sprintKey;

    private void start()
    {
        sprintKey = controls.getSprintKey();
    }

    private void Update()
    {
        if (Input.GetKey(sprintKey) && (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f))
        {
            flashlightAnimator.ResetTrigger("walk");
            flashlightAnimator.SetTrigger("sprint");
        }

        else
        {
            flashlightAnimator.ResetTrigger("sprint");
            flashlightAnimator.SetTrigger("walk");
        }

    }

}
