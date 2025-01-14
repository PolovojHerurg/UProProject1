using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCreate : MonoBehaviour, IButtonPortal
{
    [SerializeField] GameObject portal;

    public void ClickButton()
    {
        Instantiate(portal);
    }
}
