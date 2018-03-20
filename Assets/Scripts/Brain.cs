using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;


public class Brain : MonoBehaviour, IInputClickHandler, IInputHandler
{

    public bool ChooseBrain;
    public bool Zoom;
    public int BrainTapped;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        // AirTap code goes here

        BrainTapped++;

        if (BrainTapped == 1)
            ToggleBrain();
        else
        {
            if (BrainTapped == 2)
                ZoomBrain();
        }
       
      
    }

    public void OnInputDown(InputEventData eventData)
    {

    }

    public void OnInputUp(InputEventData eventData)
    {
    }


    public void ZoomBrain()
    {
        Zoom = true;
    }

    public void CancelZoomBrain()
    {
        Zoom = false;
        BrainTapped = 0;
    }
    public void ToggleBrain()
    {  
        ChooseBrain = true;
    }

    public void StopBrain()
    { 
        ChooseBrain = false;
        Zoom = false;
        BrainTapped = 0;
    }





}
