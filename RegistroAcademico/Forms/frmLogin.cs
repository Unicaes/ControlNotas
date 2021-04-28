﻿using PlayerUI.Model;
using PlayerUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class frmLogin : Form
    {
        private ApiService api = new ApiService();
        Usuario oUsuario;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FillUsuario();
            var resp = await api.Post(Controllers.UsuarioController+"/Login",oUsuario);
            if (resp.IsSuccess)
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifica tus datos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void FillUsuario()
        {
            oUsuario = new Usuario();
            oUsuario.Username = txtUsername.Text.Trim();
            oUsuario.Clave = txtPassword.Text.Trim();

        }
    }
}
