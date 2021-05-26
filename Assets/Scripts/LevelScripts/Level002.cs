﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level002 : MonoBehaviour
{
    public GameObject fadeIn;
    void Start()
    {
        RedirectToLevel.redirectToLevel = 5;
        // Level003 has scene equals 6
        RedirectToLevel.nextLevel = 6;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
