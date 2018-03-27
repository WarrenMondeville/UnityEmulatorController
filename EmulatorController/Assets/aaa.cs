using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaa {

    public aaa() {
        Debug.Log("gouzao");
    }
    public delegate void OnAccelEvent(int accelEvent);
    public event OnAccelEvent accelEventListeners
    {
        add
        {
            Debug.Log("Add");
        }

        remove
        {
            Debug.Log("Remove");
        }
    }

}
