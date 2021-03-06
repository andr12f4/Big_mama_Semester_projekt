﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Models
{
    /*
     * Lavet af:    Mikkel
     * Bidraget af: 
    */
    public class Menu  : Product
    {
        
        //Skal indeholde
        //Pizzas, Accesories
        public List<Pizza> Pizzas{get; set;}
        public List<Accessory> Accesories{get; set;}
        
        public Menu() { } //default constructor
        public Menu(List<Pizza> newPizzas, List<Accessory> newAccesories, string newId,double price,string productName) : base(newId,price,productName)
        {
            
            Pizzas = newPizzas;
            Accesories = newAccesories;
        }
        


    }
}
