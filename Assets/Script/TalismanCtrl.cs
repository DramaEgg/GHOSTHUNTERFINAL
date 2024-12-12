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
    public ParticleSystem TalismanParticleSystem;

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
            PickUpAudio.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Ghost"))
        {
            TalismanParticleSystem.Play();
            Destroy(gameObject,1);
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TargetTalisman = linkObject.gameObject.GetComponent<Shooting>().CurrentTalisman;
        //if(isGrabbed)
        //{
        //  pauseSound();
        //}
       /* TalismanNum.text = "" + TargetTalisman;*/
    }

    //IEnumerator pauseSound()
    //{
    //        yield return new WaitForSeconds(5);
    //        PickUpAudio.SetActive(false);
    //}
}
