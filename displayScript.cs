using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var devices : WebCamDevice[] = WebCamTexture.devices;
        for (var i = 0; i < devices.length; i++)
            Debug.Log(devices[i].name);
    }
	
	// Update is called once per frame
	void Update () {
        WebCamTexture webcam = WebCamTexture("NameOfDevice");
        renderer.material.mainTexture = webcam;
        webcam.Play();

    }
}
