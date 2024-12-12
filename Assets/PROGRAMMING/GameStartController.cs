using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartController : MonoBehaviour
{
    public Canvas canvas; // 将画布拖到此处
    public Button startButton; // 将按钮拖到此处

    void Start()
    {
        // 暂停时间
        Time.timeScale = 0;

        // 添加按钮点击事件
        if (startButton != null)
        {
            startButton.onClick.AddListener(StartGame);
        }
    }

    void StartGame()
    {
        // 恢复时间
        Time.timeScale = 1;

        // 销毁画布
        if (canvas != null)
        {
            Destroy(canvas.gameObject);
        }
    }
}
