using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Door1 : MonoBehaviour, IDoor
{
    [SerializeField] private GameObject Door;

    public void Open()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(Door.transform.DOMoveY(transform.position.y + 7f, 5f));
        yield return new WaitForSeconds(8f);

        mySequence.Append(Door.transform.DOMoveY(transform.position.y - 7f, 5f));
    }
}
