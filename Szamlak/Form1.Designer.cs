namespace Szamlak
{
    partial class Form1
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
            this.listBox1_adatok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2_nyitas = new System.Windows.Forms.Label();
            this.label2_egyenleg = new System.Windows.Forms.Label();
            this.label2_nev = new System.Windows.Forms.Label();
            this.label2_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_be = new System.Windows.Forms.Button();
            this.button1_modosit = new System.Windows.Forms.Button();
            this.button1_torol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1_adatok
            // 
            this.listBox1_adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1_adatok.FormattingEnabled = true;
            this.listBox1_adatok.Location = new System.Drawing.Point(0, 0);
            this.listBox1_adatok.Name = "listBox1_adatok";
            this.listBox1_adatok.Size = new System.Drawing.Size(179, 454);
            this.listBox1_adatok.TabIndex = 0;
            this.listBox1_adatok.SelectedIndexChanged += new System.EventHandler(this.listBox1_adatok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1_torol);
            this.groupBox1.Controls.Add(this.button1_modosit);
            this.groupBox1.Controls.Add(this.button1_be);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2_nyitas);
            this.groupBox1.Controls.Add(this.label2_egyenleg);
            this.groupBox1.Controls.Add(this.label2_nev);
            this.groupBox1.Controls.Add(this.label2_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(179, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 454);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2_nyitas
            // 
            this.label2_nyitas.AutoSize = true;
            this.label2_nyitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2_nyitas.Location = new System.Drawing.Point(86, 209);
            this.label2_nyitas.Name = "label2_nyitas";
            this.label2_nyitas.Size = new System.Drawing.Size(48, 16);
            this.label2_nyitas.TabIndex = 4;
            this.label2_nyitas.Text = "Nyitás:";
            // 
            // label2_egyenleg
            // 
            this.label2_egyenleg.AutoSize = true;
            this.label2_egyenleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2_egyenleg.Location = new System.Drawing.Point(66, 166);
            this.label2_egyenleg.Name = "label2_egyenleg";
            this.label2_egyenleg.Size = new System.Drawing.Size(68, 16);
            this.label2_egyenleg.TabIndex = 3;
            this.label2_egyenleg.Text = "Egyenleg:";
            // 
            // label2_nev
            // 
            this.label2_nev.AutoSize = true;
            this.label2_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2_nev.Location = new System.Drawing.Point(23, 121);
            this.label2_nev.Name = "label2_nev";
            this.label2_nev.Size = new System.Drawing.Size(111, 16);
            this.label2_nev.TabIndex = 2;
            this.label2_nev.Text = "Tulajdonos neve:";
            // 
            // label2_id
            // 
            this.label2_id.AutoSize = true;
            this.label2_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2_id.Location = new System.Drawing.Point(111, 80);
            this.label2_id.Name = "label2_id";
            this.label2_id.Size = new System.Drawing.Size(23, 16);
            this.label2_id.TabIndex = 1;
            this.label2_id.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Számla adatai:";
            // 
            // button1_be
            // 
            this.button1_be.Location = new System.Drawing.Point(193, 272);
            this.button1_be.Name = "button1_be";
            this.button1_be.Size = new System.Drawing.Size(112, 23);
            this.button1_be.TabIndex = 9;
            this.button1_be.Text = "BE";
            this.button1_be.UseVisualStyleBackColor = true;
            this.button1_be.Click += new System.EventHandler(this.button1_be_Click);
            // 
            // button1_modosit
            // 
            this.button1_modosit.Location = new System.Drawing.Point(193, 316);
            this.button1_modosit.Name = "button1_modosit";
            this.button1_modosit.Size = new System.Drawing.Size(112, 23);
            this.button1_modosit.TabIndex = 10;
            this.button1_modosit.Text = "Módosít";
            this.button1_modosit.UseVisualStyleBackColor = true;
            this.button1_modosit.Click += new System.EventHandler(this.button1_modosit_Click);
            // 
            // button1_torol
            // 
            this.button1_torol.Location = new System.Drawing.Point(193, 365);
            this.button1_torol.Name = "button1_torol";
            this.button1_torol.Size = new System.Drawing.Size(112, 23);
            this.button1_torol.TabIndex = 11;
            this.button1_torol.Text = "Töröl";
            this.button1_torol.UseVisualStyleBackColor = true;
            this.button1_torol.Click += new System.EventHandler(this.button1_torol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1_adatok);
            this.Name = "Form1";
            this.Text = "Számlák";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1_adatok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_id;
        private System.Windows.Forms.Label label2_nev;
        private System.Windows.Forms.Label label2_egyenleg;
        private System.Windows.Forms.Label label2_nyitas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_be;
        private System.Windows.Forms.Button button1_modosit;
        private System.Windows.Forms.Button button1_torol;
    }
}

