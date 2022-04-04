using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FaderForMenu : MonoBehaviour
{
    
    

    public bool inGame;


    private bool isRestart;

    private float alpha; // ������������
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        if (inGame)
        {
            alpha = 1;
        }
        else
            alpha = alpha;
    }

    public IEnumerator Fade(bool toVisible)
    {
        float step = toVisible ? 0.1f : -0.1f;
        int endValue = toVisible ? 1 : 0;

        while (alpha != endValue) // ���� ���� �� ������ ������� ���
        {
            alpha += step; // ���� ��� ���� ����
            canvasGroup.alpha = alpha;
            // �� ������ �� ���������� ���� ������ �� �����.
            if (alpha < 0) // ������������
            {
                alpha = 0;
            }
            else if (alpha > 1)
            {
                alpha = 1;
            }

            yield return new WaitForSeconds(0.05f);
        }
    }

   
}
