using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject _robot;
    [SerializeField] private GameObject _turret;
    [SerializeField] private GameObject _komrad;

    private IRobotMove robotEnemy;
    private ITurret turretEnemy;
    private IRobotMove komradEnemy;

    private void Start()
    {
        robotEnemy = _robot.GetComponent<IRobotMove>();
        turretEnemy = _turret.GetComponent<ITurret>();
        komradEnemy = _komrad.GetComponent<IRobotMove>();
    }

    private void FixedUpdate()
    {
        robotEnemy?.Move();
        komradEnemy?.Move();
    }
}
