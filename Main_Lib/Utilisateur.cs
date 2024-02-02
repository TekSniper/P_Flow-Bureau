using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Main_Lib
{
    public class Utilisateur
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public char Sexe { get; set; }
        public string Login { get; set; }
        public string Motdepasse { get; set; }
        public DateTime DateConnexion { get; set; }
        public DateTime HeureConnexion { get; set; }
        public string IpHost { get; set; }
        public string HostName { get; set; }

        //public bool ExistsUser()
        //{
        //    using(var cnx = new dbConnection().GetConnection())
        //    {
        //        cnx.Open();
        //    }
        //}
    }
}
