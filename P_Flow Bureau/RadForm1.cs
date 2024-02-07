using Main_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Npgsql;

namespace P_Flow_Bureau
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            /***
             * Test de connexion
             */
            //using(var cnx = new dbConnection().GetConnection())
            //{
            //    try
            //    {
            //        cnx.Open();
            //        MessageBox.Show("Connexion réussie !");
            //        var cm = new NpgsqlCommand("select count(*) from pf.utilisateur", cnx);
            //        var reader = cm.ExecuteReader();
            //        if (reader.Read())
            //            MessageBox.Show("Le nombre d'utilisateur est : " + reader[0].ToString());
            //        else
            //            MessageBox.Show("Echec de la recherche");
            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show("Echec de la connexion :\n"+ex.Message);
            //    }
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= panel1.Width) 
            {
                timer1.Stop();
                Authentification authentification = new Authentification();
                authentification.Show();
                this.Hide();
            }
        }
    }
}
