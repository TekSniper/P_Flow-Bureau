using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Main_Lib;

namespace P_Flow_Bureau
{
    public partial class Authentification : Telerik.WinControls.UI.RadForm
    {
        public Authentification()
        {
            InitializeComponent();
        }
        Utilisateur utilisateur;
        private void Authentification_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            tbPwd.UseSystemPasswordChar = true;
        }

        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {

        }

        private void radCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (radCheckBox1.CheckState == CheckState.Checked)
                tbPwd.UseSystemPasswordChar = false;
            else
                tbPwd.UseSystemPasswordChar = true;
        }

        private void btCnx_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == string.Empty || tbPwd.Text == string.Empty)
                MessageBox.Show("Remplissez les vides svp !", "Vides", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                utilisateur = new Utilisateur();
                utilisateur.Login = tbLogin.Text.Trim();
                utilisateur.Motdepasse = tbPwd.Text;
                var isExists = utilisateur.ExistsUser();
                if (isExists)
                {
                    var isAuthenticaded = utilisateur.Authentication();
                    if (isAuthenticaded)
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Le Mot de passe est incorrect. Veuillez saisir le mot de passe correct", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ce compte utilisateur n'existe pas dans le système.", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }            
        }
    }
}
