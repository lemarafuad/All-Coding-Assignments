using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameNamespace;
public class Character
{
    private string name;
    public string Name{
        get{return name;}
        set{name=value;}
    }
    private int health;
    public int Health{
        get{return health;}
        set{
            if(value>100){health=100;}
            else if(value>0 && value<100){health=value;}
            else{health=0;}
        }
    }
    public Character(string name,int health){
        Name=name;
        Health=health;
    }
}
