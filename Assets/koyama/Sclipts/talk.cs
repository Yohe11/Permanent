using System.Collections;
using UnityEngine;

public class talk : MonoBehaviour
{
    IEnumerator Start()
    {
        Debug.Log("こんにちは！");
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        Debug.Log("先ずは、ウォーターサーバーを探して水を飲みましょう！");
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        Debug.Log("Let's Go!!");
    }
}