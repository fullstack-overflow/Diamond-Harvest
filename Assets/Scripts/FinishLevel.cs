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
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;

    void OnTriggerEnter()
    {
        // disable levelMusic, levelTimer and enable levelComplete :D
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(1f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(1f);
    }
}
