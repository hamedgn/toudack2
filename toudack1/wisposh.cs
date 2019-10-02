using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IronBarCode;
using System;

namespace toudack1
{
    public partial class wisposh : Form
    {
        public wisposh()
        {
            InitializeComponent();

        }

        private void qus_buy_btn_Click(object sender, EventArgs e)
        {
            //visible and enable buy section by click at buy qustion
            prs_code_lable.Visible = true;
            prs_code_lable.Enabled = true;
            prs_code_box.Visible = true;
            prs_code_box.Enabled = true;
            prs_barcode_btn.Visible = true;
            prs_barcode_btn.Enabled = true;
            qus_code_lable.Visible = true;
            qus_code_lable.Enabled = true;
            qus_code_box.Visible = true;
            qus_code_box.Enabled = true;
            qus_barcode_btn.Visible = true;
            qus_barcode_btn.Enabled = true;
            qus_buy_btn_final.Visible = true;
            qus_buy_btn_final.Enabled = true;
            abort_clear_from.Visible = true;
            abort_clear_from.Enabled = true;
            qus_sell_btn.Enabled = false;
        }

        private void qus_sell_btn_Click(object sender, EventArgs e)
        {
            ///visible and enable sell section by click at sell qustion
            prs_code_lable.Visible = true;
            prs_code_lable.Enabled = true;
            prs_code_box.Visible = true;
            prs_code_box.Enabled = true;
            prs_barcode_btn.Visible = true;
            prs_barcode_btn.Enabled = true;
            qus_code_lable.Visible = true;
            qus_code_lable.Enabled = true;
            qus_code_box.Visible = true;
            qus_code_box.Enabled = true;
            qus_barcode_btn.Visible = true;
            qus_barcode_btn.Enabled = true;
            qus_answer_radio_1.Visible = true;
            qus_answer_radio_1.Enabled = true;
            qus_answer_radio_2.Visible = true;
            qus_answer_radio_2.Enabled = true;
            qus_answer_radio_3.Visible = true;
            qus_answer_radio_3.Enabled = true;
            qus_answer_radio_4.Visible = true;
            qus_answer_radio_4.Enabled = true;
            qus_anwser_panel.Visible = true;
            qus_anwser_panel.Enabled = true;
            qus_sell_btn_final.Visible = true;
            qus_sell_btn_final.Enabled = true;
            abort_clear_from.Visible = true;
            abort_clear_from.Enabled = true;
            qus_buy_btn.Enabled = false;
        }

        private void abort_clear_from_Click(object sender, EventArgs e)
        {

            prs_code_lable.Visible = false;
            prs_code_lable.Enabled = false;
            prs_code_box.Visible = false;
            prs_code_box.Enabled = false;
            prs_barcode_btn.Visible = false;
            prs_barcode_btn.Enabled = false;
            qus_code_lable.Visible = false;
            qus_code_lable.Enabled = false;
            qus_code_box.Visible = false;
            qus_code_box.Enabled = false;
            qus_barcode_btn.Visible = false;
            qus_barcode_btn.Enabled = false;
            qus_buy_btn_final.Visible = false;
            qus_answer_radio_1.Visible = false;
            qus_answer_radio_1.Enabled = false;
            qus_answer_radio_2.Visible = false;
            qus_answer_radio_2.Enabled = false;
            qus_answer_radio_3.Visible = false;
            qus_answer_radio_3.Enabled = false;
            qus_answer_radio_4.Visible = false;
            qus_answer_radio_4.Enabled = false;
            qus_anwser_panel.Visible = false;
            qus_anwser_panel.Enabled = false;
            qus_sell_btn_final.Visible = false;
            qus_sell_btn_final.Enabled = false;
            abort_clear_from.Visible = false;
            abort_clear_from.Enabled = false;
            qus_buy_btn.Enabled = true;
            qus_sell_btn.Enabled = true;
        }

        private void prs_barcode_btn_Click(object sender, EventArgs e)
        {
            BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode("GetStarted.png");
            if (Result != null && Result.Text == "https://ironsoftware.com/csharp/barcode/")
            {
                MessageBox.Show("vahid", "vahid");
            }
        }
    }
}
