﻿using UnityEngine;
using System.Collections;

public class Falling_Platform : MonoBehaviour {

    [SerializeField]private Transform startPosition;

    [SerializeField]private float delay = 4;

    private bool fall = false;

    public void OnTriggerEnter(Collider col)
    {
        if (col.name.Equals("FPSController"))
        {
            //Debug.Log("Trigger enter");
            StartCoroutine(waitingToFall());
        }
        
    }

    private void setGravity()
    {
        if (fall && this.transform.parent.GetComponent<Rigidbody>() != null)
        {
            //Debug.Log("Falling");
            this.transform.parent.GetComponent<Rigidbody>().isKinematic = false;
            fall = false;
        }
    }

    void Update()
    {
        setGravity();
        //print("parent pos " + this.transform.parent.position.y + " startPos " + startPosition.position.y);
        if(this.transform.parent.position.y <= startPosition.position.y - 10)
        {
            resetPlatform();
        }
    }
    

    private void resetPlatform()
    {
        //Debug.Log("ResetPlatform");
        fall = false;
        this.transform.parent.position = startPosition.position;
        this.transform.parent.rotation = startPosition.rotation;
        if (this.transform.parent.GetComponent<Rigidbody>() != null)
        {
            this.transform.parent.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            this.transform.parent.GetComponent<Rigidbody>().isKinematic = true;
        }
            
    }

    public void OnDrawGizmos()
    {
        if (startPosition != null)
            Debug.DrawLine(this.transform.position, startPosition.transform.position, Color.blue);
    }

    public IEnumerator waitingToFall()
    {
        fall = false;
        yield return new WaitForSeconds(delay);
        fall = true;
    }
}
