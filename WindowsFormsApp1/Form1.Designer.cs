namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_mainheader = new System.Windows.Forms.Panel();
            this.label_header = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_mainheader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_mainheader
            // 
            this.panel_mainheader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_mainheader.BackColor = System.Drawing.Color.Bisque;
            this.panel_mainheader.Controls.Add(this.label_header);
            this.panel_mainheader.Location = new System.Drawing.Point(12, 12);
            this.panel_mainheader.Name = "panel_mainheader";
            this.panel_mainheader.Size = new System.Drawing.Size(1450, 161);
            this.panel_mainheader.TabIndex = 0;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_header.Location = new System.Drawing.Point(6, 11);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(389, 47);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "DATA OF THE WANTED";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Wheat;
            this.flowLayoutPanel1.Controls.Add(this.button_add);
            this.flowLayoutPanel1.Controls.Add(this.button_update);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView_main);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 179);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1450, 460);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.LightCoral;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(3, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(110, 37);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "ADD NEW";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Tomato;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_update.Location = new System.Drawing.Point(119, 3);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(104, 37);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.AllowUserToDeleteRows = false;
            this.dataGridView_main.AllowUserToResizeColumns = false;
            this.dataGridView_main.AllowUserToResizeRows = false;
            this.dataGridView_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_main.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.button_delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_main.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_main.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_main.Location = new System.Drawing.Point(3, 46);
            this.dataGridView_main.MultiSelect = false;
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.ReadOnly = true;
            this.dataGridView_main.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_main.Size = new System.Drawing.Size(1430, 383);
            this.dataGridView_main.TabIndex = 2;
            this.dataGridView_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_main_CellContentClick);
            // 
            // button_delete
            // 
            this.button_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.button_delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.button_delete.FillWeight = 60F;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.HeaderText = "";
            this.button_delete.Name = "button_delete";
            this.button_delete.ReadOnly = true;
            this.button_delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.button_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseColumnTextForButtonValue = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 651);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_mainheader);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_mainheader.ResumeLayout(false);
            this.panel_mainheader.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mainheader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewButtonColumn button_delete;
        private System.Windows.Forms.Button button_update;
        public System.Windows.Forms.DataGridView dataGridView_main;
    }
}

