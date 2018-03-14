using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;


public class PlaySound : MonoBehaviour, IInputClickHandler, IInputHandler
 {

    AudioSource MyAudioSource;
    public GameObject Heart;
    public GameObject Lungs;

    // Use this for initialization
    void Start()
    {
        //MyAudioSource = GetComponent<AudioSource>();
        if ((Heart.GetComponent<Heart>()).ChooseHeart)
        {
            MyAudioSource = (Heart.GetComponent<Heart>()).MyAudioSource;
        }
        else
        {
            if ((Lungs.GetComponent<Lung>()).ChooseLungs)
            {
                MyAudioSource = (Lungs.GetComponent<Lung>()).MyAudioSource;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        if ((Heart.GetComponent<Heart>()).ChooseHeart)
        {
            MyAudioSource= (Heart.GetComponent<Heart>()).MyAudioSource;
        }
        else
        {
            if ((Lungs.GetComponent<Lung>()).ChooseLungs)
            {
                MyAudioSource = (Lungs.GetComponent<Lung>()).MyAudioSource;
            }
        }

        //if (Input.GetKeyUp(KeyCode.Tab))
        //{
        //    StopSound();
        //}
    }


    public void OnInputClicked(InputClickedEventData eventData)
    {
        // AirTap code goes here
        ToggleSound();
    }

    public void OnInputDown(InputEventData eventData)
    {

    }

    public void OnInputUp(InputEventData eventData)
    {
    }
    //void OnMouseDown()
    //{
    //    ToggleSound();
    //}

    public void ToggleSound()
    {
        MyAudioSource.Play();
        
    }
    
     public void StopSound()
    {
        MyAudioSource.Stop();
    }

}
