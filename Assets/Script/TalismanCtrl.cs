using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TalismanCtrl : MonoBehaviour
{
    [Header("Reference")]
    public bool isGrabbed = false;
    public GameObject linkObject;
    public int TargetTalisman;

    [Header("UIIcon")]
    public GameObject[] TalismanUI;
    public GameObject[] GhostUI;
    //public TextMeshProUGUI TalismanNum;

    [Header("PickUpAudio")]
    public GameObject PickUpAudio;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hand"))
        {
            Debug.Log("Grabbed");
            isGrabbed = true;
            linkObject.gameObject.GetComponent<Shooting>().CurrentTalisman ++;
            Destroy(gameObject,10);

            PickUpAudio.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TargetTalisman = linkObject.gameObject.GetComponent<Shooting>().CurrentTalisman;
       /* TalismanNum.text = "" + TargetTalisman;*/
    }
}
