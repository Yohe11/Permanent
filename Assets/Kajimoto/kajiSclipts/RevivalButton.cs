using UnityEngine;
using UnityEngine.SceneManagement;

public class RevivalButton : MonoBehaviour
{

    public void OnClickRevivalButton()
    {
        SceneManager.LoadScene("BattleTestScene");
    }

}