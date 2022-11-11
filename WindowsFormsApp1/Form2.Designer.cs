namespace WindowsFormsApp1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_form2_header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_new_add = new System.Windows.Forms.Button();
            this.textBox_sehir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_adres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_vergidairesi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_vno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cariadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label_form2_header);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 129);
            this.panel1.TabIndex = 0;
            // 
            // label_form2_header
            // 
            this.label_form2_header.AutoSize = true;
            this.label_form2_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_form2_header.Location = new System.Drawing.Point(34, 29);
            this.label_form2_header.Name = "label_form2_header";
            this.label_form2_header.Size = new System.Drawing.Size(323, 37);
            this.label_form2_header.TabIndex = 0;
            this.label_form2_header.Text = "ADDING NEW DATA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.button_new_add);
            this.panel2.Controls.Add(this.textBox_sehir);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox_telefon);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_adres);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_vergidairesi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_vno);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_cariadi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 512);
            this.panel2.TabIndex = 0;
            // 
            // button_new_add
            // 
            this.button_new_add.BackColor = System.Drawing.Color.Goldenrod;
            this.button_new_add.Location = new System.Drawing.Point(321, 438);
            this.button_new_add.Name = "button_new_add";
            this.button_new_add.Size = new System.Drawing.Size(129, 33);
            this.button_new_add.TabIndex = 13;
            this.button_new_add.Text = "NEW ADD";
            this.button_new_add.UseVisualStyleBackColor = false;
            this.button_new_add.Click += new System.EventHandler(this.button_new_add_Click);
            // 
            // textBox_sehir
            // 
            this.textBox_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sehir.Location = new System.Drawing.Point(41, 438);
            this.textBox_sehir.Name = "textBox_sehir";
            this.textBox_sehir.Size = new System.Drawing.Size(244, 29);
            this.textBox_sehir.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "sehir";
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_telefon.Location = new System.Drawing.Point(41, 358);
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(244, 29);
            this.textBox_telefon.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "telefon";
            // 
            // textBox_adres
            // 
            this.textBox_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_adres.Location = new System.Drawing.Point(41, 280);
            this.textBox_adres.Name = "textBox_adres";
            this.textBox_adres.Size = new System.Drawing.Size(244, 29);
            this.textBox_adres.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "adres";
            // 
            // textBox_vergidairesi
            // 
            this.textBox_vergidairesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_vergidairesi.Location = new System.Drawing.Point(41, 202);
            this.textBox_vergidairesi.Name = "textBox_vergidairesi";
            this.textBox_vergidairesi.Size = new System.Drawing.Size(244, 29);
            this.textBox_vergidairesi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "vergidairesi";
            // 
            // textBox_vno
            // 
            this.textBox_vno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_vno.Location = new System.Drawing.Point(41, 125);
            this.textBox_vno.Name = "textBox_vno";
            this.textBox_vno.Size = new System.Drawing.Size(244, 29);
            this.textBox_vno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "vno";
            // 
            // textBox_cariadi
            // 
            this.textBox_cariadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_cariadi.Location = new System.Drawing.Point(41, 41);
            this.textBox_cariadi.Name = "textBox_cariadi";
            this.textBox_cariadi.Size = new System.Drawing.Size(244, 29);
            this.textBox_cariadi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "cariadi";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_form2_header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_sehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_adres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_vergidairesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_vno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cariadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_new_add;
    }
}