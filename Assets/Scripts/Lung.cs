using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class Lung : MonoBehaviour, IInputClickHandler, IInputHandler
{

    public AudioSource MyAudioSource;
    public bool ChooseLungs;
    public bool Zoom;
    public int LungsTapped;

    public GameObject Heart;
    public GameObject Brain;
    public GameObject PlaySound;


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

        (Heart.GetComponent<Heart>()).StopHeart();
        (Brain.GetComponent<Brain>()).StopBrain();
        (Heart.GetComponent<Heart>()).MyAudioSource.Stop();
        (PlaySound.GetComponent<PlaySound>()).tapped = false;


        if (LungsTapped == 1)
          ToggleLungs();

        else
        {
            if (Zoom)
                CancelZoomLungs();
            else
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
        LungsTapped = 1;
    }

    public void CancelZoomLungs()
    {
        Zoom = false;
        LungsTapped = 1;
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
