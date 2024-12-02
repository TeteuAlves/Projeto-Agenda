using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda.VariableGlobal
{
    //Publica (para todos poderem utilizar)
    //Estática (para todos utilizarem  mesma classe)
    public static class UserSession
    {
        //As variaveis que vão guardar as informações do usuário logado
        private static string _usuario = null;
        private static string _senha = null;
        private static string _nome = null;

        //Encapsulei a váriavel para ter controle do que será inserido ou pego
        public static string usuario
        {
            get { return _usuario; }
            set
            {
               
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

        public static string nome
        {
            get { return _nome; }
            set
            {
                
                _nome = value;
            }
        }
    }
}
