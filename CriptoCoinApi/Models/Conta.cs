﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CriptoCoinApi.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public int Conta_Numero { get; set; }
        public int Conta_Agencia { get; set; }
        public String Banco { get; set; }
        public float Saldo { get; set; }
    }
}