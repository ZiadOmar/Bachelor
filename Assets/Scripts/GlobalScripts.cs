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

    public Material lungsMaterial;
    public Transform startMarker;
    public Transform HeartstartMarker;
    public Transform LungsstartMarker;
    public Transform BrainstartMarker;
    public Transform endMarker;
    private Vector3 lungsInitialScale;
    private Vector3 BrainInitialScale;
    private Vector3 HeartInitialScale;
    public Quaternion lungsInitialRotate;
    public Quaternion BrainInitialRotate;
    public Quaternion HeartInitialRotate;
    public Vector3 gazeDirection;


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


        lungsInitialScale = Lungs.transform.localScale;
        HeartInitialScale = Heart.transform.localScale;
        BrainInitialScale = Brain.transform.localScale;

        //lungsInitialRotate = Lungs.transform.rotation;
        //HeartInitialRotate = Heart.transform.rotation;
        //BrainInitialRotate = Brain.transform.rotation;

        lungsMaterial.color = new Color32(139, 49, 49, 128);

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


        gazeDirection = Camera.main.transform.forward;
        //Heart.transform.rotation = Quaternion.LookRotation(gazeDirection);
        //Lungs.transform.rotation = Quaternion.LookRotation(gazeDirection); 
        //Brain.transform.rotation = Quaternion.LookRotation(gazeDirection);

        //Heart.transform.LookAt(Heart.transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);

        //Lungs.transform.LookAt(Camera.main.transform);

        if ((Heart.GetComponent<Heart>()).ChooseHeart)
        {   //animate
            HeartEnabled();

            if ((Heart.GetComponent<Heart>()).Zoom)
            {
                //HeartCross-section.SetActive(true);
                Heart.transform.Rotate(Vector3.up);    
            }
        }
        else
        {
            if ((Lungs.GetComponent<Lung>()).ChooseLungs)
            {   //animate
                LungsEnabled();
              

                if ((Lungs.GetComponent<Lung>()).Zoom)
                {
                    //LungsCross-section.SetActive(true);
                    Lungs.transform.Rotate(Vector3.up);
                }
            }
            else
            {
                if ((Brain.GetComponent<Brain>()).ChooseBrain)
                {   //animate
                    BrainEnabled();

                    if ((Brain.GetComponent<Brain>()).Zoom)
                    {
                        //BrainCross-section.SetActive(true);
                        Brain.transform.Rotate(Vector3.up);
                    }
                }
                else
                {
                    Option1.GetComponent<TextMesh>().text = "Option 1";
                    Option2.GetComponent<TextMesh>().text = "Option 2";
                    Option3.GetComponent<TextMesh>().text = "Option 3";
                    Option4.GetComponent<TextMesh>().text = "Option 4";

                    Lungs.transform.localScale = lungsInitialScale;
                    Heart.transform.localScale = HeartInitialScale;
                    Brain.transform.localScale = BrainInitialScale;

                    //Lungs.transform.rotation = lungsInitialRotate;
                    //Heart.transform.rotation = HeartInitialRotate;
                    //Brain.transform.rotation = BrainInitialRotate;

                  
                    lungsMaterial.color = new Color32(139, 49, 49, 128);


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
        HeartInitialRotate = Quaternion.LookRotation(gazeDirection);


        Option1.GetComponent<TextMesh>().text = "Cardiovascular disease";
        Option2.GetComponent<TextMesh>().text = "Angina pectoris";
        Option3.GetComponent<TextMesh>().text = "Tachycardia";
        Option4.GetComponent<TextMesh>().text = "Cardiomyopathy";



        //float step = speed * Time.deltaTime;
        //Heart.transform.position = Vector3.MoveTowards(Heart.transform.position, endPosition, step);
       

        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        Heart.transform.position = Vector3.Lerp(Heart.transform.position, endMarker.position, fracJourney);

        Heart.transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);

        Heart.SetActive(true);
        Lungs.SetActive(true);
        skeleton.SetActive(true);
        Brain.SetActive(true);
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

        //Lungs.transform.position = lungsInitial;
        //Brain.transform.position = BrainInitial;
        
        Lungs.transform.position = Vector3.Lerp(Lungs.transform.position, LungsstartMarker.position, fracJourney);
        Brain.transform.position = Vector3.Lerp(Brain.transform.position, BrainstartMarker.position, fracJourney);

        Lungs.transform.localScale = lungsInitialScale;
        Brain.transform.localScale = BrainInitialScale;


        Lungs.transform.rotation = lungsInitialRotate;
        Brain.transform.rotation = BrainInitialRotate;
  

        lungsMaterial.color = new Color32(139, 49, 49, 128);
    }

    void LungsEnabled()
    {
        lungsInitialRotate = Quaternion.LookRotation(gazeDirection); 

        Option1.GetComponent<TextMesh>().text = "Tuberculosis";
        Option2.GetComponent<TextMesh>().text = "Pulmonary fibrosis";
        Option3.GetComponent<TextMesh>().text = "Pneumonia";
        Option4.GetComponent<TextMesh>().text = "Shortness of breath";

        //float step = speed * Time.deltaTime;
        //Lungs.transform.position = Vector3.MoveTowards(Lungs.transform.position, endMarker.position, step);

        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        Lungs.transform.position = Vector3.Lerp(Lungs.transform.position, endMarker.position, fracJourney);

        Lungs.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);

        lungsMaterial.color = new Color32(139, 49, 49, 255);


        Lungs.SetActive(true);
        Heart.SetActive(true);
        skeleton.SetActive(true);
        Brain.SetActive(true);
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


        //Heart.transform.position = HeartstartMarker.position;
        //Brain.transform.position = BrainstartMarker.position;
        Heart.transform.position = Vector3.Lerp(Heart.transform.position, HeartstartMarker.position, fracJourney);
        Brain.transform.position = Vector3.Lerp(Brain.transform.position, BrainstartMarker.position, fracJourney);

      
        Heart.transform.localScale = HeartInitialScale;
        Brain.transform.localScale = BrainInitialScale;

        Heart.transform.rotation = HeartInitialRotate;
        Brain.transform.rotation = BrainInitialRotate;

    
    }

    void BrainEnabled()
    {
        BrainInitialRotate = Quaternion.LookRotation(gazeDirection);

        Option1.GetComponent<TextMesh>().text = "Encephalopathy";
        Option2.GetComponent<TextMesh>().text = "Neurological disorder";
        Option3.GetComponent<TextMesh>().text = "Multiple sclerosis";
        Option4.GetComponent<TextMesh>().text = "Epileptic seizure";

        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        Brain.transform.position = Vector3.Lerp(Brain.transform.position, endMarker.position, fracJourney);


        Brain.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);


        Lungs.SetActive(true);
        Heart.SetActive(true);
        skeleton.SetActive(true);
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

        //Lungs.transform.position = lungsInitial;
        //Heart.transform.position = HeartInitial;

        Lungs.transform.position = Vector3.Lerp(Lungs.transform.position, LungsstartMarker.position, fracJourney);
        Heart.transform.position = Vector3.Lerp(Heart.transform.position, HeartstartMarker.position, fracJourney);

        Lungs.transform.localScale = lungsInitialScale;
        Heart.transform.localScale = HeartInitialScale;

        Lungs.transform.rotation = lungsInitialRotate;
        Heart.transform.rotation = HeartInitialRotate;

        lungsMaterial.color = new Color32(139, 49, 49, 128);

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