using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;

    void OnTriggerEnter()
    {
        // disable levelMusic, levelTimer and enable levelComplete :D
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
    }
}
