﻿namespace lab04.entity
{
    public abstract class Employee: Person
    {
        public double Salary { get; set; }
        public string Department { get; set; }
        public int DateHired { get; set; } // 1,2,3,4,5 year
        public abstract int CalculateVacation();
        public abstract double CalculateBonus();
    }
}