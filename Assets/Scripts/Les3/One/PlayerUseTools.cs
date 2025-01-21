using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUseTools : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            GetComponentInChildren<ITool>()?.Use();
    }
}
