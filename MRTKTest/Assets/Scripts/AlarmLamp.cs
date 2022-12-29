using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MRTK;
using Microsoft.MixedReality.Toolkit.Input;

public class AlarmLamp : MonoBehaviour
{
    public Light light;
    public Material AlarmColor;
    public Material NeytralColor;
    public GameObject lamp;
    // Update is called once per frame
    public void alarm()
    {
        lamp.GetComponent<MeshRenderer>().material = AlarmColor;
        light.range = 1;
    }
    public void alarm_Off()
    {
        lamp.GetComponent<MeshRenderer>().material = NeytralColor;
        light.range = 0;
    }
}
