using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopParticleCtrl : MonoBehaviour
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
            PiecesExplosion[0].Pause();
            PiecesExplosion[1].Pause();
            PiecesExplosion[2].Pause();
            PiecesExplosion[3].Pause();
        }
    }
}
