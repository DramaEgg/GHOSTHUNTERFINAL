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


    public GameObject targetObject; // Ҫ����Ŀ��GameObject
    public GameObject panel; // Ҫ��ʾ��Panel

    void Start()
    {
        // ȷ��Panel����Ϸ��ʼʱ����
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // �����ײ�����Ƿ���Ŀ�����
        if (other.gameObject == targetObject)
        {
            // ��ʾPanel
            if (panel != null)
            {
                panel.SetActive(true);
            }

            // ֹͣʱ��
            Time.timeScale = 0f;
        }
    }
}
