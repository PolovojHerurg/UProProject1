using System.Collections; // ����������� ������������ ���� ��� ���������.
using System.Collections.Generic; // ����������� ������������ ���� ��� ���������� ���������.
using UnityEngine; // ����������� ������������ ���� UnityEngine.

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour // ��������� ���������� ����� Singleton, ������� ����������� �� MonoBehaviour.
{
    public static bool isApplicationQuitting; // ����������, �����������, ��������� �� ���������� ������.

    private static T _instance; // ����������� ���������� ��� �������� ����������.

    private static System.Object _lock = new System.Object(); // ������ ��� ����������� ������������������.

    public static T Instance // �������� ��� ��������� ������������� ����������.
    {
        get
        {
            if (isApplicationQuitting) // ���� ���������� ��������� ������, ���������� null.
                return null;

            lock (_lock) // ��������� ������ ��� ����������� ������������������.
            {
                if (_instance == null) // ���� ��������� �� ������,
                {
                    _instance = FindObjectOfType<T>(); // ���� ������������ ������ ���� T.

                    if (_instance == null) // ���� �� ������,
                    {
                        var singleton = new GameObject("[SINGLETON] " + typeof(T)); // ������� ����� ������ GameObject.
                        _instance = singleton.AddComponent<T>(); // ��������� � ���� ��������� ���� T.
                        DontDestroyOnLoad(singleton); // ������ ������ ������������� ��� �������� ����� �����.
                    }
                }

                return _instance; // ���������� ������������ ���������.
            }
        }
    }

    public virtual void OnDestroy() // �����, ���������� ��� ����������� �������.
    {
        isApplicationQuitting = true; // ������������� ���� isApplicationQuitting � true.
    }
}