namespace Vokabeltrainer
{
    partial class Vokabelliste
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
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_de = new System.Windows.Forms.TextBox();
            this.txt_en = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_de = new System.Windows.Forms.ListBox();
            this.lb_en = new System.Windows.Forms.ListBox();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_delLast = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.lbl_del = new System.Windows.Forms.Label();
            this.pb_bottom = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_open.FlatAppearance.BorderSize = 0;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.ForeColor = System.Drawing.Color.White;
            this.btn_open.Location = new System.Drawing.Point(3, 362);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(70, 23);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "Öffnen";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(79, 362);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(155, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Als Datei speichern";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_de
            // 
            this.txt_de.Location = new System.Drawing.Point(50, 22);
            this.txt_de.Name = "txt_de";
            this.txt_de.Size = new System.Drawing.Size(100, 20);
            this.txt_de.TabIndex = 7;
            this.txt_de.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_de_KeyDown);
            // 
            // txt_en
            // 
            this.txt_en.Location = new System.Drawing.Point(200, 22);
            this.txt_en.Name = "txt_en";
            this.txt_en.Size = new System.Drawing.Size(100, 20);
            this.txt_en.TabIndex = 8;
            this.txt_en.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_en_KeyDown);
            // 
            // btn_add
            // 
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(105, 57);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 24);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "+ Hinzufügen";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_de
            // 
            this.lb_de.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_de.FormattingEnabled = true;
            this.lb_de.Location = new System.Drawing.Point(12, 96);
            this.lb_de.Name = "lb_de";
            this.lb_de.Size = new System.Drawing.Size(138, 184);
            this.lb_de.TabIndex = 10;
            // 
            // lb_en
            // 
            this.lb_en.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_en.FormattingEnabled = true;
            this.lb_en.Location = new System.Drawing.Point(162, 96);
            this.lb_en.Name = "lb_en";
            this.lb_en.Size = new System.Drawing.Size(138, 184);
            this.lb_en.TabIndex = 11;
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_done.FlatAppearance.BorderSize = 0;
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(185)))), ((int)(((byte)(1)))));
            this.btn_done.Location = new System.Drawing.Point(240, 362);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(65, 23);
            this.btn_done.TabIndex = 12;
            this.btn_done.Text = "Fertig";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(162, 314);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(108, 24);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "ganze Liste";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_delLast
            // 
            this.btn_delLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.btn_delLast.FlatAppearance.BorderSize = 0;
            this.btn_delLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delLast.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delLast.ForeColor = System.Drawing.Color.White;
            this.btn_delLast.Location = new System.Drawing.Point(35, 314);
            this.btn_delLast.Name = "btn_delLast";
            this.btn_delLast.Size = new System.Drawing.Size(115, 24);
            this.btn_delLast.TabIndex = 14;
            this.btn_delLast.Text = "letzer Eintrag";
            this.btn_delLast.UseVisualStyleBackColor = false;
            this.btn_delLast.Click += new System.EventHandler(this.btn_delLast_Click);
            // 
            // pb1
            // 
            this.pb1.Image = global::Vokabeltrainer.pics.Germany;
            this.pb1.Location = new System.Drawing.Point(12, 15);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(32, 32);
            this.pb1.TabIndex = 16;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::Vokabeltrainer.pics.UK;
            this.pb2.Location = new System.Drawing.Point(162, 15);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(32, 32);
            this.pb2.TabIndex = 17;
            this.pb2.TabStop = false;
            // 
            // lbl_del
            // 
            this.lbl_del.AutoSize = true;
            this.lbl_del.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_del.Location = new System.Drawing.Point(121, 287);
            this.lbl_del.Name = "lbl_del";
            this.lbl_del.Size = new System.Drawing.Size(72, 19);
            this.lbl_del.TabIndex = 18;
            this.lbl_del.Text = "LÖSCHEN";
            // 
            // pb_bottom
            // 
            this.pb_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pb_bottom.Location = new System.Drawing.Point(-2, 353);
            this.pb_bottom.Name = "pb_bottom";
            this.pb_bottom.Size = new System.Drawing.Size(322, 45);
            this.pb_bottom.TabIndex = 19;
            this.pb_bottom.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 30);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Vokabelliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 397);
            this.Controls.Add(this.lbl_del);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btn_delLast);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.lb_en);
            this.Controls.Add(this.lb_de);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_en);
            this.Controls.Add(this.txt_de);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.pb_bottom);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Vokabelliste";
            this.ShowIcon = false;
            this.Text = "Vokabelliste";
            this.Load += new System.EventHandler(this.Vokabelliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_de;
        private System.Windows.Forms.TextBox txt_en;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lb_de;
        private System.Windows.Forms.ListBox lb_en;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_delLast;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label lbl_del;
        private System.Windows.Forms.PictureBox pb_bottom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}