namespace Vokabeltrainer
{
    partial class Auswertung
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
            this.lbl_finish = new System.Windows.Forms.Label();
            this.lbl_words = new System.Windows.Forms.Label();
            this.btn_again = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_gesamt = new System.Windows.Forms.Label();
            this.lbl_total_errors = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_word1 = new System.Windows.Forms.Label();
            this.lbl_word2 = new System.Windows.Forms.Label();
            this.lbl_word3 = new System.Windows.Forms.Label();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_num3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_errors = new System.Windows.Forms.PictureBox();
            this.pb_bottom = new System.Windows.Forms.PictureBox();
            this.btn_savestats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bottom)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_finish
            // 
            this.lbl_finish.AutoSize = true;
            this.lbl_finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lbl_finish.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finish.ForeColor = System.Drawing.Color.White;
            this.lbl_finish.Location = new System.Drawing.Point(63, 23);
            this.lbl_finish.Name = "lbl_finish";
            this.lbl_finish.Size = new System.Drawing.Size(230, 22);
            this.lbl_finish.TabIndex = 0;
            this.lbl_finish.Text = "Training abgeschlossen";
            // 
            // lbl_words
            // 
            this.lbl_words.AutoSize = true;
            this.lbl_words.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_words.Location = new System.Drawing.Point(14, 80);
            this.lbl_words.Name = "lbl_words";
            this.lbl_words.Size = new System.Drawing.Size(42, 14);
            this.lbl_words.TabIndex = 1;
            this.lbl_words.Text = "words";
            // 
            // btn_again
            // 
            this.btn_again.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_again.FlatAppearance.BorderSize = 0;
            this.btn_again.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_again.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_again.ForeColor = System.Drawing.Color.White;
            this.btn_again.Location = new System.Drawing.Point(12, 333);
            this.btn_again.Name = "btn_again";
            this.btn_again.Size = new System.Drawing.Size(98, 25);
            this.btn_again.TabIndex = 2;
            this.btn_again.Text = "Neustart";
            this.btn_again.UseVisualStyleBackColor = false;
            this.btn_again.Click += new System.EventHandler(this.btn_again_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(237, 333);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(101, 25);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(14, 112);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(35, 14);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "time";
            // 
            // lbl_gesamt
            // 
            this.lbl_gesamt.AutoSize = true;
            this.lbl_gesamt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.lbl_gesamt.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gesamt.ForeColor = System.Drawing.Color.White;
            this.lbl_gesamt.Location = new System.Drawing.Point(9, 153);
            this.lbl_gesamt.Name = "lbl_gesamt";
            this.lbl_gesamt.Size = new System.Drawing.Size(105, 14);
            this.lbl_gesamt.TabIndex = 5;
            this.lbl_gesamt.Text = "Fehler gesamt:";
            // 
            // lbl_total_errors
            // 
            this.lbl_total_errors.AutoSize = true;
            this.lbl_total_errors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.lbl_total_errors.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_errors.ForeColor = System.Drawing.Color.White;
            this.lbl_total_errors.Location = new System.Drawing.Point(113, 153);
            this.lbl_total_errors.Name = "lbl_total_errors";
            this.lbl_total_errors.Size = new System.Drawing.Size(14, 14);
            this.lbl_total_errors.TabIndex = 6;
            this.lbl_total_errors.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Meisten Fehler bei:\r\n";
            // 
            // lbl_word1
            // 
            this.lbl_word1.AutoSize = true;
            this.lbl_word1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_word1.Location = new System.Drawing.Point(105, 222);
            this.lbl_word1.Name = "lbl_word1";
            this.lbl_word1.Size = new System.Drawing.Size(43, 13);
            this.lbl_word1.TabIndex = 8;
            this.lbl_word1.Text = "label2";
            // 
            // lbl_word2
            // 
            this.lbl_word2.AutoSize = true;
            this.lbl_word2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_word2.Location = new System.Drawing.Point(105, 248);
            this.lbl_word2.Name = "lbl_word2";
            this.lbl_word2.Size = new System.Drawing.Size(43, 13);
            this.lbl_word2.TabIndex = 9;
            this.lbl_word2.Text = "label2";
            // 
            // lbl_word3
            // 
            this.lbl_word3.AutoSize = true;
            this.lbl_word3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_word3.Location = new System.Drawing.Point(105, 273);
            this.lbl_word3.Name = "lbl_word3";
            this.lbl_word3.Size = new System.Drawing.Size(43, 13);
            this.lbl_word3.TabIndex = 10;
            this.lbl_word3.Text = "label2";
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num1.Location = new System.Drawing.Point(251, 222);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(13, 13);
            this.lbl_num1.TabIndex = 11;
            this.lbl_num1.Text = "0";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num2.Location = new System.Drawing.Point(251, 248);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(13, 13);
            this.lbl_num2.TabIndex = 12;
            this.lbl_num2.Text = "0";
            // 
            // lbl_num3
            // 
            this.lbl_num3.AutoSize = true;
            this.lbl_num3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num3.Location = new System.Drawing.Point(251, 273);
            this.lbl_num3.Name = "lbl_num3";
            this.lbl_num3.Size = new System.Drawing.Size(13, 13);
            this.lbl_num3.TabIndex = 13;
            this.lbl_num3.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 37);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pb_errors
            // 
            this.pb_errors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.pb_errors.Location = new System.Drawing.Point(1, 147);
            this.pb_errors.Name = "pb_errors";
            this.pb_errors.Size = new System.Drawing.Size(400, 28);
            this.pb_errors.TabIndex = 21;
            this.pb_errors.TabStop = false;
            // 
            // pb_bottom
            // 
            this.pb_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pb_bottom.Location = new System.Drawing.Point(1, 329);
            this.pb_bottom.Name = "pb_bottom";
            this.pb_bottom.Size = new System.Drawing.Size(353, 45);
            this.pb_bottom.TabIndex = 22;
            this.pb_bottom.TabStop = false;
            // 
            // btn_savestats
            // 
            this.btn_savestats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_savestats.FlatAppearance.BorderSize = 0;
            this.btn_savestats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savestats.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savestats.ForeColor = System.Drawing.Color.White;
            this.btn_savestats.Location = new System.Drawing.Point(116, 333);
            this.btn_savestats.Name = "btn_savestats";
            this.btn_savestats.Size = new System.Drawing.Size(115, 25);
            this.btn_savestats.TabIndex = 23;
            this.btn_savestats.Text = "Speichern";
            this.btn_savestats.UseVisualStyleBackColor = false;
            this.btn_savestats.Click += new System.EventHandler(this.btn_savestats_Click);
            // 
            // Auswertung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 363);
            this.Controls.Add(this.btn_savestats);
            this.Controls.Add(this.lbl_num3);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.lbl_word3);
            this.Controls.Add(this.lbl_word2);
            this.Controls.Add(this.lbl_word1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_total_errors);
            this.Controls.Add(this.lbl_gesamt);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_again);
            this.Controls.Add(this.lbl_words);
            this.Controls.Add(this.lbl_finish);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_errors);
            this.Controls.Add(this.pb_bottom);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Auswertung";
            this.ShowIcon = false;
            this.Text = "Auswertung";
            this.Load += new System.EventHandler(this.Auswertung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_errors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_finish;
        private System.Windows.Forms.Label lbl_words;
        private System.Windows.Forms.Button btn_again;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_gesamt;
        private System.Windows.Forms.Label lbl_total_errors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_word1;
        private System.Windows.Forms.Label lbl_word2;
        private System.Windows.Forms.Label lbl_word3;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_num3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_errors;
        private System.Windows.Forms.PictureBox pb_bottom;
        private System.Windows.Forms.Button btn_savestats;
    }
}