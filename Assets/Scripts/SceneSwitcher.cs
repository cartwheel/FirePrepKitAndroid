using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{

    public void GoToSmokeDetectorTestScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SmokeDetectorTestScene");
    }

    public void GoTo3dScanHome()
    {
        Debug.Log("Going to 3d scan of home");
    }

    public void GoToReviewPlan()
    {
        Debug.Log("Going to review of plan");
    }

}
