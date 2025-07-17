using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;




namespace LoginScreen
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            this.AcceptButton = btnLogin;

            List<String> empresas = new List<string>()
            {
                "Selecione uma empresa",
                "Empresa A",
                "Empresa B",
                "Empresa C",
                "Empresa D",
                "Empresa E",
            };

            cmbOrgao.DataSource = empresas;

            toolTip1.SetToolTip(picUserIcon, "Usuário");
            toolTip1.SetToolTip(picSenhaIcon, "Senha");
            toolTip1.SetToolTip(picOrgaoIcon, "Empresa");

            lblErro.MaximumSize = new Size(300, 0);
            lblErro.AutoSize = true;
            lblErro.ForeColor = Color.Red;
            lblErro.TextAlign = ContentAlignment.MiddleCenter;

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbOrgao.SelectedIndex == 0)
            {
                lblErro.Text = "Selecione uma empresa antes \nde entrar.";
                cmbOrgao.Focus();
                return;
            }

            string usuario = txtUsername.Text;
            string senha = txtPassword.Text;
            string empresa = cmbOrgao.SelectedItem.ToString();

            var payload = new
            {
                codigo_usuario = usuario,
                senha = senha,
                empresa = empresa
            };

            var json = JsonConvert.SerializeObject(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.PostAsync("http://10.64.0.207:3000/", content);
                    var result = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode && result.Contains("Bem-Vindo")) {
                       
                    
                        new Form2().Show();
                        this.Hide();
                    }
                    else
                    {
               
                        lblErro.Text = "Usuário ou senha incorretos. Tente novamente.";
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
                catch (Exception ex)
                {
                    lblErro.Text = "Erro ao conectar com servidor:\n" + ex.Message;
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }



    }
}
