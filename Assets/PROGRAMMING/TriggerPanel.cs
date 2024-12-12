using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerPanel : MonoBehaviour
{
    public GameObject panel; // ������

    public void Restart()
    {
        // ���¼��ص�ǰ����
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // �������
        Destroy(panel);
    }

    public void QuitGame()
    {
        // �˳���Ϸ
        Application.Quit();
    }
}
