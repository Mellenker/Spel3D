using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRotation : MonoBehaviour
{

    [SerializeField] private Transform rotation;

    void Update()
    {
        transform.rotation = rotation.rotation;
    }
}

