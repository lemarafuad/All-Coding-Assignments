using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Playerr player1 = new Playerr();
        Enemy enemy1 = new Enemy();

        Debug.Log(player1.Name);
        Debug.Log(player1.Health);
        Debug.Log(enemy1.Name);
        Debug.Log(enemy1.Health);

        player1.Heal(20);
        Debug.Log(player1.Health);

        enemy1.Attack(20);
        Debug.Log(enemy1.Health);



    }

}
