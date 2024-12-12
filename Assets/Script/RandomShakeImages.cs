using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomShakeImages : MonoBehaviour
{
    public List<Image> imagesToShake; // ����Ҫ������Image��������
    public float shakeDuration = 0.5f; // ÿ�ζ����ĳ���ʱ��
    public float shakeIntensity = 10f; // ����ǿ��
    public float shakeInterval = 1f; // ÿ�ζ����ļ��ʱ��

    private List<Vector3> originalPositions = new List<Vector3>();

    void Start()
    {
        // ����ÿ��Image��ԭʼλ��
        foreach (var image in imagesToShake)
        {
            originalPositions.Add(image.rectTransform.localPosition);
        }

        // ��ʼ�������Э��
        StartCoroutine(RandomShake());
    }

    IEnumerator RandomShake()
    {
        while (true)
        {
            // ���ѡ��һ��Image���ж���
            int randomIndex = Random.Range(0, imagesToShake.Count);
            StartCoroutine(ShakeImage(imagesToShake[randomIndex], randomIndex));

            // �ȴ�һ��ʱ����ٴ�����һ�ζ���
            yield return new WaitForSeconds(shakeInterval);
        }
    }

    IEnumerator ShakeImage(Image image, int index)
    {
        RectTransform rectTransform = image.rectTransform;
        Vector3 originalPosition = originalPositions[index];

        float elapsedTime = 0f;

        while (elapsedTime < shakeDuration)
        {
            // �������һ��ƫ����
            float offsetX = Random.Range(-shakeIntensity, shakeIntensity);
            float offsetY = Random.Range(-shakeIntensity, shakeIntensity);

            // Ӧ��ƫ����
            rectTransform.localPosition = originalPosition + new Vector3(offsetX, offsetY, 0);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // �ָ���ԭʼλ��
        rectTransform.localPosition = originalPosition;
    }
}
