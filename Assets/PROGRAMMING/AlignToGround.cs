using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR;

public class AlignToGround : MonoBehaviour
{

    public float groundY = 0f;  // �������� y λ��

    void Start()
    {
        // ��ȡ��ǰ�����ʵ�ʸ߶�
        var cameraHeight = Camera.main.transform.position.y;

        // ���� XR Origin �ĸ߶�
        var origin = GetComponent<XROrigin>();
        if (origin != null)
        {
            origin.transform.position = new Vector3(
                origin.transform.position.x,
                groundY - cameraHeight,
                origin.transform.position.z
            );
        }


    }
}
