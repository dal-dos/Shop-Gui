using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool CheckForNumeric()
        {
            errorLbl.Text = "";
            bool error = false;
            double partsCost;
            double laborTime;

            if (!(double.TryParse(partsTxtBx.Text.ToString().Trim(), out partsCost)) && !(double.TryParse(partsTxtBx.Text.ToString().Trim(), out partsCost)))
            {
                errorLbl.Text = "Parts NOT numeric - $0\nassumed\nLabor NOT numeric - 0 hrs\nassumed";
                error = true;
                laborSummaryTxtBx.Text = "$" + "0.00"; //Labor
                laborSummaryTxtBx.BackColor = Color.Red;
                laborSummaryTxtBx.ForeColor = Color.Yellow;
            }
            else
            {
                if (!double.TryParse(partsTxtBx.Text.ToString().Trim(), out partsCost))
                {
                    errorLbl.Text = "Parts NOT numeric - $0\nassumed";
                    error = true;
                }

                if (!double.TryParse(laborTxtBx.Text.ToString().Trim(), out laborTime))
                {
                    errorLbl.Text = "Labor NOT numeric - 0 hrs\nassumed";
                    error = true;
                    laborSummaryTxtBx.Text = "$" + "0.00"; //Labor
                    laborSummaryTxtBx.BackColor = Color.Red;
                    laborSummaryTxtBx.ForeColor = Color.Yellow;
                }
            }

            return error;
        }

        private double FlushesCost()
        {
            double flushes = 0;
            if (radiatorChkBx.Checked && transmissionChkBx.Checked)
                flushes = 30.00 + 80.00;
            else
            {
                if (radiatorChkBx.Checked)
                    flushes = 30.00;
                if (transmissionChkBx.Checked)
                    flushes = 80.00;
            }

            return flushes;
        }

        private double OilAndLubeCost()
        {
            double oilLubeCost = 0;
            if (oilChkBx.Checked && lubeChkBx.Checked)
                oilLubeCost = 28.50 + 19.50;
            else
            {
                if (oilChkBx.Checked)
                    oilLubeCost = 28.50;
                if (lubeChkBx.Checked)
                    oilLubeCost = 19.50;
            }

            return oilLubeCost;
        }

        private double Misc()
        {
            double misc = 0;
            if (miscLstBx.SelectedIndex == 0)
                misc = 15.00;
            if (miscLstBx.SelectedIndex == 1)
                misc = 90.50;
            if (miscLstBx.SelectedIndex == 2)
                misc = 28.90;
            if (miscLstBx.SelectedIndex == 3)
            {
                misc = (tireLstBx.SelectedIndex + 1) * 87.75;
            }
            return misc;
        }

        private void AddTires(int tires)
        {
            for (int idx = 1; idx <= tires; idx++)
                tireLstBx.Items.Add(idx.ToString() + " tire(s)");
        }

        private void ClearMisc()
        {
            tireLstBx.Visible = false;
            miscLstBx.SelectedIndex = -1;
        }

        private void CalculateGST(out double gst, double parts)
        {
            gst = 0.05 * parts; //Tax
            
        }

        private void CalculatePST(out double pst, double parts)
        {
            pst = 0.07 * parts;
        }

        private void TotalCharges(out double total, double labor, double flushes, double oilAndLube, double misc)
        {
            total = labor + flushes + oilAndLube + misc;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            bool error = CheckForNumeric();
            double gst= 0;
            double pst= 0;
            double miscCost = Misc();
            double flushesCost = FlushesCost();
            double oilAndLubeCost = OilAndLubeCost();
            double laborTime;
            double laborCost;
            double partsCost;
            double serviceTotal;
            double total;


            double.TryParse(partsTxtBx.Text.ToString().Trim(), out partsCost); //Labor
            double.TryParse(laborTxtBx.Text.ToString().Trim(), out laborTime);
            laborCost = laborTime * 21.80;
            laborSummaryTxtBx.Text = "$" + laborCost.ToString("n2");
            laborSummaryTxtBx.BackColor = Color.Blue;
            laborSummaryTxtBx.ForeColor = Color.White;

            TotalCharges(out serviceTotal, laborCost, flushesCost, oilAndLubeCost, miscCost);//Service and Labor

            serviceTxtBx.Text = "$" + serviceTotal.ToString("n2");

            partsSummaryTxtBx.Text = "$" + partsCost.ToString("n2"); //Parts

            CalculateGST(out gst, partsCost);
            CalculatePST(out pst, partsCost);
            gstTxtBx.Text = "$" + gst.ToString("n2");
            pstTxtBx.Text = "$" + pst.ToString("n2");


            total = serviceTotal + partsCost + gst + pst;//Final
            totalTxtBx.Text = "$" + total.ToString("n2");


        }

        private void miscLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(miscLstBx.SelectedIndex == 3)
            {
                AddTires(7);
                tireLstBx.Visible = true;
                tireLstBx.SelectedIndex = 0;
            }
            
        }

        private void clearMiscBtn_Click(object sender, EventArgs e)
        {
            ClearMisc();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            lubeChkBx.Checked = false;
            oilChkBx.Checked = false;
            transmissionChkBx.Checked = false;
            radiatorChkBx.Checked = false;
            ClearMisc();
            partsTxtBx.Text = "";
            laborTxtBx.Text = "";
            serviceTxtBx.Text = "";
            partsSummaryTxtBx.Text = "";
            errorLbl.Text = "";
            gstTxtBx.Text = "";
            pstTxtBx.Text = "";
            totalTxtBx.Text = "";
            laborSummaryTxtBx.Text = "";
            laborSummaryTxtBx.BackColor = Color.White;
            laborSummaryTxtBx.ForeColor = Color.Black;
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
