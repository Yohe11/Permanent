using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriDestroy : MonoBehaviour
{
    public float deleteTime = 3.0f;
    void Start()
    {
        Destroy(gameObject, deleteTime);
    }
}