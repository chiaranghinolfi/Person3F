﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Studente : Persona
    {
        public string sezione { get; set; }

        public Studente(string nome, string cognome, int anni, string sezione) : base(nome, cognome,anni)
        {
            this.sezione = sezione;
        }


     }
}

