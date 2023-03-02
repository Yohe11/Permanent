using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    private float steptime; //時間経過カウンター

    private void Start()
    {
      steptime += 0.0f;  //経過時間初期化
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
