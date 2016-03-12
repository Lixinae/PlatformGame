using UnityEngine;
using System.Collections;

public class Patrol_platforme_backup : MonoBehaviour
{


    public GameObject platform;
    public float sizePatrol;
    public Vector3 axesToMoveOn;
    private Vector3 startPosition;
    private Vector3 endPosition;
    private float direction = 1L;
    [SerializeField]
    [Range(0f, 0.2f)]
    private float speed; // value in [0,1]

    // Use this for initialization
    void Start()
    {

        endPosition = new Vector3(0, 0, 0);
        float valueRustine = 0.2F;

        // TODO -> generify this
        startPosition = platform.transform.position;
        if (axesToMoveOn.x != 0)
        {
            if (endPosition.x < startPosition.x)
            {
                startPosition += new Vector3(-valueRustine, 0, 0);
                endPosition.x = startPosition.x - sizePatrol;
            }
            else if (endPosition.x > startPosition.x)
            {
                startPosition += new Vector3(valueRustine, 0, 0);
                endPosition.x = startPosition.x + sizePatrol;
            }
        }
        if (axesToMoveOn.y != 0)
        {
            if (endPosition.y < startPosition.y)
            {
                startPosition += new Vector3(0, -valueRustine, 0);
                endPosition.y = startPosition.y - sizePatrol;
            }
            else if (endPosition.y > startPosition.y)
            {
                startPosition += new Vector3(0, valueRustine, 0);
                endPosition.y = startPosition.y + sizePatrol;
            }
        }
        // 
        if (axesToMoveOn.z != 0)
        {
            if (endPosition.z < startPosition.z)
            {
                startPosition += new Vector3(0, 0, -valueRustine);
                endPosition.z = startPosition.z - sizePatrol;
            }
            else if (endPosition.z > startPosition.z)
            {
                startPosition += new Vector3(0, 0, valueRustine);
                endPosition.z = startPosition.z + sizePatrol;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (speed < 0)
        {
            speed = 0;
        }
        if (speed > 1)
        {
            speed = 1;
        }
        /*
        Debug.Log(" start " + startPosition);
        Debug.Log(" platform = "+platform.transform.position);
        Debug.Log(" end = " + endPosition);
        Debug.Log(" speedPlatform " + direction);
        */
        float valueRustine = 0.1F;
        // TODO -> generify this
        if (axesToMoveOn.x != 0)
        {
            //print("on axe X");
            float objPos = platform.transform.position.x;
            float endPos = endPosition.x;
            float startPos = startPosition.x;
            // if we reached any side of the patrol zone -> move to the other side


            platform.transform.position += Vector3.right * direction * speed;
            if (objPos >= endPos)
            {
                platform.transform.position += new Vector3(-valueRustine, 0, 0);
                direction = -direction;
            }
            if (objPos < startPos)
            {
                platform.transform.position += new Vector3(valueRustine, 0, 0);
                direction = -direction;
            }
        }
        if (axesToMoveOn.y != 0)
        {
            //print("on axe Y");
            float objPos = platform.transform.position.y;
            float endPos = endPosition.y;
            float startPos = startPosition.y;

            // if we reached any side of the patrol zone -> move to the other side
            platform.transform.position += Vector3.up * direction * speed;
            if (objPos >= endPos)
            {
                platform.transform.position += new Vector3(0, -valueRustine, 0);
                direction = -direction;
            }
            if (objPos < startPos)
            {
                platform.transform.position += new Vector3(0, valueRustine, 0);
                direction = -direction;
            }
        }


        if (axesToMoveOn.z != 0)
        {
            float objPos = platform.transform.position.z;
            float endPos = endPosition.z;
            float startPos = startPosition.z;
            // if we reached any side of the patrol zone -> move to the other side
            platform.transform.position += Vector3.forward * direction * speed;
            if (objPos >= endPos)
            {
                platform.transform.position += new Vector3(0, 0, -valueRustine);
                direction = -direction;
            }
            else if (objPos < startPos)
            {
                platform.transform.position += new Vector3(0, 0, valueRustine);
                direction = -direction;
            }
        }
    }

}
