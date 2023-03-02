using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    private float time;
    private float vecX;
    private float vecY;
    private float vecZ;

    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            vecX = Random.Range(-4.0f, 4.0f);
            vecY = Random.Range(-4.0f, 4.0f);
            this.transform.position = new Vector3(vecX, vecY, 10);
            time = 1.0f;
        }
    }
}