using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCamera : MonoBehaviour {
    [SerializeField]
    Transform target;

    Vector3 gazingPoint;

    public Vector3 GazingPoint
    {
        get
        {
            Vector3 point = new Vector3(0,0,0);
            if(target != null)
            {
              return target.position;
            }
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward,out hit))
            {
                point = hit.point;
            }

            return point;
        }
    }
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
     //   Debug.Log(GazingPoint);
	}
}
