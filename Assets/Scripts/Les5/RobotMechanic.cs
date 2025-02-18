using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMechanic : MonoBehaviour, IRobots
{
    public void Greeting()
    {
        Debug.Log(" ороче, ћеченый, € теб€ спас и в благородство играть не буду: выполнишь дл€ мен€ пару заданий Ч и мы в расчете. «аодно посмотрим, как быстро у теб€ башка после амнезии про€снитс€. ");
    }

    public void Use()
    {
        Debug.Log("95 залить?");
    }
}