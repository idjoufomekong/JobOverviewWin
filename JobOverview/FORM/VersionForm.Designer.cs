namespace JobOverview.FORM
{
    partial class VersionForm
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
            this.lblLogiciel = new System.Windows.Forms.Label();
            this.cbLogiciel = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblModule = new System.Windows.Forms.Label();
            this.btnAjoutVersion = new System.Windows.Forms.Button();
            this.btnSupVersion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogiciel
            // 
            this.lblLogiciel.AutoSize = true;
            this.lblLogiciel.Location = new System.Drawing.Point(12, 19);
            this.lblLogiciel.Name = "lblLogiciel";
            this.lblLogiciel.Size = new System.Drawing.Size(43, 13);
            this.lblLogiciel.TabIndex = 0;
            this.lblLogiciel.Text = "Logiciel";
            // 
            // cbLogiciel
            // 
            this.cbLogiciel.FormattingEnabled = true;
            this.cbLogiciel.Location = new System.Drawing.Point(12, 35);
            this.cbLogiciel.Name = "cbLogiciel";
            this.cbLogiciel.Size = new System.Drawing.Size(121, 21);
            this.cbLogiciel.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(227, 203);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(12, 79);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(42, 13);
            this.lblModule.TabIndex = 4;
            this.lblModule.Text = "Module";
            // 
            // btnAjoutVersion
            // 
            this.btnAjoutVersion.Location = new System.Drawing.Point(170, 22);
            this.btnAjoutVersion.Name = "btnAjoutVersion";
            this.btnAjoutVersion.Size = new System.Drawing.Size(29, 23);
            this.btnAjoutVersion.TabIndex = 5;
            this.btnAjoutVersion.Text = "+";
            this.btnAjoutVersion.UseVisualStyleBackColor = true;
            // 
            // btnSupVersion
            // 
            this.btnSupVersion.Location = new System.Drawing.Point(205, 22);
            this.btnSupVersion.Name = "btnSupVersion";
            this.btnSupVersion.Size = new System.Drawing.Size(29, 23);
            this.btnSupVersion.TabIndex = 5;
            this.btnSupVersion.Text = "-";
            this.btnSupVersion.UseVisualStyleBackColor = true;
            // 
            // VersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 306);
            this.Controls.Add(this.btnSupVersion);
            this.Controls.Add(this.btnAjoutVersion);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbLogiciel);
            this.Controls.Add(this.lblLogiciel);
            this.Name = "VersionForm";
            this.Text = "VersionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogiciel;
        private System.Windows.Forms.ComboBox cbLogiciel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Button btnAjoutVersion;
        private System.Windows.Forms.Button btnSupVersion;
    }
}