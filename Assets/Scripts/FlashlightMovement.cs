using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightMovement : MonoBehaviour
{

    [SerializeField] private Animator flashlightAnim;
    [SerializeField] private KeyCode sprintKey = KeyCode.LeftShift;

    private void Update()
    {
        if (Input.GetKey(sprintKey) && (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f))
        {
            flashlightAnim.ResetTrigger("walk");
            flashlightAnim.SetTrigger("sprint");
        }

        else
        {
            flashlightAnim.ResetTrigger("sprint");
            flashlightAnim.SetTrigger("walk");
        }

    }

}
