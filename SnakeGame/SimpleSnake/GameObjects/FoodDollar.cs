﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects
{
    public class FoodDollar : Food
    {
        public FoodDollar(Wall wall) : base(wall, '$', 2)
        {
        }
    }
}
