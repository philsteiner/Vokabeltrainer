using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vokabeltrainer
{
    public partial class Abfrage : Form
    {
        int rVoc = 0;
        int previousRandom = 0;
        bool language = false;   
        bool done = false;
        Random r = new Random();
        public static int[][] values = new int[100][];
        int counter = 0;
        int l0, l1, l2, l3;
        Stopwatch stop = new Stopwatch();
        public static TimeSpan ts;

        //0 previous voc 1
        //1 how often correct
        //2 fail counter

        public Abfrage()
        {
            InitializeComponent();
            
            #region theme
            //theme
            if (Vokabeltrainer.theme)
            {
                this.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                lbl_lvls.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                label1.ForeColor = Color.White;
                lbl_lvls.ForeColor = Color.White;
            }
            #endregion


            //timer
            stop.Start();
            
            //editing question false
            txt_question.ReadOnly = true;


            Console.WriteLine(Vokabeltrainer.vokabeln_deutsch.Count());


            //create value array
            for (int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
            {
                values[i] = new int[3] { 0, 0, 0 };
                Console.WriteLine(values[i][0].ToString() + " " + values[i][1].ToString() + " " + values[i][2].ToString());
            }

            Console.WriteLine("\nValues:");
            for (int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
            {
                Console.WriteLine(values[i][0] + " - " + values[i][1] + " - " + values[i][2]);
            }


            updateLabel();
            randomVoc();
            //Console.WriteLine("Random Zahl: " + rVoc);
            randomLang();
            //if (language)
            //    Console.WriteLine("Random Lang: Deutsch");
            //else if (!language)
            //    Console.WriteLine("Random Lang: Englisch");
            writeInTxtBox();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void updateLabel()
        {
            
            l0 = l1 = l2 = l3 = 0;

            for(int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
            {
                if(values[i][1] == 0)
                    l0++;

                else if(values[i][1] == 1)
                    l1++;

                else if (values[i][1] == 2)
                    l2++;

                else if (values[i][1] == 3)
                    l3++;
            }

            lbl_0.Text = l0.ToString();
            lbl_1.Text = l1.ToString();
            lbl_2.Text = l2.ToString();
            lbl_3.Text = l3.ToString();
        }

        //write selected voc to txt_question
        private void writeInTxtBox()
        {
            if (language)
            {
                txt_question.Text = Vokabeltrainer.vokabeln_deutsch[rVoc].ToString();
            }
            else if(!language)
            {
                txt_question.Text = Vokabeltrainer.vokabeln_englisch[rVoc].ToString();
            }
        }

        //select if the voc is german or english & set pics
        private bool randomLang()
        {
            language = r.Next(2) == 0 ? false : true;

            //set pics to pbs
            if (language)
            {
                pb1.Image = pics.Germany;
                pb2.Image = pics.UK;
            }
            else if(!language)
            {
                pb1.Image = pics.UK;
                pb2.Image = pics.Germany;
            }

            return language;
        }

        //select a random voc
        private int randomVoc()
        {
            rVoc = r.Next(Vokabeltrainer.vokabeln_deutsch.Count());
            while(true)
            {
                rVoc = r.Next(Vokabeltrainer.vokabeln_deutsch.Count());
                Console.WriteLine("Random Zahl:" + rVoc);

                count();
                Console.WriteLine(counter);

                //checks if there  is only one word left
                if(counter == Vokabeltrainer.vokabeln_deutsch.Count() * 3 -1 ||
                    counter == Vokabeltrainer.vokabeln_deutsch.Count() * 3 - 2 ||
                    counter == Vokabeltrainer.vokabeln_deutsch.Count() * 3 - 3)
                {
                    Console.WriteLine("Nur mehr ein Wort nicht 3mal abgefragt!");
                    for(int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
                    {
                        if(values[i][1] != 3)
                        {
                            rVoc = i;
                            //breaks after item found, bc there is only one possible
                            break;
                        }
                    }
                    break;                    
                }
                
                
                if (values[rVoc][0] == 0 && values[rVoc][1] != 3)
                    break;
            }
            values[rVoc][0] = 1;
            values[previousRandom][0] = 0;
            previousRandom = rVoc;
            Console.WriteLine(values[rVoc][0] + " - " + values[rVoc][1] + " - " + values[rVoc][2]);
            return rVoc;
        }

        //counts the how often correct value
        private int count()
        {
            counter = 0;
            for (int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
            {
                counter = counter + values[i][1];
            }
            return counter;
        }

        private void Abfrage_Load(object sender, EventArgs e)
        {

        }

        //check button
        private void btn_check_Click(object sender, EventArgs e)
        {
            checkAnswer();
            updateLabel();
            txt_answer.Clear();
            checkIfDone();
            Console.WriteLine(done);
            if(!done)
            {
                randomVoc();
                randomLang();
                writeInTxtBox();
            }
            else if(done)
            {
                stop.Stop();
                ts = stop.Elapsed;

                //MessageBox.Show("Alle Vokabeln gelernt");
                Auswertung aw = new Auswertung();
                aw.Show();
                this.Close();
            }

        }

        //check if all words are values[n][2] = 3 
        //or in other words if all words learned
        private bool checkIfDone()
        {
            count();

            if (counter == Vokabeltrainer.vokabeln_deutsch.Count() * 3)
            {
                done = true;
            }
            else
            {
                done = false;
            }

            return done;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        //check if answer is true or false
        private void checkAnswer()
        {
            if(language)
            {
                //correct answer
                if (txt_answer.Text == Vokabeltrainer.vokabeln_englisch[rVoc])
                {
                    if (values[rVoc][1] < 3)
                        values[rVoc][1]++;
                    
                    label1.ForeColor = Color.Green;
                    label1.Text = "Richtige Antwort";
                    
                }
                //false answer
                else if (txt_answer.Text != Vokabeltrainer.vokabeln_englisch[rVoc])
                {
                    if (values[rVoc][1] > 0)
                        values[rVoc][1]--;
                    values[rVoc][2]++;

                    label1.ForeColor = Color.Red;
                    label1.Text = "Falsch! Richtige Antwort: '" + Vokabeltrainer.vokabeln_englisch[rVoc] + "'.";
                }
            }
            else if(!language)
            {
                //correct answer
                if (txt_answer.Text == Vokabeltrainer.vokabeln_deutsch[rVoc])
                {
                    if (values[rVoc][1] < 3)
                        values[rVoc][1]++;

                    label1.ForeColor = Color.Green;
                    label1.Text = "Richtige Antwort";
                }
                //false answer
                else if (txt_answer.Text != Vokabeltrainer.vokabeln_deutsch[rVoc])
                {
                    if (values[rVoc][1] > 0)
                        values[rVoc][1]--;
                    values[rVoc][2]++;

                    label1.ForeColor = Color.Red;
                    label1.Text = "Falsch! Richtige Antwort: '" + Vokabeltrainer.vokabeln_deutsch[rVoc] + "'.";
                }
            }
        }

        //usability improvements
        private void txt_answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_check.PerformClick();
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            Vokabeltrainer vt = new Vokabeltrainer();

            if (!done)
            {
                DialogResult warning = MessageBox.Show("Die Abfrage wird ohne speichern abgebrochen. Trotzdem fortfahren?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (warning == DialogResult.Yes)
                {
                    stop.Stop();
                    vt.Show();
                    this.Close();
                }
            }
            else if(done)
            {
                stop.Stop();
                vt.Show();
                this.Close();
            }  
        }
    }
}
