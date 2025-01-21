using UnityEngine;

public interface ITool
{
    void Use();
    void Take(Vector3 position, Transform parent);
    void Throw();
}

//!21.01.2025