﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator03
{
    class MyData
    {
        private float _x;
        private float _y;
        public float X
        {
            get { return _x; }
            set { _x = value; }
        }
        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public float Add()
        {
            return X + Y;
        }
        public float Less()
        {
            return X - Y;
        }
        public float aaa()
        {
            return X * Y;
        }
        public float bbb()
        {
            return X / Y;
        }
    }
}
