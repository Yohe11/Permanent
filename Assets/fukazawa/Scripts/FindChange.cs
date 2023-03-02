using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindChange : MonoBehaviour
{
    public void ChangeFindMode()
    {
        SceneManager.LoadScene("FindingMode");
    }
}
