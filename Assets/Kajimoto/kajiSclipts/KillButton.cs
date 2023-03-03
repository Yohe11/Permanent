using UnityEngine;
using UnityEngine.SceneManagement;

public class KillButton : MonoBehaviour
{

    public void OnClickKillButton()
    {
        SceneManager.LoadScene("Result Scenes");
    }

}
