using UnityEngine;

public class PlayerInput : IPlayerInput
{
    public void GetInput()
    {
        Debug.Log("Игрок получил управление");
    }
}
