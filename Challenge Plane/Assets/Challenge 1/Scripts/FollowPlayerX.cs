using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public Transform plane;
    private Vector3 offset;
    
    private void Start()
    {
        offset = transform.position - plane.position;
    }
    void FixedUpdate()
    {
        transform.position = plane.position + offset;
    }
}
