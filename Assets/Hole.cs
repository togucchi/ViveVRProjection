using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : LifetimeObject {
    [SerializeField]
    float size;

    [SerializeField]
    float rate;
	// Use this for initialization
	void Start() {
        StartCoroutine(Open());
	}
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();


	}

    IEnumerator Open()
    {
        float timeTmp = 0;
        float currentSize = 0;
        while (currentSize < rate)
        {
            timeTmp += Time.deltaTime;
            currentSize = Mathf.Lerp(0, size, timeTmp * rate / size);
            transform.localScale = new Vector3(currentSize, currentSize, currentSize);
            yield return null;
        }
        
        
    }
}
