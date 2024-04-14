using System;

public delegate void EventHandler();


public class EventManager
{
    private event EventHandler? CustomEvent; 

    
    public void AddEventHandler(EventHandler? handler)
    {
        CustomEvent += handler;
    }

    
    public void RemoveEventHandler(EventHandler? handler)
    {
        CustomEvent -= handler;
    }

   
    public void TriggerEvent()
    {
        CustomEvent?.Invoke(); 
    }
}


class Program
{
    static void Main(string[] args)
    {
       
        EventManager eventManager = new();

        
        eventManager.AddEventHandler(Handler1);
        eventManager.AddEventHandler(Handler2);

        
        Console.WriteLine("Trigger the event");
        eventManager.TriggerEvent();

        
        eventManager.RemoveEventHandler(Handler1);

        
        Console.WriteLine("Trigger the event 2");
        eventManager.TriggerEvent();
    }

    
    static void Handler1()
    {
        Console.WriteLine("Handler 1 invoked");
    }

    static void Handler2()
    {
        Console.WriteLine("Handler 2 invoked");
    }
}