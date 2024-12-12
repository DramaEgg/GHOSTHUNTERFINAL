using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager Instance; // ����ģʽ��ȷ��ȫ��Ψһ

    [Header("Audio Clips")]
    public AudioClip backgroundMusic; // ��������
    public AudioClip clickSound; // �����Ч

    private AudioSource musicSource; // �������ֵ� AudioSource
    private AudioSource effectSource; // ��Ч�� AudioSource

    private float soundCooldown = 0.1f;
    private float lastPlayTime = 0;

    void Awake()
    {
        // ����ģʽ��ʼ��
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // ���ֿ糡������
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // ��ʼ�� AudioSource ���
        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.loop = true; // ��������ѭ������
        musicSource.playOnAwake = false;

        effectSource = gameObject.AddComponent<AudioSource>();
        effectSource.playOnAwake = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        // �Զ����ű�������
        PlayBackgroundMusic();
    }

    // Update is called once per frame
    void Update()
    {
        // ������������
        if (Input.anyKeyDown)
        {
            PlayClickSound();
        }

        if (Input.anyKeyDown && Time.time > lastPlayTime + soundCooldown)
        {
            PlayClickSound();
            lastPlayTime = Time.time;
        }

    }

    public void PlayBackgroundMusic()
    {
        if (backgroundMusic != null)
        {
            musicSource.clip = backgroundMusic;
            musicSource.Play();
        }
        else
        {
            Debug.LogWarning("Background music not assigned!");
        }
    }

    public void PlayClickSound()
    {
        if (clickSound != null)
        {
            effectSource.PlayOneShot(clickSound);
        }
        else
        {
            Debug.LogWarning("Click sound not assigned!");
        }
    }

}
