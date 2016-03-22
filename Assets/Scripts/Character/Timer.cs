using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {


    private float timer = 0;
    
    public float r_Timer { get{ return timer;}}
    
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
	}

    void OnGUI()
    {
        string s = "Time elapsed : ";
        
        GUI.Box(new Rect(10, 10, s.Length+120 , 22), s + timer.ToString("0") +"s");
    }
}
