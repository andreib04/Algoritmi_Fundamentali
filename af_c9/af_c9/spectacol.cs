﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace af_c9
{
    public class spectacol
    {
        public int tInitial, tFinal;

        public spectacol(int tInitial, int tFinal)
        {
            this.tInitial = tInitial;
            this.tFinal = tFinal;
        }

        public void View()
        {
            Console.Write(tInitial+ " " + tFinal);
        }

       
    }
}
