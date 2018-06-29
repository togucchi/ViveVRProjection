using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHole : MonoBehaviour {
    [SerializeField]
    GameObject hole;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);
        if(device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            RaycastHit hit;

            if(Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if(hit.collider.tag == "wall")
                {
                    GameObject tmp = Instantiate(hole, hit.point, Quaternion.identity);
                    tmp.transform.parent = hit.collider.gameObject.transform;
                    tmp.transform.localRotation = Quaternion.Euler(new Vector3(-90, 0, 0));
                }
            }
        }
	}
}
