﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimerkki
{
  public class Calculator : ICalculator

    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiple(int number1, int number2)
        {
            return number1 * number2;
        }
    }

}
