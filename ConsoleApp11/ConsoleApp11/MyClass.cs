﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class MyClass
    {
        public string change;
    }

    public struct MyStruct
    {
        public string change;
    }

    public struct Notebook
    {
        public string Model;
        public string Manufacturer;
        public decimal Price;

        public Notebook(string model, string manufacturer, decimal price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Производитель: {Manufacturer}");
            Console.WriteLine($"Цена: {Price} рублей");
        }
    }