using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class Lung : MonoBehaviour, IInputClickHandler, IInputHandler
{

    public AudioSource MyAudioSource;
    public bool ChooseLungs;


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
        ToggleLungs();
        //print("Hiiii222");
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

    public void ToggleLungs()
    {
        //MyAudioSource.Play();
        ChooseLungs = true;
    }

    //void OnMouseUp()
    //{
    //    StopLungs();
    //}

    public void StopLungs()
    {
        //MyAudioSource.Stop();
        ChooseLungs = false;
    }
}
