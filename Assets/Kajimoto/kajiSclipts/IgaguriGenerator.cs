using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class IgaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    
    void Update()
    {
          if (Input.GetMouseButtonDown(0))
          {
                GameObject igaguri =
                    Instantiate(igaguriPrefab);

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 worldDir = ray.direction;
                igaguri.GetComponent<IgaguriController>().Shoot(
                    worldDir.normalized * 1250);
          }
    }
}
