using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeCam : MonoBehaviour
{
    // Update is called once per frame
     private RuntimePlatform platform = Application.platform;
 
    void Update()
    {
        if(platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer)
        {
                if(Input.touchCount > 0) {
                    if(Input.GetTouch(0).phase == TouchPhase.Began){
                        checkTouch(Input.GetTouch(0).position);
                    }
                }
            }
            else if(platform == RuntimePlatform.WindowsEditor){
                if(Input.GetMouseButtonDown(0)) {
                    checkTouch(Input.mousePosition);
                }
            }
    }

    void checkTouch(Vector3 pos)
    {
        Debug.Log(pos.x);
        Debug.Log(pos.y);
    }
}
