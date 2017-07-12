using Bike18;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteDescriptionTovarB18
{
    public partial class Form1 : Form
    {
        Thread forms;

        nethouse nethouse = new nethouse();
        httpRequest httprequest = new httpRequest();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbLogin.Text = Properties.Settings.Default.login;
            tbPasswords.Text = Properties.Settings.Default.password;
        }

        private void btnActualPrice_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.login = tbLogin.Text;
            Properties.Settings.Default.password = tbPasswords.Text;
            Properties.Settings.Default.Save();

            Thread tabl = new Thread(() => UpdateTovar());
            forms = tabl;
            forms.IsBackground = true;
            forms.Start();
        }

        private void UpdateTovar()
        {
            CookieContainer cookie = nethouse.CookieNethouse(tbLogin.Text, tbPasswords.Text);
            if (cookie.Count == 1)
            {
                MessageBox.Show("Логин или пароль для сайта введены не верно", "Ошибка логина/пароля");
                return;
            }

            string otv = httprequest.getRequest("https://bike18.ru/products/category/2180745?page=all");
            MatchCollection tovar = new Regex("(?<=<div class=\"product-link -text-center\"><a href=\").*(?=\" >)").Matches(otv);
            for (int n = 0; tovar.Count > n; n++)
            {
                string urlTovar = tovar[n].ToString();
            }


        }
    }
}
