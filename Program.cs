﻿using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
      
      
      static List<string> GetEmployees()
   {
    // I will return a List of strings
    List<string> 
    employees = new List<string>();
    while (true) 
   {
    Console.WriteLine("Please enter a name: (leave empty to exit): ");
    string input = Console.ReadLine() ?? "";
    if (input == "") 
    {
      break;
    }
    employees.Add(input);
   }
  // This is important!
  return employees;
   }

      static void PrintEmployees(List<string> employees)
  {
    for (int i = 0; i < employees.Count; i++)
    {
      Console.Write(employees[i]);
    }
  }

  static void Main(string[] args)
  {
    List<string> employees = GetEmployees();
    PrintEmployees(employees);
  }

  }
}