using System.Collections;
using UnityEngine;

public class talk : MonoBehaviour
{
    IEnumerator Start()
    {
        Debug.Log("����ɂ��́I");
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        Debug.Log("�悸�́A�E�H�[�^�[�T�[�o�[��T���Đ������݂܂��傤�I");
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        Debug.Log("Let's Go!!");
    }
}