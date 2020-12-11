﻿using MadOrderingssystem.Data;
using MadOrderingssystem.Interfaces;
using MadOrderingssystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Services
{
    public class MenuHandler : IManagement<Menu>
    {

        private string filePath = @"C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Data\DataMenu.json";

        public void Create(Menu menu)
        {
            JsonMenu jsonMenu = new JsonMenu();
            menu.Id = Guid.NewGuid().ToString();
            Dictionary<string, Menu> dic = jsonMenu.ReadJsonFile(filePath);
            dic.Add(menu.Id, menu);
            jsonMenu.WriteJsonFile(dic, filePath);
        }

        public void Delete(string id)
        {
            JsonMenu jsonMenu = new JsonMenu();
            Dictionary<string, Menu> dic = jsonMenu.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonMenu.WriteJsonFile(dic, filePath);
        }

        public Dictionary<string, Menu> FilterDictionary(string filter)
        {
            //need the filtering of pizza toppings
            JsonMenu jsonMenu = new JsonMenu();
            Dictionary<string, Menu> dic = jsonMenu.ReadJsonFile(filePath);
            Dictionary<string, Menu> dicC = new Dictionary<string, Menu>();
            foreach (Menu menu in dic.Values)
            {
                if (menu.Id.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(menu.Id, menu);
                }
                if (menu.ProductName.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(menu.ProductName, menu);
                }
            }
            return dicC;
        }

        public Menu Get(string id)
        {
            JsonMenu jsonMenu = new JsonMenu();
            Dictionary<string, Menu> dic = jsonMenu.ReadJsonFile(filePath);
            try
            {
                return dic[id];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("KeyNotFound " + ex.Message);
                return null;
            }
        }

        public Dictionary<string, Menu> GetDictionary()
        {
            JsonMenu jsonMenu = new JsonMenu();
            return jsonMenu.ReadJsonFile(filePath);
        }

        public void Update(Menu newMenu, string id)
        {
            JsonMenu jsonMenu = new JsonMenu();
            Dictionary<string, Menu> dic = jsonMenu.ReadJsonFile(filePath);
            dic[id] = newMenu;
            jsonMenu.WriteJsonFile(dic, filePath);
        }
    }
}
