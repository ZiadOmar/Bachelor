using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScripts : MonoBehaviour {
    public GameObject Heart;
    public GameObject Lungs;
    public GameObject Brain;
    public GameObject skeleton;
    public GameObject Human;
    //public AudioSource HeartSource;
    //public AudioSource LungsSource;
    public GameObject DrQuestion;
    public GameObject RespiratoryRate;
    public GameObject HeartRate;
    public GameObject BrainFunction;
    public GameObject Option1;
    public GameObject Option2;
    public GameObject Option3;
    public GameObject Option4;
    public string Question;
    public string RespRate;
    public string HrRate;
    public string BrainFunc;

    public GameObject Sound;
    public GameObject Return;
    //public bool ChooseHeart;
    //public bool ChooseLungs;


  
    public Transform startMarker;
    public Transform endMarker;
    private float startTime;
    private float journeyLength;
    public float speed;


    // Use this for initialization
    void Start() {

        DrQuestion.GetComponent<TextMesh>().text = Question;
        RespiratoryRate.GetComponent<TextMesh>().text = "Respiratory Rate: " +  RespRate;
        HeartRate.GetComponent<TextMesh>().text = "Heart Rate: " + HrRate;
        BrainFunction.GetComponent<TextMesh>().text = "Brain Function: " + BrainFunc;


        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);

        //if (ChooseHeart)  Buttons
        //{
        //Option1.GetComponentInChildren<Text>().text = "Heart1";
        //Option2.GetComponentInChildren<Text>().text = "Heart2";
        //Option3.GetComponentInChildren<Text>().text = "Heart3";
        //Option4.GetComponentInChildren<Text>().text = "Heart4";
        //}

        //if(ChooseLungs)
        //{ 
        //Option1.GetComponentInChildren<Text>().text = "Lung1";
        //Option2.GetComponentInChildren<Text>().text = "Lung2";
        //Option3.GetComponentInChildren<Text>().text = "Lung3";
        //Option4.GetComponentInChildren<Text>().text = "Lung4";
        //}

    }

    // Update is called once per frame
    void Update () {
       


        if ((Heart.GetComponent<Heart>()).ChooseHeart)
        {
            HeartEnabled();
        }
        else
        {
            if ((Lungs.GetComponent<Lung>()).ChooseLungs)
            {
                LungsEnabled();
            }
            else
            {
                if ((Brain.GetComponent<Brain>()).ChooseBrain)
                {
                    BrainEnabled();
                }
                else
                {
                    Option1.GetComponent<TextMesh>().text = "Option 1";
                    Option2.GetComponent<TextMesh>().text = "Option 2";
                    Option3.GetComponent<TextMesh>().text = "Option 3";
                    Option4.GetComponent<TextMesh>().text = "Option 4";

                    Heart.SetActive(true);
                    Lungs.SetActive(true);
                    skeleton.SetActive(true);
                    Brain.SetActive(true);
                    DrQuestion.SetActive(false);
                    Option1.SetActive(false);
                    Option2.SetActive(false);
                    Option3.SetActive(false);
                    Option4.SetActive(false);
                    RespiratoryRate.SetActive(false);
                    HeartRate.SetActive(false);
                    BrainFunction.SetActive(false);
                    Sound.SetActive(false);
                    Return.SetActive(false);
                }
            }
        }
    }

    void HeartEnabled()
    {

        Option1.GetComponent<TextMesh>().text = "Heart 1";
        Option2.GetComponent<TextMesh>().text = "Heart 2";
        Option3.GetComponent<TextMesh>().text = "Heart 3";
        Option4.GetComponent<TextMesh>().text = "Heart 4";
        Heart.SetActive(true);


        //float step = speed * Time.deltaTime;
        //Heart.transform.position = Vector3.MoveTowards(Heart.transform.position, endPosition, step);


        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        Heart.transform.position = Vector3.Lerp(Heart.transform.position, endMarker.position, fracJourney);


        Lungs.SetActive(false);
        skeleton.SetActive(false);
        Brain.SetActive(false);
        DrQuestion.SetActive(true);
        Option1.SetActive(true);
        Option2.SetActive(true);
        Option3.SetActive(true);
        Option4.SetActive(true);
        RespiratoryRate.SetActive(false);
        HeartRate.SetActive(true);
        BrainFunction.SetActive(false);
        Sound.SetActive(true);
        Return.SetActive(true);
    }

    void LungsEnabled()
    {
        Option1.GetComponent<TextMesh>().text = "Lung 1";
        Option2.GetComponent<TextMesh>().text = "Lung 2";
        Option3.GetComponent<TextMesh>().text = "Lung 3";
        Option4.GetComponent<TextMesh>().text = "Lung 4";
        Lungs.SetActive(true);
        Heart.SetActive(false);
        skeleton.SetActive(false);
        Brain.SetActive(false);


        //float step = speed * Time.deltaTime;
        //Lungs.transform.position = Vector3.MoveTowards(Lungs.transform.position, endMarker.position, step);


        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        Lungs.transform.position = Vector3.Lerp(Lungs.transform.position, endMarker.position, fracJourney);

        DrQuestion.SetActive(true);  
        Option1.SetActive(true);
        Option2.SetActive(true);
        Option3.SetActive(true);
        Option4.SetActive(true);
        RespiratoryRate.SetActive(true);
        HeartRate.SetActive(false);
        BrainFunction.SetActive(false);
        Sound.SetActive(true);
        Return.SetActive(true);

    }

    void BrainEnabled()
    {
        Option1.GetComponent<TextMesh>().text = "Brain 1";
        Option2.GetComponent<TextMesh>().text = "Brain 2";
        Option3.GetComponent<TextMesh>().text = "Brain 3";
        Option4.GetComponent<TextMesh>().text = "Brain 4";
        Lungs.SetActive(false);
        Heart.SetActive(false);
        skeleton.SetActive(false);
        Brain.SetActive(true);
        DrQuestion.SetActive(true);
        Option1.SetActive(true);
        Option2.SetActive(true);
        Option3.SetActive(true);
        Option4.SetActive(true);
        RespiratoryRate.SetActive(false);
        HeartRate.SetActive(false);
        BrainFunction.SetActive(true);
        Sound.SetActive(false);
        Return.SetActive(true);

    }
}





//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class WaterTeleport : MonoBehaviour
//{
//    public Transform StartPoint;
//    public Transform EndPoint;
//    public bool isActive;
//    public float speed;

//    private bool isTeleport;
//    private GameObject activeAgent;
//    private float startTime;
//    private float journeyLength;
//    // Use this for initialization
//    void Start()
//    {
//        journeyLength = Vector3.Distance(StartPoint.position, EndPoint.position);
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (isActive)
//        {
//            if (Input.GetKeyUp(KeyCode.T) || Input.GetKeyUp(KeyCode.Joystick1Button1))
//            {
//                startTime = Time.time;
//                if (activeAgent != null)
//                    isTeleport = true;
//            }

//            if (isTeleport)
//            {
//                teleport();
//            }
//        }



//    }

//    private void OnTriggerEnter(Collider collision)
//    {
//        activeAgent = collision.gameObject;
//    }

//    private void OnTriggerExit(Collider collision)
//    {
//        if (!isTeleport)
//        {
//            activeAgent = null;
//        }
//    }

//    void teleport()
//    {
//        if (activeAgent.transform.position.x == EndPoint.position.x && activeAgent.transform.position.z == EndPoint.position.z)
//        {
//            isTeleport = false;
//            activeAgent = null;
//        }
//        if (activeAgent != null)
//        {
//            float distCovered = (Time.time - startTime) * speed;
//            float fracJourney = distCovered / journeyLength;
//            activeAgent.transform.position = Vector3.Lerp(StartPoint.position, new Vector3(EndPoint.position.x, activeAgent.transform.position.y, EndPoint.position.z), fracJourney);
//        }
//    }
//}