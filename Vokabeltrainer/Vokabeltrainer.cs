using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vokabeltrainer
{
    public partial class Vokabeltrainer : Form
    {
        //wordlists
        public static List<string> vokabeln_deutsch = new List<string>();
        public static List<string> vokabeln_englisch = new List<string>();

        public static bool theme = true;
        //true = light
        //false = dark

        public Vokabeltrainer()
        {
            InitializeComponent();

            #region theme

            //theme
            if (Vokabeltrainer.theme)
            {
                this.BackColor = Color.White;
                lbl_count.ForeColor = Color.Black;
                lbl_vokabelpaare.ForeColor = Color.Black;
                btn_vlist.ForeColor = Color.Black;
                btn_train.ForeColor = Color.Black;
                lbl_theme.ForeColor = Color.Black;
                btn_dark.FlatAppearance.BorderColor = Color.Black;
                btn_quit.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                lbl_count.ForeColor = Color.White;
                lbl_vokabelpaare.ForeColor = Color.White;
                btn_vlist.ForeColor = Color.White;
                btn_train.ForeColor = Color.White;
                lbl_theme.ForeColor = Color.White;
                btn_dark.FlatAppearance.BorderColor = Color.White;
                btn_quit.BackColor = Color.Transparent;
            }

            #endregion

            Console.WriteLine("Hello world!");
            lbl_count.Text = vokabeln_deutsch.Count().ToString();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Vokabelliste list = new Vokabelliste();
            Console.WriteLine("Vokabelliste geöffnet");
            this.Hide();
            list.Show();
        }

        private void lbl_count_Click(object sender, EventArgs e)
        {

        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_train_Click(object sender, EventArgs e)
        {
            //check if there are 0 or more than 100 words in list
            if (vokabeln_deutsch.Count() == 0 || vokabeln_englisch.Count() == 0)
                MessageBox.Show("Wählen Sie zuerst eine Vokabelliste aus oder erstellen Sie eine neue!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(vokabeln_deutsch.Count() >= 100)
                MessageBox.Show("Die maximale Anzahl der Vokabeln beträgt 100! Kürzen Sie die Vokabelliste.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Abfrage abfrage = new Abfrage();
                Console.WriteLine("Abfrage geöffnet");
                this.Close();
                abfrage.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region theme config

        private void btn_dark_Click(object sender, EventArgs e)
        {
            theme = false;
            this.BackColor = Color.FromArgb(50, 50, 50);
            lbl_count.ForeColor = Color.White;
            lbl_vokabelpaare.ForeColor = Color.White;
            btn_vlist.ForeColor = Color.White;
            btn_train.ForeColor = Color.White;
            lbl_theme.ForeColor = Color.White;
            btn_dark.FlatAppearance.BorderColor = Color.White;
            btn_quit.BackColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            theme = true;
            this.BackColor = Color.White;
            lbl_count.ForeColor = Color.Black;
            lbl_vokabelpaare.ForeColor = Color.Black;
            btn_vlist.ForeColor = Color.Black;
            btn_train.ForeColor = Color.Black;
            lbl_theme.ForeColor = Color.Black;
            btn_dark.FlatAppearance.BorderColor = Color.Black;
            btn_quit.BackColor = Color.White;
        }

        #endregion
    }
}
