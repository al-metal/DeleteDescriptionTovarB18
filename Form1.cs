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
            lblVsegoRazdelov.Invoke(new Action(() => lblVsegoRazdelov.Text = tovar.Count.ToString()));
            for (int n = 0; tovar.Count > n; n++)
            {
                lblRazdel.Invoke(new Action(() => lblRazdel.Text = n.ToString()));
                string urlTovar = tovar[n].ToString();
                if (urlTovar == "https://bike18.ru/products/pitbayk-bse-ph10mx-125-17-14" || urlTovar == "https://bike18.ru/products/pitbayk-bse-ssr-atom125")
                    continue;

                List<string> tovarB18 = nethouse.GetProductList(cookie, urlTovar);

                string miniDescription = tovarB18[7];
                MatchCollection spans = new Regex("<span.*?</span>").Matches(miniDescription);
                foreach(var s in spans)
                {
                    string span = s.ToString();
                    if (span.Contains("Вступай в нашу ") || span.Contains("ДОСТАВКА") || span.Contains("КОНТАКТЕ") || span.Contains("КРЕДИТ") || span.Contains("Цена на ") || span.Contains("доставка") || span.Contains("гарантия") || span.Contains("скидку") || span.Contains("скидка") || span.Contains("ПОДАРОК") || span.Contains("+") || span.Contains("Цена"))
                        miniDescription = miniDescription.Replace(span, "");
                }
                var href = new Regex("<a.*?</a>").Matches(miniDescription);
                foreach (var s in href)
                {
                    string span = s.ToString();
                    miniDescription = miniDescription.Replace(span, "");
                }
                MatchCollection paragraphs = new Regex("<p.*?</p>").Matches(miniDescription);
                foreach (var s in paragraphs)
                {
                    string span = s.ToString();
                    if (span.Contains("Вступай в нашу ") || span.Contains("ДОСТАВКА") || span.Contains("КОНТАКТЕ") || span.Contains("КРЕДИТ") || span.Contains("Цена на ") || span.Contains("доставка") || span.Contains("гарантия") || span.Contains("скидку") || span.Contains("скидка") || span.Contains("ПОДАРОК") || span.Contains("+") || span.Contains("Цена"))
                        miniDescription = miniDescription.Replace(span, "");
                }

                miniDescription = miniDescription.Replace("<p><br /></p>", "").Replace("</span></span>", "").Replace("<p></p>", "").Replace("</a>", "");

                tovarB18[7] = miniDescription;
                nethouse.SaveTovar(cookie, tovarB18);
            }


        }
    }
}
