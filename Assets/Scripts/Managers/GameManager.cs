using UnityEngine;

public class GameManager
{
    private Messenger _messenger = new Messenger();

    public Messenger GlobalMessenger => _messenger;

    public void Hello()
    {
        Debug.Log("Hello from GameManager");
    }
}