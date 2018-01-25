using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class GoalVideo : MonoBehaviour
{

    private RawImage image;
    public GameObject plane;
    private VideoPlayer videoPlayer;
    public string nextLevel;

    void Start()
    {
        videoPlayer = plane.GetComponent<VideoPlayer>();
        image = plane.GetComponent<RawImage>();
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
        videoPlayer.Stop();
        SceneManager.LoadScene(nextLevel);
    }

    void OnCollisionEnter(Collision col)
    {
        //if (other.gameObject.CompareTag("Goal"))
        if (col.collider.tag == "Goal")
        {
            image.texture = videoPlayer.texture;
            videoPlayer.Play();
            //rend.enabled = true;
            AudioSource[] allAudios = Camera.main.gameObject.GetComponents<AudioSource>();
            allAudios[0].Stop();
            StartCoroutine(WaitBeforeHide());

        }
    }

}
