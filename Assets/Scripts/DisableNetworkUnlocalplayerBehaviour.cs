using UnityEngine;
using UnityEngine.Networking;

	public class DisableNetworkUnlocalplayerBehaviour : NetworkBehaviour {

	[SerializeField]
	//Behaviour[] behaviours;

	public Behaviour cntrlScript;
	public Camera camera;


	// Use this for initialization
	void Start () {
		if (! isLocalPlayer) {

				cntrlScript.enabled = false;

				camera.enabled=false;

		}
	}

	void OnApplicationFocus(bool focusStatus){
		if(isLocalPlayer)
		{
			cntrlScript.enabled=focusStatus;

			camera.enabled=true;
		}
	}
}

