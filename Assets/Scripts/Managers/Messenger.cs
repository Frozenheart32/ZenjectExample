using System;

public class Messenger
{
    public event Action HelloWorld;

    public void NotifyHelloWorld()
    {
        HelloWorld?.Invoke();
    }
}