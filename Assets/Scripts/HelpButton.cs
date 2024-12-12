using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpButton : MonoBehaviour
{
    public Button toggleButton; // ������ť
    public GameObject imageObject; // ����Image����

    private bool isImageActive = false; // ��ʼ״̬Ϊ����

    // Start is called before the first frame update
    void Start()
    {
        if (toggleButton != null && imageObject != null)
        {
            imageObject.SetActive(isImageActive); // ȷ����ʼ״̬
            toggleButton.onClick.AddListener(ToggleImageVisibility); // �󶨵���¼�
        }
    }

    private void ToggleImageVisibility()
    {
        isImageActive = !isImageActive; // �л�״̬
        imageObject.SetActive(isImageActive); // ��ʾ������Image
    }
}
