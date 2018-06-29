using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifetimeObject : MonoBehaviour {
    [SerializeField]
    float killTime = 10f;

    float timeTmp = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        timeTmp += Time.deltaTime;

        if(timeTmp >= killTime)
        {
            Destroy(this.gameObject);
        }
	}
}
