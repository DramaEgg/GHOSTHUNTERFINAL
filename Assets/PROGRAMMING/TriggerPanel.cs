using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerPanel : MonoBehaviour
{
    public GameObject panel; // 面板对象

    public void Restart()
    {
        // 重新加载当前场景
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // 销毁面板
        Destroy(panel);
    }

    public void QuitGame()
    {
        // 退出游戏
        Application.Quit();
    }
}
