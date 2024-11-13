using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assignment16
{
    public class CharacterTest : MonoBehaviour
    {
        Officer officer0;
        Officer officer1;
        Officer officer2;
        Soldier soldier0;
        Soldier soldier1;
        Soldier soldier2;
        Character[] CharacterHome = new Character[4];
        Soldier[] soldiers = new Soldier[2];
        Officer[] officers = new Officer[2];
        string[] attackType = { "shooting", "kicking", "punching", "slashing", "throwing" };

        void Start()
        {
            // Let’s imagine Conan and Heiji as the officers, and the Black Organization as the soldiers
            officer0 = new Officer("Heiji", 40, new Position(0, 0, 0));
            soldier0 = new Soldier();

            officer1 = new Officer("Conan Edogawa", 100, new Position(0, 0, 0));
            soldier1 = new Soldier("Gin", 100, new Position(0, 0, 0));

            // officer2 = new Officer("Megure", 70, new Position(0, 0, 0));
            // soldier2 = new Soldier("Vodka", 100, new Position(0, 0, 0));

            CharacterHome[0] = officer0;
            CharacterHome[1] = officer1;
            // CharacterHome[0] = officer2;
            CharacterHome[2] = soldier0;
            CharacterHome[3] = soldier1;
            // CharacterHome[4] = soldier2;


            soldiers[0] = soldier0;
            soldiers[1] = soldier1;
            // soldiers[2] = soldier2;

            officers[0] = officer0;
            officers[1] = officer1;
            // officers[2] = officer2;

            Debug.Log("That day, Conan discovers the location of Gin and another member of the Black Organization He decides to inform Heiji,\n" +
          " then they plan an attack, A big fight breaks out at the location, and later, an eyewitness is called in to recount the events.");

            for (int i = 0; i < CharacterHome.Length; i++)
            {
                CharacterHome[i].DisplayInfo();
            }

            bool someoneDied = false;

            while (!someoneDied)
            {
                // Debug.Log("inside first loop");
                RandomAttack();
                for (int i = 0; i < CharacterHome.Length; i++)
                {
                    // Debug.Log("inside second loop");
                    if (CharacterHome[i].Health == 0)
                    {
                        Debug.Log(CharacterHome[i].name + " died");
                        someoneDied = true;
                        break;
                    }
                }
            }


        }

        // I created this function to avoid repeat writing print statements
        public void CallAttackOnSoldier(Officer officer, Soldier soldier, string attackType)
        {
            Debug.Log("---------New Attack---------");
            int soldierHealthBefore = soldier.Health;
            int damage = CheckDamage(attackType);
            Debug.Log(officer.name + " " + attackType + " " + soldier.name + " causing " + damage + " damage.");
            officer.Attack(damage, soldier);
            int soldierHealthAfter = soldier.Health;
            Debug.Log(officer.name + "'s health before: " + officer.Health + " , after: " + officer.Health + "\n"
            + soldier.name + "'s health before: " + soldierHealthBefore + " , after: " + soldierHealthAfter);
        }

        public void CallAttackOnOfficer(Officer officer, Soldier soldier, string attackType)
        {
            Debug.Log("---------New Attack---------");
            int officerHealthBefore = officer.Health;
            int damage = CheckDamage(attackType);
            Debug.Log(soldier.name + " " + attackType + " " + officer.name + " causing " + damage + " damage.");
            soldier.Attack(damage, officer);
            int officerHealthAfter = officer.Health;
            Debug.Log(officer.name + "'s health before: " + officerHealthBefore + " , after: " + officerHealthAfter + "\n"
            + soldier.name + "'s health before: " + soldier.Health + " , after: " + soldier.Health);
        }
        public int CheckDamage(string attackType)
        {
            if (attackType == "shooting") { return 30; }
            else if (attackType == "kicking") { return 15; }
            else if (attackType == "punching") { return 10; }
            else if (attackType == "slashing") { return 25; }
            else if (attackType == "throwing") { return 12; }
            else { return 0; }
        }
        public void RandomAttack()
        {
            // Debug.Log("inside random attack");
            int random_attack = Random.Range(0, 4);
            int random_soldier = Random.Range(0, 2);
            int random_officer = Random.Range(0, 2);
            int random_number = Random.Range(0, 2);

            string selected_attack = attackType[random_attack];
            Soldier selected_soldier = soldiers[random_soldier];
            Officer selected_officer = officers[random_officer];
            if (random_number == 0) { CallAttackOnOfficer(selected_officer, selected_soldier, selected_attack); }
            else { CallAttackOnSoldier(selected_officer, selected_soldier, selected_attack); }

        }

    }
}