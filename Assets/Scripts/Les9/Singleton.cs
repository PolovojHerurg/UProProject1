using System.Collections; // Импортируем пространство имен для коллекций.
using System.Collections.Generic; // Импортируем пространство имен для обобщенных коллекций.
using UnityEngine; // Импортируем пространство имен UnityEngine.

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour // Объявляем обобщенный класс Singleton, который наследуется от MonoBehaviour.
{
    public static bool isApplicationQuitting; // Переменная, указывающая, завершает ли приложение работу.

    private static T _instance; // Статическая переменная для хранения экземпляра.

    private static System.Object _lock = new System.Object(); // Объект для обеспечения потокобезопасности.

    public static T Instance // Свойство для получения единственного экземпляра.
    {
        get
        {
            if (isApplicationQuitting) // Если приложение завершает работу, возвращаем null.
                return null;

            lock (_lock) // Блокируем доступ для обеспечения потокобезопасности.
            {
                if (_instance == null) // Если экземпляр не создан,
                {
                    _instance = FindObjectOfType<T>(); // Ищем существующий объект типа T.

                    if (_instance == null) // Если не найден,
                    {
                        var singleton = new GameObject("[SINGLETON] " + typeof(T)); // Создаем новый объект GameObject.
                        _instance = singleton.AddComponent<T>(); // Добавляем к нему компонент типа T.
                        DontDestroyOnLoad(singleton); // Делаем объект неразрушаемым при загрузке новой сцены.
                    }
                }

                return _instance; // Возвращаем единственный экземпляр.
            }
        }
    }

    public virtual void OnDestroy() // Метод, вызываемый при уничтожении объекта.
    {
        isApplicationQuitting = true; // Устанавливаем флаг isApplicationQuitting в true.
    }
}