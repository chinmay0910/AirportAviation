using UnityEngine;
using System.Collections;

public class TowerRadar : MonoBehaviour {
//----------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------
   
    float angle;
//----------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------
void Start()
{
    angle = 0.0f;

}
//----------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------
void Update()
{
    gameObject.transform.localEulerAngles = new Vector3 (0.0f, angle, 0.0f);   
    angle += Time.deltaTime * 93.0f;
    if(angle >= 360.0f)
        angle-= 360.0f;
}
//----------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------
}
