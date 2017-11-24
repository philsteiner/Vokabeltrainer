namespace Vokabeltrainer
{
    partial class Vokabeltrainer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_vlist = new System.Windows.Forms.Button();
            this.btn_train = new System.Windows.Forms.Button();
            this.lbl_vokabelpaare = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.btn_dark = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_vlist
            // 
            this.btn_vlist.FlatAppearance.BorderSize = 0;
            this.btn_vlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vlist.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vlist.Location = new System.Drawing.Point(15, 27);
            this.btn_vlist.Name = "btn_vlist";
            this.btn_vlist.Size = new System.Drawing.Size(162, 50);
            this.btn_vlist.TabIndex = 0;
            this.btn_vlist.Text = "Vokabelliste";
            this.btn_vlist.UseVisualStyleBackColor = true;
            this.btn_vlist.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_train
            // 
            this.btn_train.FlatAppearance.BorderSize = 0;
            this.btn_train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_train.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_train.Location = new System.Drawing.Point(12, 83);
            this.btn_train.Name = "btn_train";
            this.btn_train.Size = new System.Drawing.Size(110, 50);
            this.btn_train.TabIndex = 1;
            this.btn_train.Text = "Abfrage";
            this.btn_train.UseVisualStyleBackColor = true;
            this.btn_train.Click += new System.EventHandler(this.btn_train_Click);
            // 
            // lbl_vokabelpaare
            // 
            this.lbl_vokabelpaare.AutoSize = true;
            this.lbl_vokabelpaare.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vokabelpaare.Location = new System.Drawing.Point(171, 9);
            this.lbl_vokabelpaare.Name = "lbl_vokabelpaare";
            this.lbl_vokabelpaare.Size = new System.Drawing.Size(98, 15);
            this.lbl_vokabelpaare.TabIndex = 2;
            this.lbl_vokabelpaare.Text = "Vokabelpaare:";
            this.lbl_vokabelpaare.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(275, 9);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(14, 15);
            this.lbl_count.TabIndex = 3;
            this.lbl_count.Text = "0";
            this.lbl_count.Click += new System.EventHandler(this.lbl_count_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.White;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.btn_quit.Location = new System.Drawing.Point(204, 146);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(95, 36);
            this.btn_quit.TabIndex = 4;
            this.btn_quit.Text = "Beenden";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // lbl_theme
            // 
            this.lbl_theme.AutoSize = true;
            this.lbl_theme.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_theme.Location = new System.Drawing.Point(19, 150);
            this.lbl_theme.Name = "lbl_theme";
            this.lbl_theme.Size = new System.Drawing.Size(49, 15);
            this.lbl_theme.TabIndex = 7;
            this.lbl_theme.Text = "Theme:";
            // 
            // btn_dark
            // 
            this.btn_dark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_dark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dark.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dark.Location = new System.Drawing.Point(74, 146);
            this.btn_dark.Name = "btn_dark";
            this.btn_dark.Size = new System.Drawing.Size(25, 25);
            this.btn_dark.TabIndex = 8;
            this.btn_dark.Text = " ";
            this.btn_dark.UseVisualStyleBackColor = false;
            this.btn_dark.Click += new System.EventHandler(this.btn_dark_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(105, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Vokabeltrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_dark);
            this.Controls.Add(this.lbl_theme);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_vokabelpaare);
            this.Controls.Add(this.btn_train);
            this.Controls.Add(this.btn_vlist);
            this.Controls.Add(this.btn_quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Vokabeltrainer";
            this.ShowIcon = false;
            this.Text = "Vokabeltrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_vlist;
        private System.Windows.Forms.Button btn_train;
        private System.Windows.Forms.Label lbl_vokabelpaare;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label lbl_theme;
        private System.Windows.Forms.Button btn_dark;
        private System.Windows.Forms.Button button1;
    }
}

