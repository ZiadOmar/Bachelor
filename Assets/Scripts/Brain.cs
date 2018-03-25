using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;


public class Brain : MonoBehaviour, IInputClickHandler, IInputHandler
{

    public bool ChooseBrain;
    public bool Zoom;
    public int BrainTapped;

    public GameObject Heart;
    public GameObject Lungs;
    public GameObject PlaySound;


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

        (Heart.GetComponent<Heart>()).StopHeart();
        (Lungs.GetComponent<Lung>()).StopLungs();
        (Heart.GetComponent<Heart>()).MyAudioSource.Stop();
        (Lungs.GetComponent<Lung>()).MyAudioSource.Stop();
        (PlaySound.GetComponent<PlaySound>()).tapped = false;

        if (BrainTapped == 1)
            ToggleBrain();

        else
        {
           if(Zoom)
                CancelZoomBrain();
           else
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
        BrainTapped = 1;
    }

    public void CancelZoomBrain()
    {
        Zoom = false;
        BrainTapped = 1;
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
