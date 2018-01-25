using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour {
    void OnTriggerEnter (Collider other)
    {
        other.gameObject.SetActive(false);
        StartCoroutine(WaitBeforeReload());
    }
    IEnumerator WaitBeforeReload()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
