namespace Vokabeltrainer
{
    partial class Abfrage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.txt_question = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.lbl_0 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_lvls = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(57, 129);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(164, 20);
            this.txt_answer.TabIndex = 2;
            this.txt_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_answer_KeyDown);
            // 
            // txt_question
            // 
            this.txt_question.Location = new System.Drawing.Point(57, 89);
            this.txt_question.Name = "txt_question";
            this.txt_question.Size = new System.Drawing.Size(164, 20);
            this.txt_question.TabIndex = 3;
            this.txt_question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.Location = new System.Drawing.Point(21, 161);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(200, 33);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Antwort in das untere Feld eingeben";
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.btn_back.Location = new System.Drawing.Point(1, 200);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(69, 23);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Abbruch";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(21, 83);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(32, 32);
            this.pb1.TabIndex = 7;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(21, 123);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(32, 32);
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            // 
            // lbl_0
            // 
            this.lbl_0.AutoSize = true;
            this.lbl_0.ForeColor = System.Drawing.Color.Red;
            this.lbl_0.Location = new System.Drawing.Point(52, 34);
            this.lbl_0.Name = "lbl_0";
            this.lbl_0.Size = new System.Drawing.Size(13, 13);
            this.lbl_0.TabIndex = 9;
            this.lbl_0.Text = "0";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_1.Location = new System.Drawing.Point(91, 34);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(13, 13);
            this.lbl_1.TabIndex = 10;
            this.lbl_1.Text = "0";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.ForeColor = System.Drawing.Color.Orange;
            this.lbl_2.Location = new System.Drawing.Point(130, 34);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(13, 13);
            this.lbl_2.TabIndex = 11;
            this.lbl_2.Text = "0";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.ForeColor = System.Drawing.Color.Green;
            this.lbl_3.Location = new System.Drawing.Point(169, 34);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(13, 13);
            this.lbl_3.TabIndex = 12;
            this.lbl_3.Text = "0";
            // 
            // lbl_lvls
            // 
            this.lbl_lvls.AutoSize = true;
            this.lbl_lvls.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lvls.Location = new System.Drawing.Point(91, 12);
            this.lbl_lvls.Name = "lbl_lvls";
            this.lbl_lvls.Size = new System.Drawing.Size(49, 14);
            this.lbl_lvls.TabIndex = 13;
            this.lbl_lvls.Text = "Stufen";
            // 
            // Abfrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 227);
            this.Controls.Add(this.lbl_lvls);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_0);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txt_question);
            this.Controls.Add(this.txt_answer);
            this.MaximizeBox = false;
            this.Name = "Abfrage";
            this.ShowIcon = false;
            this.Text = "Abfrage";
            this.Load += new System.EventHandler(this.Abfrage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label lbl_0;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_lvls;
    }
}