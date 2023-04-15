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
            btnGetInformation = new Button();
            dgwInformation = new DataGridView();
            colProperty = new DataGridViewTextBoxColumn();
            ColValue = new DataGridViewTextBoxColumn();
            cmbManagementClsses = new ComboBox();
            label1 = new Label();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwInformation).BeginInit();
            SuspendLayout();
            // 
            // btnGetInformation
            // 
            btnGetInformation.Location = new Point(70, 66);
            btnGetInformation.Margin = new Padding(3, 2, 3, 2);
            btnGetInformation.Name = "btnGetInformation";
            btnGetInformation.Size = new Size(209, 23);
            btnGetInformation.TabIndex = 0;
            btnGetInformation.Text = "Get Hardware Information";
            btnGetInformation.UseVisualStyleBackColor = true;
            btnGetInformation.Click += btnGetInformation_Click;
            // 
            // dgwInformation
            // 
            dgwInformation.AllowUserToAddRows = false;
            dgwInformation.AllowUserToDeleteRows = false;
            dgwInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwInformation.Columns.AddRange(new DataGridViewColumn[] { colProperty, ColValue });
            dgwInformation.Location = new Point(12, 101);
            dgwInformation.Margin = new Padding(3, 2, 3, 2);
            dgwInformation.Name = "dgwInformation";
            dgwInformation.RowHeadersWidth = 51;
            dgwInformation.RowTemplate.Height = 29;
            dgwInformation.Size = new Size(610, 214);
            dgwInformation.TabIndex = 1;
            // 
            // colProperty
            // 
            colProperty.HeaderText = "Property";
            colProperty.MinimumWidth = 6;
            colProperty.Name = "colProperty";
            // 
            // ColValue
            // 
            ColValue.HeaderText = "Value";
            ColValue.MinimumWidth = 6;
            ColValue.Name = "ColValue";
            // 
            // cmbManagementClsses
            // 
            cmbManagementClsses.FormattingEnabled = true;
            cmbManagementClsses.Location = new Point(12, 39);
            cmbManagementClsses.Margin = new Padding(3, 2, 3, 2);
            cmbManagementClsses.Name = "cmbManagementClsses";
            cmbManagementClsses.Size = new Size(267, 23);
            cmbManagementClsses.TabIndex = 2;
            cmbManagementClsses.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "WMI Classes";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(293, 70);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 325);
            Controls.Add(lblMessage);
            Controls.Add(label1);
            Controls.Add(cmbManagementClsses);
            Controls.Add(dgwInformation);
            Controls.Add(btnGetInformation);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwInformation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetInformation;
        private DataGridView dgwInformation;
        private ComboBox cmbManagementClsses;
        private DataGridViewTextBoxColumn colProperty;
        private DataGridViewTextBoxColumn ColValue;
        private Label label1;
        private Label lblMessage;
    }
}