using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartController : MonoBehaviour
{
    public Canvas canvas; // �������ϵ��˴�
    public Button startButton; // ����ť�ϵ��˴�

    void Start()
    {
        // ��ͣʱ��
        Time.timeScale = 0;

        // ��Ӱ�ť����¼�
        if (startButton != null)
        {
            startButton.onClick.AddListener(StartGame);
        }
    }

    void StartGame()
    {
        // �ָ�ʱ��
        Time.timeScale = 1;

        // ���ٻ���
        if (canvas != null)
        {
            Destroy(canvas.gameObject);
        }
    }
}
