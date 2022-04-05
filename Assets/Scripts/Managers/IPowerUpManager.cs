using System;

public interface IPowerUpManager
{
    public event Action PowerUpActivated;
    public event Action PowerUpDeactivated;
}
