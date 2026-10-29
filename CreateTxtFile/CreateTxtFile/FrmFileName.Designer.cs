namespace CreateTxtFile
{
    partial class FrmFileName
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
            txtFileName = new TextBox();
            btnOkay = new Button();
            lblEnterFileName = new Label();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(35, 52);
            txtFileName.Multiline = true;
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(280, 35);
            txtFileName.TabIndex = 0;
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(135, 109);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(80, 25);
            btnOkay.TabIndex = 1;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // lblEnterFileName
            // 
            lblEnterFileName.AutoSize = true;
            lblEnterFileName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterFileName.Location = new Point(28, 12);
            lblEnterFileName.Name = "lblEnterFileName";
            lblEnterFileName.Size = new Size(145, 25);
            lblEnterFileName.TabIndex = 2;
            lblEnterFileName.Text = "Enter File Name";
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 150);
            Controls.Add(lblEnterFileName);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Name = "FrmFileName";
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFileName;
        private Button btnOkay;
        private Label lblEnterFileName;
    }
}