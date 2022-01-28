using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            int buildIndex = SceneManager.GetActiveScene().buildIndex;
            if(SceneManager.GetSceneByBuildIndex(buildIndex+1) != null)
            {
                SceneManager.LoadScene(buildIndex+1);
            }
        }

    }
}
