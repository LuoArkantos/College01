﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cls_Uteis
{
    public class Cls_TrocaDeDados
    {
        public int Index { get; set; }
        
        public Cls_TrocaDeDados(int indice)
        {
            Index = indice;
            return;
        }
        public void CapturarIndex()
        {
            if (Index != 0 || Index != null)
            {
                Index = 15;
                return;
            }
        }
        public Cls_TrocaDeDados()
        {
            CapturarIndex(); 

        }
    }
}
