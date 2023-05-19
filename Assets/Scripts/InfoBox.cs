using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InfoBox : MonoBehaviour
{
    public GameObject InfoBoxPopup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InfoBoxClick()
    {
        if (InfoBoxPopup.activeSelf == false)
            InfoBoxPopup.SetActive(true);
        else
            InfoBoxPopup.SetActive(false);
    }
}
