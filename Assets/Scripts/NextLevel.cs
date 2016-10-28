using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	// respond on collisions
	void OnTriggerEnter(Collider mesh)
	{
		// only do stuff if hit by a projectile
		if (mesh.gameObject.tag == "EnterMine") {
			// call the NextLevel function in the game manager
			Application.LoadLevel ("The Mine");
		}
	}
}
