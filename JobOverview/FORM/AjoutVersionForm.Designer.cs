namespace JobOverview.FORM
{
    partial class AjoutVersionForm
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblNumVersion = new System.Windows.Forms.Label();
            this.lblMillesime = new System.Windows.Forms.Label();
            this.lblDatePrevue = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(29, 110);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(131, 110);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lblNumVersion
            // 
            this.lblNumVersion.AutoSize = true;
            this.lblNumVersion.Location = new System.Drawing.Point(26, 20);
            this.lblNumVersion.Name = "lblNumVersion";
            this.lblNumVersion.Size = new System.Drawing.Size(96, 13);
            this.lblNumVersion.TabIndex = 2;
            this.lblNumVersion.Text = "Numéro de version";
            // 
            // lblMillesime
            // 
            this.lblMillesime.AutoSize = true;
            this.lblMillesime.Location = new System.Drawing.Point(73, 46);
            this.lblMillesime.Name = "lblMillesime";
            this.lblMillesime.Size = new System.Drawing.Size(49, 13);
            this.lblMillesime.TabIndex = 2;
            this.lblMillesime.Text = "Millésime";
            // 
            // lblDatePrevue
            // 
            this.lblDatePrevue.AutoSize = true;
            this.lblDatePrevue.Location = new System.Drawing.Point(13, 74);
            this.lblDatePrevue.Name = "lblDatePrevue";
            this.lblDatePrevue.Size = new System.Drawing.Size(109, 13);
            this.lblDatePrevue.TabIndex = 2;
            this.lblDatePrevue.Text = "Date de sortie prévue";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(131, 43);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(131, 71);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(131, 17);
            this.maskedTextBox3.Mask = "000.00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 5;
            // 
            // AjoutVersionForm
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(248, 149);
            this.ControlBox = false;
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblDatePrevue);
            this.Controls.Add(this.lblMillesime);
            this.Controls.Add(this.lblNumVersion);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Name = "AjoutVersionForm";
            this.Text = "AjoutVersionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblNumVersion;
        private System.Windows.Forms.Label lblMillesime;
        private System.Windows.Forms.Label lblDatePrevue;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
    }
}