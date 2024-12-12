using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameCanvas : MonoBehaviour
{
    /* [Header("UI Elements")]
     public GameObject WinPanel; 



     private void Start()
     {

         if (WinPanel != null)
         {
             WinPanel.SetActive(false);
         }
     }

     private void OnTriggerEnter(Collider other)
     {
         Debug.Log("Collider successful"); 

         if (other.gameObject.CompareTag("Hand"))
         {
             Debug.Log("Compared player");
             if (WinPanel != null)
             {
                 Debug.Log("Edit game");
                 WinPanel.SetActive(true);
                 Time.timeScale = 0f;
             }
         }
     }*/


    /// <summary>
    /// public GameObject targetObject; // 要检测的目标GameObject
    /// </summary>
    public GameObject panel; // 要显示的Panel

    void Start()
    {
        //if (panel != null)
        //{
        //    panel.SetActive(false);
        //}
    }

    void OnTriggerEnter(Collider other)
    {
        // 检测碰撞对象是否是目标对象
        if (other.gameObject.CompareTag("Player"))
        {
            // 显示Panel
            //if (panel != null)
            //{
                
            //}
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
