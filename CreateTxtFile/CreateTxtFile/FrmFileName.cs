using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CreateTxtFile
{
    public partial class FrmFileName : Form 
    {
        public static string? SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {

            SetFileName = txtFileName.Text + ".txt";

            MessageBox.Show("Text File Created");
            this.Close();
            
        }
    }
}
