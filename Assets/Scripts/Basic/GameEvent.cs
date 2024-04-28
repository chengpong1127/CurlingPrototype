using System.Collections.Generic;
using UnityEngine;


public abstract class GameEvent{
    protected GameEvent(){
        allGameEvents.Add(this);
    }
    public string EventName;
    public abstract void Run();
    static List<GameEvent> allGameEvents = new();
    static public void RunEvent(string eventName){
        foreach(GameEvent gameEvent in allGameEvents){
            if(gameEvent.EventName == eventName){
                gameEvent.Run();
                break;
            }
        }
    }
    
}