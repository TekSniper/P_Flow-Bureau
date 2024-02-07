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

        public bool ExistsUser()
        {
            using (var cnx = new dbConnection().GetConnection())
            {
                cnx.Open();
                var cm = new NpgsqlCommand("select * from pf.utilisateur where login=@login", cnx);
                cm.Parameters.AddWithValue("@login", this.Login);
                var reader = cm.ExecuteReader();
                if(reader.Read())
                    return true;
                else
                    return false;
            }
        }
        public bool Authentication()
        {
            using(var cnx = new dbConnection().GetConnection())
            {
                cnx.Open();
                var cm = new NpgsqlCommand("select * from pf.utilisateur where login=@login and mot_de_passe=@pwd", cnx);
                cm.Parameters.AddWithValue("@login", this.Login);
                cm.Parameters.AddWithValue("@pwd", this.Motdepasse);
                var reader = cm.ExecuteReader();   
                if(reader.Read()) return true;
                else return false;
            }
        }
    }
}
