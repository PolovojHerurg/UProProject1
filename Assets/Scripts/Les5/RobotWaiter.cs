using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotWaiter : MonoBehaviour, IRobots, IWaiter
{
    [SerializeField] protected GameObject _coffe;
    public virtual void Bring()
    {
        Debug.Log("С утра выпил - весь день свободен!");
        Instantiate(_coffe,transform.position + new Vector3(0f,1f,-1f), Quaternion.identity);
    }

    public void Greeting()
    {
        Debug.Log("Здарова солнышки!");
    }

    public virtual void Use()
    {
        Debug.Log("Таки кто тут у нас тут такой красивый хочет кофе?");
    }
}
