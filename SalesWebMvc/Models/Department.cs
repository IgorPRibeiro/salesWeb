﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // associacoes (lista de Sellers)
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addSeller(Seller sr)
        {
            Sellers.Add(sr);
        }
        
        public double totalSeles(DateTime initial, DateTime final)
        {
            return Sellers.Sum(sr => sr.TotalSales(initial, final));
        }

    }
} 
