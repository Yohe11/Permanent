using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;


public class Mission : MonoBehaviour
{
    public GameObject textMission;
    GameObject textObj;//生成されたテキスト
    ARRaycastManager aRRaycastManager;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();//ぶつかった場所を管理する

    void Start()
    {
        aRRaycastManager = GetComponent<ARRaycastManager>();
    }
    void Update()
    {
        //キューブにタッチしたら生成
        if(Input.touchCount > 0)
        {
            if(aRRaycastManager.Raycast(Input.GetTouch(0).position, hits))
            {
                Pose hitpose = hits[0].pose;
                Ray ray = Camera.main.ScreenPointToRay(hitpose.position);
                RaycastHit hit = new RaycastHit();
                    if(Physics.Raycast(ray, out hit))
                    {
                        if(hit.transform.gameObject.CompareTag("Cube"))
                        {
                            textObj = Instantiate(textMission, hitpose.position, hitpose.rotation);
                        }
                    }
            }
        }
    }
}
