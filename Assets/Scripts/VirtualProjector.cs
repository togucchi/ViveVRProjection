using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualProjector : MonoBehaviour {
    [SerializeField]
    VirtualCamera vcam;

    private void Update()
    {
        if(vcam != null)
        {
            transform.LookAt(vcam.GazingPoint);
        }
    }
}
