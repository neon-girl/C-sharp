﻿using System;

namespace ConsoleApp1
{
    class EXforRef :NewAttribute
    {
        public EXforRef() { }
        public EXforRef(int i) { }
        public EXforRef(string str) { }

        public int Plus(int x, int y) { return x + y; }
        public int Minus(int x, int y) { return x - y; }

        [NewAttribute("Описание для property1")]
        public string property1
        {
            get { return _property1; }
            set { _property1 = value; }
        }
        private string _property1;

        public int property2 { get; set; }

        [NewAttribute(Description = "Описание для property3")]
        public double property3 { get; private set; }

    }
}
