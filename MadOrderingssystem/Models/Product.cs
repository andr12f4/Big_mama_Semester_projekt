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
    public class Product
	{
		
		//Skal indeholde
		//Guid id, Price, Product Name

		public string Id { get; set; }
        public bool IsSelsected { get; set; }
        public double Price { get; set; }
		public string ProductName { get; set; }
        //public string ImagePath { get; set; }

        public Product() { }//default constructor
        public Product(string newId, double newPrice, string productName)
        {

            //Guid id string
            Id = newId;

            //Price
            Price = newPrice;

            //ProductName
            ProductName = productName;

        }
    }
}
