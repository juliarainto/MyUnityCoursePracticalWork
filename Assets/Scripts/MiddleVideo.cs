using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MiddleVideo : MonoBehaviour {

	private RawImage image;
	public GameObject plane;
	private VideoPlayer videoPlayer;

	void Start() {
		videoPlayer = plane.GetComponent<VideoPlayer> ();
		image = plane.GetComponent <RawImage>();
		//rend = plane.GetComponent<Renderer>();
		videoPlayer.Prepare();
		Application.runInBackground = true;
	}

	IEnumerator WaitBeforeHide()
	{
		while (videoPlayer.isPlaying)
		{
			//Debug.Log ("playing");
			yield return null;
		}
		//rend.enabled = false;
		videoPlayer.Stop ();
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Middle"))
		{
			image.texture = videoPlayer.texture;
			videoPlayer.Play ();
			//rend.enabled = true;
			StartCoroutine(WaitBeforeHide());
		}
	}

}
