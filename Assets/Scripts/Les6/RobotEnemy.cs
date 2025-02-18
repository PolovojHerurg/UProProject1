using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEnemy : MonoBehaviour, IRobotMove
{
    Rigidbody rb;
    private float dist = 0;
    private int cof = 1;

    public void Move()
    {

        Debug.Log($"Дистанция робота: {dist}, Коэффициент: {cof}.");
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


}