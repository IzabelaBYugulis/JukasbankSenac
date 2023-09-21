﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukasbankSenac.Classes
{
    public class Cliente
    {
        private int _id;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("ID NÃO PODE SER MENOR QUE ZERO");
                }
                else
                {
                    this._id = value;
                }
            }
        }
        public string Nome { get; set; }


        public Cliente(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
            
        }
    }
}
