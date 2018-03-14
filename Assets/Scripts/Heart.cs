using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;


public class Heart : MonoBehaviour, IInputClickHandler, IInputHandler
{
    
    public AudioSource MyAudioSource;
    public bool ChooseHeart;

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
    {
        // AirTap code goes here
        ToggleHeart();
        //print("SHiiii222");
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
    public void ToggleHeart()
    {
       //MyAudioSource.Play();
        ChooseHeart = true;
    }

    //void OnMouseUp()
    //{
    //    StopHeart();
    //}

    public void StopHeart()
    {
        //MyAudioSource.Stop();
        ChooseHeart = false;
       
    }

   



}
