using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceExlosionCtrl : MonoBehaviour
{
    public GameObject EnemyDeadBody;
    public ParticleSystem[] PiecesExplosion;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyDeadBody.GetComponent<Enemy>().isDead)
        {
            PiecesExplosion[0].Play();
            PiecesExplosion[1].Play();
            PiecesExplosion[2].Play();
            PiecesExplosion[3].Play();
        }
    }
}
