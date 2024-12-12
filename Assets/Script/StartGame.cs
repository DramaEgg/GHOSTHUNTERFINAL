using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject startGroup; // 拖入Canvas对象
   

    void Start()
    {
        // 初始设置时间缩放为0，暂停游戏
        Time.timeScale = 0;
    }

    void Update()
    {
        // 如果用户按下任意键，开始游戏
        if (OVRInput.GetDown(OVRInput.RawButton.Any))
        {
            StartPlay();
        }
    }

    void StartPlay()
    {
        // 隐藏Canvas并恢复时间缩放为1
        if (startGroup != null)
        {
            startGroup.SetActive(false);
            Debug.Log("FalseStartGroup！");

        }


        Time.timeScale = 1;

        // 这里可以放置其他游戏开始时的逻辑
        Debug.Log("游戏开始了！");
    }
}
