using System;using UnityEngine;

public class PowerUpManager : MonoBehaviour, IPowerUpManager
{
    public event Action PowerUpActivated;
    public event Action PowerUpDeactivated;
    
    
    //представим, что тут куча приватных методов
}
