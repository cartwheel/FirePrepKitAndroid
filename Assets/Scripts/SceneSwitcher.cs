using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{

    public void GoToSmokeDetectorTestScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SmokeDetectorTestScene");
    }

}
