using UnityEngine;
using System.Collections;

public class ResetPosition : MonoBehaviour
{
	[SerializeField]private Transform startPosition;

	private Character_data char_dat;

	// Update is called once per frame
	void Update ()
	{
		//char_dat = player.GetComponent<Character_data> ();
		GameObject player = GameObject.Find ("FPlayerController");
		if (player.GetComponent<Character_data> ().isdead ()) {
			resetPosition ();
		}
	}

	private void resetPosition ()
	{
		Vector3 posTemp = new Vector3 (startPosition.position.x - 4, startPosition.position.y, startPosition.position.z);
		this.transform.GetChild (0).transform.position = posTemp;
		var balancier = this.transform.GetChild (0);
		balancier.GetComponent<Rigidbody> ().isKinematic = true;
		balancier.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
		balancier.GetComponent<Rigidbody> ().rotation = startPosition.rotation;
		balancier.GetComponent<Renderer> ().enabled = false;

	}
}
