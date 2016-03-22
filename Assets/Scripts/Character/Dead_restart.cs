using UnityEngine;
using System.Collections;

public class Dead_restart : MonoBehaviour {

    private GameObject player;
    
    private int countDeath = 0;
    private Vector3 playerCurrentPos;

    public Vector3 currentCheckPoint;

    // Use this for initialization
    void Start () {
        player = gameObject;
        currentCheckPoint = player.transform.localPosition;

        //playerStartRotation = player.transform.localRotation;
    }
	
	// Update is called once per frame
	void Update () {
        // get the current position of the player
        playerCurrentPos = player.transform.localPosition;
        // if the player goes below -7 == he dies -> resest the position & rotation to the beginning
        if (playerCurrentPos.y <= -7)
        {
            //ResetPlayer();
            countDeath++;
        }

	}
    /*
    void ResetPlayer()
    {
        player.transform.localPosition = currentCheckPoint;
    }
    */
    void OnGUI()
    {
        DisplayNumberOfDeaths();
    }

    void DisplayNumberOfDeaths()
    {
        string s = "Deaths : ";
        GUI.Box(new Rect(10, 50, s.Length+70, 22), s + countDeath);
    }
}
