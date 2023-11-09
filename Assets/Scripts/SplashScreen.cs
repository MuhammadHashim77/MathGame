using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    [SerializeField] private GameObject splashScreen;

    [SerializeField] private GameObject menuScreen;

    private void Awake()
    {
        splashScreen.SetActive(true);
        menuScreen.SetActive(false);
    }

    void Start()
    {
        StartCoroutine(DisableSplashScreen());
    }

    IEnumerator DisableSplashScreen()
    {
        yield return new WaitForSeconds(2);

        splashScreen.SetActive(false);
        menuScreen.SetActive(true);
    }
}
