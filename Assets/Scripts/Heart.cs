using System;
using HoloToolkit.Unity.InputModule;
using UnityEngine;


public class Heart : MonoBehaviour, IInputClickHandler, IInputHandler
{
    
    public AudioSource MyAudioSource;
    public bool ChooseHeart;
    public bool Zoom;
    public int HeartTapped;

  
    public GameObject Lungs;
    public GameObject Brain;
    public GameObject PlaySound;

    // Use this for initialization
    void Start () {
        MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

        //if (Input.GetKeyDown("space"))
        //{
        //      ToggleHeart();
        //}

       

        //if (Input.GetKeyUp(KeyCode.Tab))
        //{
        //    StopHeart();
        //}
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {    // AirTap code goes here
        HeartTapped++;

        (Lungs.GetComponent<Lung>()).StopLungs();
        (Lungs.GetComponent<Lung>()).MyAudioSource.Stop(); 
        (Brain.GetComponent<Brain>()).StopBrain();
        (PlaySound.GetComponent<PlaySound>()).tapped = false; 

        if (HeartTapped == 1)
          ToggleHeart();


        else
        {
            if (Zoom)
                CancelZoomHeart();
            else
                ZoomHeart();
        }


    }

    public void ZoomHeart()
    {
        Zoom = true;
        HeartTapped = 1;
    }

    public void CancelZoomHeart()
    {
        Zoom = false;
        HeartTapped = 1;
    }

    public void OnInputDown(InputEventData eventData)
    {

    }

    public void OnInputUp(InputEventData eventData)
    {
    }


    //void OnMouseDown()
    //{
    //    ToggleHeart();
    //}

    //void OnMouseUp()
    //{
    //    StopHeart();
    //}


    public void ToggleHeart()
    {
       //MyAudioSource.Play();
        ChooseHeart = true;
    }

    
    public void StopHeart()
    {
        //MyAudioSource.Stop();
        ChooseHeart = false;
        Zoom = false;
        HeartTapped = 0;
    }

   



}
