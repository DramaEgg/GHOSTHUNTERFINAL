using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerTriggerClick : MonoBehaviour
{
    public Button uiButton;  // Reference to the UI Button

    void Update()
    {
        // ����Ƿ��� Trigger ��ť�����磬Oculus �������� Trigger��
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))  // ������� trigger ��ť
        {
            if (uiButton != null)
            {
                uiButton.onClick.Invoke();  // ������ť����¼�
            }
        }
    }
}
