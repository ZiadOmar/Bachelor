﻿using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;


public class ReturnBack : MonoBehaviour, IInputClickHandler, IInputHandler
 {
    public GameObject Heart;
    public GameObject Lungs;
    public GameObject Brain;
    public GameObject PlaySound;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnInputClicked(InputClickedEventData eventData)
    {
        // AirTap code goes here

   

        if (((Lungs.GetComponent<Lung>()).Zoom  || (Heart.GetComponent<Heart>()).Zoom  || (Brain.GetComponent<Brain>()).Zoom ))
        {   (Heart.GetComponent<Heart>()).CancelZoomHeart();
            (Lungs.GetComponent<Lung>()).CancelZoomLungs();
            (Brain.GetComponent<Brain>()).CancelZoomBrain();
   
        }
        else
        {
        
                (Heart.GetComponent<Heart>()).StopHeart();
                (Lungs.GetComponent<Lung>()).StopLungs();
                (PlaySound.GetComponent<PlaySound>()).StopSound();
                (Brain.GetComponent<Brain>()).StopBrain();
                
        }
        

    }

    public void OnInputDown(InputEventData eventData)
    {

    }

    public void OnInputUp(InputEventData eventData)
    {
    }
}
