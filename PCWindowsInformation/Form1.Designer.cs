namespace PCWindowsInformation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetInformation = new System.Windows.Forms.Button();
            this.dgwInformation = new System.Windows.Forms.DataGridView();
            this.cmbManagementClsses = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetInformation
            // 
            this.btnGetInformation.Location = new System.Drawing.Point(426, 28);
            this.btnGetInformation.Name = "btnGetInformation";
            this.btnGetInformation.Size = new System.Drawing.Size(163, 29);
            this.btnGetInformation.TabIndex = 0;
            this.btnGetInformation.Text = "Get Pc Information";
            this.btnGetInformation.UseVisualStyleBackColor = true;
            this.btnGetInformation.Click += new System.EventHandler(this.btnGetInformation_Click);
            // 
            // dgwInformation
            // 
            this.dgwInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInformation.Location = new System.Drawing.Point(81, 111);
            this.dgwInformation.Name = "dgwInformation";
            this.dgwInformation.RowHeadersWidth = 51;
            this.dgwInformation.RowTemplate.Height = 29;
            this.dgwInformation.Size = new System.Drawing.Size(697, 285);
            this.dgwInformation.TabIndex = 1;
            // 
            // cmbManagementClsses
            // 
            this.cmbManagementClsses.FormattingEnabled = true;
            this.cmbManagementClsses.Location = new System.Drawing.Point(81, 28);
            this.cmbManagementClsses.Name = "cmbManagementClsses";
            this.cmbManagementClsses.Size = new System.Drawing.Size(305, 28);
            this.cmbManagementClsses.TabIndex = 2;
            this.cmbManagementClsses.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 482);
            this.Controls.Add(this.cmbManagementClsses);
            this.Controls.Add(this.dgwInformation);
            this.Controls.Add(this.btnGetInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGetInformation;
        private DataGridView dgwInformation;
        private ComboBox cmbManagementClsses;
    }
}