namespace BMI_Overlay
{
    partial class frm_bmi
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
            this.tbx_groeße = new System.Windows.Forms.TextBox();
            this.tbx_gewicht = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_bmi = new System.Windows.Forms.Button();
            this.tbx_bmi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_tabelle = new System.Windows.Forms.Button();
            this.dgv_tabelle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelle)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_groeße
            // 
            this.tbx_groeße.Location = new System.Drawing.Point(95, 10);
            this.tbx_groeße.Name = "tbx_groeße";
            this.tbx_groeße.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_groeße.Size = new System.Drawing.Size(147, 20);
            this.tbx_groeße.TabIndex = 3;
            this.tbx_groeße.Text = "Meter";
            this.tbx_groeße.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbx_groeße_MouseClick);
            // 
            // tbx_gewicht
            // 
            this.tbx_gewicht.Location = new System.Drawing.Point(95, 44);
            this.tbx_gewicht.Name = "tbx_gewicht";
            this.tbx_gewicht.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_gewicht.Size = new System.Drawing.Size(147, 20);
            this.tbx_gewicht.TabIndex = 4;
            this.tbx_gewicht.Text = "Kilogramm";
            this.tbx_gewicht.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbx_gewicht_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Größe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gewicht";
            // 
            // btn_bmi
            // 
            this.btn_bmi.Location = new System.Drawing.Point(12, 81);
            this.btn_bmi.Name = "btn_bmi";
            this.btn_bmi.Size = new System.Drawing.Size(230, 23);
            this.btn_bmi.TabIndex = 8;
            this.btn_bmi.Text = "BMI berrechnen";
            this.btn_bmi.UseVisualStyleBackColor = true;
            this.btn_bmi.Click += new System.EventHandler(this.btn_bmi_Click);
            // 
            // tbx_bmi
            // 
            this.tbx_bmi.Location = new System.Drawing.Point(95, 123);
            this.tbx_bmi.Name = "tbx_bmi";
            this.tbx_bmi.Size = new System.Drawing.Size(147, 20);
            this.tbx_bmi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "BMI";
            // 
            // btn_tabelle
            // 
            this.btn_tabelle.Location = new System.Drawing.Point(12, 160);
            this.btn_tabelle.Name = "btn_tabelle";
            this.btn_tabelle.Size = new System.Drawing.Size(230, 23);
            this.btn_tabelle.TabIndex = 11;
            this.btn_tabelle.Text = "BMI Tabelle";
            this.btn_tabelle.UseVisualStyleBackColor = true;
            this.btn_tabelle.Click += new System.EventHandler(this.btn_tabelle_Click);
            // 
            // dgv_tabelle
            // 
            this.dgv_tabelle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tabelle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_tabelle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tabelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabelle.Location = new System.Drawing.Point(12, 189);
            this.dgv_tabelle.Name = "dgv_tabelle";
            this.dgv_tabelle.ReadOnly = true;
            this.dgv_tabelle.Size = new System.Drawing.Size(230, 164);
            this.dgv_tabelle.TabIndex = 12;
            // 
            // frm_bmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 362);
            this.Controls.Add(this.dgv_tabelle);
            this.Controls.Add(this.btn_tabelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_bmi);
            this.Controls.Add(this.btn_bmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_gewicht);
            this.Controls.Add(this.tbx_groeße);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_bmi";
            this.Text = "BMI-Rechner";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_groeße;
        private System.Windows.Forms.TextBox tbx_gewicht;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_bmi;
        private System.Windows.Forms.TextBox tbx_bmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_tabelle;
        private System.Windows.Forms.DataGridView dgv_tabelle;
    }
}

