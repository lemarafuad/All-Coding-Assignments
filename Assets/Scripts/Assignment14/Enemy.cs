using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public void Attack(int amount){
        Health-=amount;
    }
}
