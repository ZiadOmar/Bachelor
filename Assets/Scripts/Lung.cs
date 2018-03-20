﻿using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class Lung : MonoBehaviour, IInputClickHandler, IInputHandler
{

    public AudioSource MyAudioSource;
    public bool ChooseLungs;
    public bool Zoom;
    public int LungsTapped;


    // Use this for initialization
    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Tab))
        //{  
        //    ToggleLungs();
        //}

        //if (Input.GetKeyUp(KeyCode.Tab))
        //{
        //    StopLungs();
        //}
	
	}

    public void OnInputClicked(InputClickedEventData eventData)
    {
        // AirTap code goes here

        LungsTapped++;

        if (LungsTapped == 1)
            ToggleLungs();
        else
        {
            if (LungsTapped == 2)
                ZoomLungs();
        }
       
      
    }

    public void OnInputDown(InputEventData eventData)
    {
        

    }

    public void OnInputUp(InputEventData eventData)
    {
    }

    //void OnMouseDown()
    //{
    //    ToggleLungs();
    //}

    //void OnMouseUp()
    //{
    //    StopLungs();
    //}

    public void ZoomLungs()
    {
        Zoom = true;
    }

    public void CancelZoomLungs()
    {
        Zoom = false;
        LungsTapped = 0;
    }


    public void ToggleLungs()
    {
        //MyAudioSource.Play();
        ChooseLungs = true;
    }

   

    public void StopLungs()
    {
        //MyAudioSource.Stop();
        ChooseLungs = false;
        Zoom = false;
        LungsTapped = 0;
    }
}
