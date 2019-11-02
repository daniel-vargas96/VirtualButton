using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


    public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject sphereGo, cubeGo;
    VirtualButtonBehaviour vrb;
    // Use this for initialization
    void Start()
    {
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterEventHandler(this);
        cubeGo.SetActive(true);
        sphereGo.SetActive(false);
        Debug.Log("Command reached in the expected position");
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeGo.SetActive(false);
        sphereGo.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeGo.SetActive(true);
        sphereGo.SetActive(false);
    }
}
 
