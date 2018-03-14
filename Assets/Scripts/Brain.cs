using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;


public class Brain : MonoBehaviour, IInputClickHandler, IInputHandler
{

    public bool ChooseBrain;

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
        ToggleBrain();
      
    }

    public void OnInputDown(InputEventData eventData)
    {

    }

    public void OnInputUp(InputEventData eventData)
    {
    }
  
    public void ToggleBrain()
    {  
        ChooseBrain = true;
    }

    public void StopBrain()
    { 
        ChooseBrain = false;
    }





}
