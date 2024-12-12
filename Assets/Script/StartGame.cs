using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject startGroup; // ����Canvas����
   

    void Start()
    {
        // ��ʼ����ʱ������Ϊ0����ͣ��Ϸ
        Time.timeScale = 0;
    }

    void Update()
    {
        // ����û��������������ʼ��Ϸ
        if (OVRInput.GetDown(OVRInput.RawButton.Any))
        {
            StartPlay();
        }
    }

    void StartPlay()
    {
        // ����Canvas���ָ�ʱ������Ϊ1
        if (startGroup != null)
        {
            startGroup.SetActive(false);
            Debug.Log("FalseStartGroup��");

        }


        Time.timeScale = 1;

        // ������Է���������Ϸ��ʼʱ���߼�
        Debug.Log("��Ϸ��ʼ�ˣ�");
    }
}
