using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    aaa a; 

    private void Awake()
    {
        a = new aaa(); 
    }
    void Start () {
       
        a.accelEventListeners += abc;

	}

    private void OnDestroy()
    {

        a.accelEventListeners -= abc;
    }
    // Update is called once per frame
    void abc (int i) {
		
	}
}
