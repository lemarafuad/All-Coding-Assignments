using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1=new Player();
        Player player2=new Player();

        bool fullRestore=true;
        
        player1.InitializePlayer("LM",21);
        player2.InitializePlayer("RT",60);
        
        player1.Heal(20);
        player2.Heal(5);

        player1.Heal(fullRestore);
        player2.Heal(fullRestore);
        
        Player.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
