using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleporting : MonoBehaviour
{
    public GameObject CurrentRoom;
    public GameObject Destination;
    private GameObject Cam;
    //Attach an Image you want to fade in the GameObject's Inspector
    public Image m_Image;
    //Use this to tell if the toggle returns true or false
    bool m_Fading;
    // Start is called before the first frame update
    void Start()
    {
        Cam = GameObject.Find("XR Origin");
    }

    // Update is called once per frame
    void Update()
    {
        /*//If the toggle returns true, fade in the Image
        if (m_Fading == true)
        {
            //Fully fade in Image (1) with the duration of 2
            m_Image.CrossFadeAlpha(1, 2.0f, false);
        }
        //If the toggle is false, fade out to nothing (0) the Image with a duration of 2
        if (m_Fading == false)
        {
            m_Image.CrossFadeAlpha(0, 2.0f, false);
        }*/
    }
    public void Teleport()
    {
        //m_Image.CrossFadeAlpha(0, 2.0f, false);
        CurrentRoom.SetActive(false);
        Destination.SetActive(true);
        Cam.gameObject.transform.position = Destination.transform.position;
        //m_Image.CrossFadeAlpha(1, 2.0f, false);
    }
}

