using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPickUp : MonoBehaviour
{
   public PlayerInventory playerInventory;  // ��ҿ��
   public GameObject bullet;  // �ӵ�����

    public void Start()
    {
        playerInventory=GetComponent<PlayerInventory>();
    }
    private void OnTriggerEnter(Collider other)
    {
        // ����ҽ�����ײ��Χ�������ӵ�
        if (other.CompareTag("MainCamera"))
        {
            Debug.Log("11Player In");
           
                //playerInventory.PickupBullet();
                Destroy(gameObject);  // ����������ӵ�����

            
           
        }
    }
    
}
