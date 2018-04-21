using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaichiController : MonoBehaviour {

    public bool isPlay, isStop;
    public string clipName;
    
        // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isPlay)
        {
            GetComponent<Animation>().Play(clipName);
            isPlay = false;
        }
        if (isStop)
        {
            GetComponent<Animation>().Stop();
            isStop = false;
        }
	}
}
