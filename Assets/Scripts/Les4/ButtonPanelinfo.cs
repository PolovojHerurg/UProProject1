using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonObjectPanel : MonoBehaviour
{
    [SerializeField]
    private Button GamblingButton;
    [SerializeField]
    private Transform Button;

    private void Start()
    {
        GamblingButton.onClick.AddListener(() =>
        {
            Debug.Log("let's go gambling");
        });
    }

    private void Update()
    {
        Button.DOScale(3, 1);
        Button.DOScale(1, 3);
    }
}
