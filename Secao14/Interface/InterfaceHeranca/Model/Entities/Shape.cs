﻿using System;
using InterfaceHeranca.Model.Enums;

namespace InterfaceHeranca.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
