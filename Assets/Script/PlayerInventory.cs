using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int bulletCount = 0;  // ��ҵ�ǰӵ�е��ӵ���

    public void PickupBullet()
    {
        bulletCount++;
        Debug.Log("�������ӵ�����ǰӵ���ӵ���: " + bulletCount);
    }

    public bool CanShoot()
    {
        return bulletCount > 0;
    }

    public void UseBullet()
    {
        if (bulletCount > 0)
        {
            bulletCount--;
            Debug.Log("�����ӵ�����ǰʣ���ӵ���: " + bulletCount);
        }
    }

}
