﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureProject
{
    interface class Weapon : IEquippable
    {
        //primitive member variables
        private int attack;
        private string name;

        //default constructor
        public Weapon()
        {
            attack = 0;
            Name = "";
        }

        //constructor for just setting the name
        public Weapon(string setName)
        {
            attack = 0;
            Name = setName;
        }

        //constructor that sets all values
        public Weapon(int attackVal, string weaponName)
        {
            attack = attackVal;
            name = weaponName;
        }

        //access attack
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        //access name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Equip method from the IEquippable interface
        public void Equip(Character character)
        {
            character.EquippedWeapon = this;
        }

        //display information about this Weapon
        virtual public void DisplayStatus()
        {
            Console.WriteLine(name + "- Attack: " + Attack);
        }
    }
}
