using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MRTK;
using Microsoft.MixedReality.Toolkit.Input;

public class AlarmLamp : MonoBehaviour
{
    private Light light;
    public Material AlarmColor;
    public Material NeytralColor;
    public GameObject lamp;
    public GameObject target;
    int flag = 1;
    // Update is called once per frame
    public void alarm()
    {
        if (flag == 1) {
            lamp.GetComponent<Renderer>().material = AlarmColor;
            flag = 0;
        }
        else
        {
            lamp.GetComponent<Renderer>().material = NeytralColor;
            flag = 1;
        }
        
    }
}
