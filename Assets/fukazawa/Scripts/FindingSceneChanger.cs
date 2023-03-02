using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindingSceneChanger : MonoBehaviour
{
    public void ChangeSceneFindingMode()
    {
        SceneManager.LoadScene("FingingMode");
    }
}
