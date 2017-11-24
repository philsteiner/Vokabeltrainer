using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vokabeltrainer
{
    public partial class Auswertung : Form
    {
        int top1, top2, top3;
        int totalfail = 0;

        public Auswertung()
        {
            InitializeComponent();

            #region theme
            //theme
            if (Vokabeltrainer.theme)
            {
                this.BackColor = Color.White;
                lbl_words.ForeColor = Color.Black;
                lbl_time.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                lbl_num1.ForeColor = Color.Black;
                lbl_num2.ForeColor = Color.Black;
                lbl_num3.ForeColor = Color.Black;
                lbl_word1.ForeColor = Color.Black;
                lbl_word2.ForeColor = Color.Black;
                lbl_word3.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(50,50,50);
                lbl_words.ForeColor = Color.White;
                lbl_time.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                lbl_num1.ForeColor = Color.White;
                lbl_num2.ForeColor = Color.White;
                lbl_num3.ForeColor = Color.White;
                lbl_word1.ForeColor = Color.White;
                lbl_word2.ForeColor = Color.White;
                lbl_word3.ForeColor = Color.White;
            }
            #endregion

            #region set labels
            //words learned
            if (Vokabeltrainer.vokabeln_deutsch.Count() == 1)
                lbl_words.Text = Vokabeltrainer.vokabeln_deutsch.Count().ToString() + " Wort gelernt!";
            else
                lbl_words.Text = Vokabeltrainer.vokabeln_deutsch.Count().ToString() + " Wörter gelernt!";

            //time needed
            if (Abfrage.ts.Minutes == 1 && Abfrage.ts.TotalSeconds == 1 )
                lbl_time.Text = "Benötigte Zeit: " + String.Format("{00}", Abfrage.ts.Minutes) + " Minute und " + String.Format("{00}", Abfrage.ts.Seconds) + " Sekunde.";
            else if(Abfrage.ts.Minutes == 1 && Abfrage.ts.TotalSeconds > 1)
                lbl_time.Text = "Benötigte Zeit: " + String.Format("{00}", Abfrage.ts.Minutes) + " Minute und " + String.Format("{00}", Abfrage.ts.Seconds) + " Sekunden.";
            else if (Abfrage.ts.Minutes > 1 && Abfrage.ts.TotalSeconds == 1)
                lbl_time.Text = "Benötigte Zeit: " + String.Format("{00}", Abfrage.ts.Minutes) + " Minuten und " + String.Format("{00}", Abfrage.ts.Seconds) + " Sekunde.";
            else
                lbl_time.Text = "Benötigte Zeit: " + String.Format("{00}", Abfrage.ts.Minutes) + " Minuten und " + String.Format("{00}", Abfrage.ts.Seconds) + " Sekunden.";

            //total errors
            for (int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
            {
                totalfail = totalfail + Abfrage.values[i][2];
            }

            lbl_total_errors.Text = totalfail.ToString();
            if(totalfail == 0)
            {
                pb_errors.BackColor = 
                lbl_gesamt.BackColor =
                lbl_total_errors.BackColor = Color.FromArgb(50, 148, 59);
            }
            else if(totalfail <= 10)
            {
               pb_errors.BackColor =
               lbl_gesamt.BackColor =
               lbl_total_errors.BackColor = Color.FromArgb(255, 114, 42);
            }
            else
            {
                  pb_errors.BackColor =
                  lbl_gesamt.BackColor =
                  lbl_total_errors.BackColor = Color.FromArgb(215, 66, 60);
            }
            //wrong words top 3
            top3w();
            #endregion
        }

        private void top3w()
        {
            if (Vokabeltrainer.vokabeln_deutsch.Count() == 1)
            {
                lbl_word1.Text = Vokabeltrainer.vokabeln_deutsch[0] + " - " + Vokabeltrainer.vokabeln_englisch[0];
                lbl_num1.Text = Abfrage.values[0][2].ToString();
                lbl_word2.Hide();
                lbl_num2.Hide();
                lbl_word3.Hide();
                lbl_num3.Hide();
            }
            else if (Vokabeltrainer.vokabeln_deutsch.Count() == 2)
            {
                lbl_word1.Text = Vokabeltrainer.vokabeln_deutsch[0] + " - " + Vokabeltrainer.vokabeln_englisch[0];
                lbl_num1.Text = Abfrage.values[0][2].ToString();
                lbl_word2.Text = Vokabeltrainer.vokabeln_deutsch[1] + " - " + Vokabeltrainer.vokabeln_englisch[1];
                lbl_num2.Text = Abfrage.values[1][2].ToString();
                lbl_word3.Hide();
                lbl_num3.Hide();
            }
            else if (Vokabeltrainer.vokabeln_deutsch.Count() == 3)
            {
                lbl_word1.Text = Vokabeltrainer.vokabeln_deutsch[0] + " - " + Vokabeltrainer.vokabeln_englisch[0];
                lbl_num1.Text = Abfrage.values[0][2].ToString();
                lbl_word2.Text = Vokabeltrainer.vokabeln_deutsch[1] + " - " + Vokabeltrainer.vokabeln_englisch[1];
                lbl_num2.Text = Abfrage.values[1][2].ToString();
                lbl_word3.Text = Vokabeltrainer.vokabeln_deutsch[2] + " - " + Vokabeltrainer.vokabeln_englisch[2];
                lbl_num3.Text = Abfrage.values[2][2].ToString();
            }
            else
            {
                //clone array to safe your stats later
                //0, 1 are actually not needed
                int[][] valuescopy =  (int[][])Abfrage.values.Clone();

                //get word with highest fail counter
                for (int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
                {
                    if (valuescopy[i][2] > top1)
                        top1 = i;
                }
                lbl_word1.Text = Vokabeltrainer.vokabeln_deutsch[top1] + " - " + Vokabeltrainer.vokabeln_englisch[top1];
                lbl_num1.Text = valuescopy[top1][2].ToString();
                valuescopy[top1][2] = 0;
                
                //second highest
                for (int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
                {
                    if (valuescopy[i][2] > top2)
                        top2 = i;
                }
                lbl_word2.Text = Vokabeltrainer.vokabeln_deutsch[top2] + " - " + Vokabeltrainer.vokabeln_englisch[top2];
                lbl_num2.Text = valuescopy[top2][2].ToString();
                valuescopy[top2][2] = 0;
                
                //third highest
                for (int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
                {
                    if (valuescopy[i][2] > top3)
                        top3 = i;
                }
                lbl_word3.Text = Vokabeltrainer.vokabeln_deutsch[top3] + " - " + Vokabeltrainer.vokabeln_englisch[top3];
                lbl_num3.Text = valuescopy[top3][2].ToString();
            }
        }

        //restart the training
        private void btn_again_Click(object sender, EventArgs e)
        {
            Abfrage abfrage = new Abfrage();
            Console.WriteLine("Abfrage geöffnet");
            this.Close();
            abfrage.Show();
        }

        //save your result as txt
        private void btn_savestats_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Textdatei(*.txt)|*.txt";
            sfd.Title = "Ergebnis speichern";
            sfd.RestoreDirectory = true;
            sfd.ShowDialog();

            if (sfd.FileName != "" && sfd.ShowDialog() == DialogResult.OK)
            {
                Stream fs = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(fs);

                //write result in txt
                sw.Write("Training absolviert am " + DateTime.Now.ToLongDateString() + " um " + DateTime.Now.ToString("H:mm") + " Uhr." +
                    "\r\n\r\nWörter gelernt: " + Vokabeltrainer.vokabeln_deutsch.Count().ToString() + 
                    "\r\nBenötigte Zeit: " + String.Format("{00}", Abfrage.ts.Minutes) + " Minute(n) und " + String.Format("{00}", Abfrage.ts.Seconds) + " Sekunde(n)." +
                    "\r\nFehler gesamt: " + totalfail.ToString());

                sw.Close();
                fs.Close();
            }
        }

        //get back to the menu
        private void btn_back_Click(object sender, EventArgs e)
        {
            Vokabeltrainer vt = new Vokabeltrainer();
            vt.Show();
            this.Close();
        }

        private void Auswertung_Load(object sender, EventArgs e)
        {

        }
    }
}
