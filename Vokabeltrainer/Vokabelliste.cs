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
    public partial class Vokabelliste : Form
    {
        public Vokabelliste()
        {
            InitializeComponent();

            #region theme
            //theme
            if(Vokabeltrainer.theme)
            {
                this.BackColor = Color.White;
                btn_add.ForeColor = Color.Black;
                lbl_del.ForeColor = Color.Black;
                pb_bottom.BackColor = Color.FromArgb(50, 50, 50);
                btn_open.ForeColor = Color.White;
                btn_open.BackColor = Color.FromArgb(50, 50, 50);
                btn_save.ForeColor = Color.White;
                btn_save.BackColor = Color.FromArgb(50, 50, 50);
                btn_done.BackColor = Color.FromArgb(50, 50, 50);

                lb_de.ForeColor = Color.FromArgb(50, 50, 50);
                lb_en.ForeColor = Color.FromArgb(50, 50, 50);
                lb_de.BackColor = Color.White;
                lb_en.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                btn_add.ForeColor = Color.White;
                lbl_del.ForeColor = Color.White;
                //pb_bottom.BackColor = Color.White;
                //btn_open.ForeColor = Color.Black;
                //btn_open.BackColor = Color.White;
                //btn_save.ForeColor = Color.Black;
                //btn_save.BackColor = Color.White;
                //btn_done.BackColor = Color.White;

                lb_de.BackColor = Color.FromArgb(50, 50, 50);
                lb_en.BackColor = Color.FromArgb(50, 50, 50);
                lb_de.ForeColor = Color.White;
                lb_en.ForeColor = Color.White;
            }
            #endregion

            this.ActiveControl = txt_de;
            txt_de.Focus();
            
            //show words from list
            for (int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
            {
                lb_de.Items.Add(Vokabeltrainer.vokabeln_deutsch[i]);
                lb_en.Items.Add(Vokabeltrainer.vokabeln_englisch[i]);
            }
        }

        #region open & save 
        OpenFileDialog ofd = new OpenFileDialog();
        List<string> fileTemp = new List<string>();

        //open vkbl file
        private void btn_open_Click(object sender, EventArgs e)
        {
            if (lb_de.Items.Count != 0 || lb_en.Items.Count != 0)
            {
                DialogResult warning = MessageBox.Show("Wenn Sie eine Datei öffnen wird ihre aktuelle Liste ohne speichern überschrieben!", "Achtung", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (warning == DialogResult.OK)
                {
                    readFile();
                }
            }
            else
            {
                readFile();
            }
        }

        //insert words from file to list & lb
        private void readFile()
        {
            ofd.Filter = "Vokabeldatei(*.vkbl)|*.vkbl";
            ofd.Title = "Vokabeldatei öffnen";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //clear list and lb
                lb_de.Items.Clear();
                lb_en.Items.Clear();

                Vokabeltrainer.vokabeln_deutsch.Clear();
                Vokabeltrainer.vokabeln_englisch.Clear();

                StreamReader sr = new StreamReader(ofd.FileName);
                
                fileTemp.Clear();
                while(!sr.EndOfStream)
                {
                    fileTemp.Add(sr.ReadLine());
                }

                for(int i = 0; i < fileTemp.Count(); i++)
                {
                    //the words in the even lines are german
                    if(i % 2 == 0)
                    {
                        lb_de.Items.Add(fileTemp[i]);
                        Vokabeltrainer.vokabeln_deutsch.Add(fileTemp[i]);
                        Console.WriteLine(fileTemp[i]);
                    }
                    //ther words in the odd lines are english
                    else if(i % 2 != 0)
                    {
                        lb_en.Items.Add(fileTemp[i]);
                        Vokabeltrainer.vokabeln_englisch.Add(fileTemp[i]);
                        Console.WriteLine(fileTemp[i]);
                    }
                }
                Console.WriteLine("Datei erfolgreich gelesen!");
            }
        }

        //save words as vkbl file
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Vokabeldatei(*.vkbl)|*.vkbl";
            sfd.Title = "Vokabeldatei speichern";
            sfd.RestoreDirectory = true;
            sfd.ShowDialog();

            if (sfd.FileName != "" && sfd.ShowDialog() == DialogResult.OK)
            {
                Stream fs = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(fs);

                if (Vokabeltrainer.vokabeln_deutsch == null || Vokabeltrainer.vokabeln_englisch == null)
                {
                    MessageBox.Show("Gib zuerst Vokabeln in die Liste ein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
                    {
                        sw.Write(Vokabeltrainer.vokabeln_deutsch[i] + "\r\n" + Vokabeltrainer.vokabeln_englisch[i] + "\r\n");
                    }
                }

                sw.Close();
                fs.Close();

            }
        }

        #endregion


        #region addwords

        //add word to list
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_de.Text) || string.IsNullOrWhiteSpace(txt_en.Text))
            {
                MessageBox.Show("Deutsches und Englisches Wort eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Add items to listboxes and lists
                    lb_de.Items.Add(txt_de.Text);
                    lb_en.Items.Add(txt_en.Text);
                    Vokabeltrainer.vokabeln_deutsch.Add(txt_de.Text);
                    Vokabeltrainer.vokabeln_englisch.Add(txt_en.Text);
                    Console.WriteLine(txt_de.Text + " & " + txt_en.Text + " wurden hinzugefügt.");
                    //Clear textboxes
                    txt_de.Clear();
                    txt_en.Clear();

                    txt_de.Focus();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        #endregion


        #region usability
        //usability optimizations
        private void txt_en_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btn_add.PerformClick();
              
            }
        }

        private void txt_de_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_en.Focus();

            }
        }
        #endregion


        #region delete
        //delete list
        private void btn_del_Click(object sender, EventArgs e)
        {
            lb_de.Items.Clear();
            lb_en.Items.Clear();
            Vokabeltrainer.vokabeln_englisch.Clear();
            Vokabeltrainer.vokabeln_deutsch.Clear();
        }

        //delete last wordpair
        private void btn_delLast_Click(object sender, EventArgs e)
        {
            //check if list is empty
            if (Vokabeltrainer.vokabeln_deutsch.Count() != 0)
            {
                //remove last item
                int lastItem = Vokabeltrainer.vokabeln_deutsch.Count() - 1;
                Console.WriteLine(Vokabeltrainer.vokabeln_deutsch[lastItem] + " & " + Vokabeltrainer.vokabeln_englisch[lastItem] + " werden gelöscht!");
                Vokabeltrainer.vokabeln_deutsch.RemoveAt(lastItem);
                Vokabeltrainer.vokabeln_englisch.RemoveAt(lastItem);

                lb_de.Items.RemoveAt(lastItem);
                lb_en.Items.RemoveAt(lastItem);
            }
            else
            {
                MessageBox.Show("Liste ist bereits leer!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        //get back to menu
        private void btn_done_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Englisch - Deutsch");
            for (int i = 0; i < Vokabeltrainer.vokabeln_deutsch.Count(); i++)
            {
                Console.WriteLine(Vokabeltrainer.vokabeln_deutsch[i] + " - " + Vokabeltrainer.vokabeln_englisch[i]);
            }
            Vokabeltrainer vt = new Vokabeltrainer();
            vt.Show();
            this.Close();
        }

        private void Vokabelliste_Load(object sender, EventArgs e)
        {

        }
    }
}
