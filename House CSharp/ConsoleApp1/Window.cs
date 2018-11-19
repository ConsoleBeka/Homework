﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Window : IPart
    {
        public Window(string material, int width, int height, int cost)
        {
            Material = material;
            Width = width;
            Height = height;
            Cost = cost;
         
        }

        public string Material { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Cost { get; set; }
    }
}
