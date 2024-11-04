using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player
{
    private string playerName="";
    private int health=0;
    static private int playerCount=0;

    public void InitializePlayer(string name, int initialHealth){
        playerName=name;
        health=initialHealth;
        playerCount++;
        Debug.Log("Player " + playerName + " was initialized successfully, and her/his helth is " + initialHealth);
    }
    public void Heal(int amount){
        int healthBefore=health;
        if(health<100){
            health+=amount;
            Debug.Log("The health for " + playerName + " before healing is " + healthBefore + ", and after healing by " + amount + ", the health becomes " + health + ".");
        }
        else Debug.Log("The health for " + playerName + " is Full");
    }
    public void Heal(bool full){
        int healthBefore=health;
        if (full==true){
            if (health<100){
                health=100;
                Debug.Log("The health for " + playerName + " before healing is " + healthBefore + ", and after full healing the health becomes " + health + ".");
            }
            else Debug.Log("The health for " + playerName + " is Full");
        }
    }
    public static void ShowPlayerCount(){
        string word="";
        if(playerCount==1){
            word=" player";
        }
        else if (playerCount>1){
            word=" players";
        }
        Debug.Log("Number of players in the game is " + playerCount + word);
    }


    
}
