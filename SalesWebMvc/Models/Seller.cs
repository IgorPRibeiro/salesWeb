﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }


        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime BirthDate, double BaseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            this.BirthDate = BirthDate;
            this.BaseSalary = BaseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr) {  
            Sales.Remove(sr); 
        }

        public double TotalSales(DateTime initial, DateTime final )
        {
            // MT SIMPLES. PRIMEIRO FILTRA A DATA INICIAL E FINAL, E DEPOIS SOMA TUDO QUE ESTA NO AMOUNT
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }


    }
}
