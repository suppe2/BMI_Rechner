﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Overlay
{
    public partial class frm_bmi : Form
    {
        public frm_bmi()
        {
            InitializeComponent();
            dgv_tabelle.Visible = false;

            dgv_tabelle.ColumnCount = 2;
            dgv_tabelle.Columns[0].Name = "Alter";
            dgv_tabelle.Columns[1].Name = "idealer BMI";
            this.dgv_tabelle.Rows.Add("19-24", "19-24");
            this.dgv_tabelle.Rows.Add("25-34", "20-25");
            this.dgv_tabelle.Rows.Add("35-44", "21-26");
            this.dgv_tabelle.Rows.Add("45-54", "22-27");
            this.dgv_tabelle.Rows.Add("55-64", "23-28");
            this.dgv_tabelle.Rows.Add(">64", "24-29");


        }

        private void btn_tabelle_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = (DataGridViewRow)dgv_tabelle.Rows[0].Clone();
            //row.Cells[0].Value = "Alter";
            //row.Cells[1].Value = "BMI";
            //dgv_tabelle.Rows.Add(row);
            //dgv_tabelle.ColumnCount = 2;
            //dgv_tabelle.Columns[0].Name = "Alter";
            //dgv_tabelle.Columns[1].Name = "idealer BMI";
            //this.dgv_tabelle.Rows.Add("19-24", "19-24");
            //this.dgv_tabelle.Rows.Add("25-34", "20-25");
            //this.dgv_tabelle.Rows.Add("35-44", "21-26");
            //this.dgv_tabelle.Rows.Add("45-54", "22-27");
            //this.dgv_tabelle.Rows.Add("55-64", "23-28");
            //this.dgv_tabelle.Rows.Add(">64", "24-29");
            dgv_tabelle.Visible = true;
        }

        //public double BodyMassIndexBerechnen(double gewicht, int groeßeCm)
        //{
        //    double bmi = gewicht / Math.Pow(groeßeCm, 2);

        //    return bmi;
        //}

        private void btn_bmi_Click(object sender, EventArgs e)
        {
            double gewicht = Convert.ToDouble(tbx_gewicht.Text);
            int groeße = Convert.ToInt32(tbx_groeße.Text);

            double bmi = gewicht / Math.Pow(groeße, 2);

            tbx_bmi.Text = Convert.ToString(bmi);

        }
    }
}
