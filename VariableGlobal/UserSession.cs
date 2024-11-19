﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda.VariableGlobal
{
    //classe pública
    public static class UserSession
    {
        //strings que vão guardar as informações do usuário
         private static string _usuario = null;
         private static string _senha = null;
        private static string _nome = null;

        //tranformando classe em pública  (para todos poderem utilizar) e estática (todos utilizarem a mesma classe)
        public static string usuario
        {
            get { return _usuario; }
            set {
                value = value.ToUpper();
                _usuario = value; 
                }
        }

        public static string senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
            }
        }
    }
}
