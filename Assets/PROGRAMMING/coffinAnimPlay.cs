using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffinAnimPlay : MonoBehaviour
{
    public GameObject targetObject;

    private void Update()
    {
        if (targetObject.activeSelf)
        {
            Debug.Log("Active Object");
            SetCoffinAnim();
        }
    }
    void SetCoffinAnim()
    {
        GetComponent<Animator>().enabled = true;
        Debug.Log("opened");
    }

}
