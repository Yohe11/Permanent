using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    private float steptime; //���Ԍo�߃J�E���^�[

    private void Start()
    {
      steptime += 0.0f;  //�o�ߎ��ԏ�����
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Doragon")
        {
            steptime += Time.deltaTime;

            if(steptime <= 3.0f)
            SceneManager.LoadScene("RevivalOrKill");
        }
    }
}
