using UnityEngine;
using System.Collections;

public class StayOnMovingPlatform : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.name.Equals("FPSController"))
        {
            //Debug.Log("Attach");
            col.transform.parent = gameObject.transform;
        }        
    }

    void OnTriggerExit(Collider col)
    {
        
        if (col.name.Equals("FPSController")) { 
            //Debug.Log("exit Trigger");
            col.transform.parent = null;
        }
    }
}
