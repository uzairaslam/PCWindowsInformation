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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGetInformation = new Button();
            dgwInformation = new DataGridView();
            colProperty = new DataGridViewTextBoxColumn();
            ColValue = new DataGridViewTextBoxColumn();
            cmbManagementClsses = new ComboBox();
            label1 = new Label();
            lblMessage = new Label();
            tabCtrlMenu = new TabControl();
            tabPgeOverview = new TabPage();
            tabPageCPU = new TabPage();
            tabPageMotherboard = new TabPage();
            tabPageMemory = new TabPage();
            tabPageGraphics = new TabPage();
            tabPageOther = new TabPage();
            tabsIcons = new ImageList(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblMachine = new Label();
            lblOS = new Label();
            lblMemory = new Label();
            lblProcessor = new Label();
            lblMotherboard = new Label();
            lblVideoCard = new Label();
            lblMonitors = new Label();
            lblHardDisk = new Label();
            lblNetworkCard = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwInformation).BeginInit();
            tabCtrlMenu.SuspendLayout();
            tabPgeOverview.SuspendLayout();
            tabPageOther.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetInformation
            // 
            btnGetInformation.Location = new Point(81, 80);
            btnGetInformation.Name = "btnGetInformation";
            btnGetInformation.Size = new Size(239, 31);
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
            dgwInformation.Location = new Point(15, 127);
            dgwInformation.Name = "dgwInformation";
            dgwInformation.RowHeadersWidth = 51;
            dgwInformation.RowTemplate.Height = 29;
            dgwInformation.Size = new Size(697, 285);
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
            cmbManagementClsses.Location = new Point(15, 44);
            cmbManagementClsses.Name = "cmbManagementClsses";
            cmbManagementClsses.Size = new Size(305, 28);
            cmbManagementClsses.TabIndex = 2;
            cmbManagementClsses.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 3;
            label1.Text = "WMI Classes";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(336, 85);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 4;
            // 
            // tabCtrlMenu
            // 
            tabCtrlMenu.Controls.Add(tabPgeOverview);
            tabCtrlMenu.Controls.Add(tabPageCPU);
            tabCtrlMenu.Controls.Add(tabPageMotherboard);
            tabCtrlMenu.Controls.Add(tabPageMemory);
            tabCtrlMenu.Controls.Add(tabPageGraphics);
            tabCtrlMenu.Controls.Add(tabPageOther);
            tabCtrlMenu.Dock = DockStyle.Fill;
            tabCtrlMenu.ImageList = tabsIcons;
            tabCtrlMenu.Location = new Point(0, 0);
            tabCtrlMenu.Multiline = true;
            tabCtrlMenu.Name = "tabCtrlMenu";
            tabCtrlMenu.SelectedIndex = 0;
            tabCtrlMenu.Size = new Size(815, 498);
            tabCtrlMenu.TabIndex = 5;
            // 
            // tabPgeOverview
            // 
            tabPgeOverview.BackColor = Color.LightSteelBlue;
            tabPgeOverview.Controls.Add(lblNetworkCard);
            tabPgeOverview.Controls.Add(lblHardDisk);
            tabPgeOverview.Controls.Add(lblMonitors);
            tabPgeOverview.Controls.Add(lblVideoCard);
            tabPgeOverview.Controls.Add(lblMotherboard);
            tabPgeOverview.Controls.Add(lblProcessor);
            tabPgeOverview.Controls.Add(lblMemory);
            tabPgeOverview.Controls.Add(lblOS);
            tabPgeOverview.Controls.Add(lblMachine);
            tabPgeOverview.Controls.Add(label10);
            tabPgeOverview.Controls.Add(label9);
            tabPgeOverview.Controls.Add(label8);
            tabPgeOverview.Controls.Add(label7);
            tabPgeOverview.Controls.Add(label6);
            tabPgeOverview.Controls.Add(label5);
            tabPgeOverview.Controls.Add(label4);
            tabPgeOverview.Controls.Add(label3);
            tabPgeOverview.Controls.Add(label2);
            tabPgeOverview.ImageIndex = 0;
            tabPgeOverview.Location = new Point(4, 32);
            tabPgeOverview.Name = "tabPgeOverview";
            tabPgeOverview.Padding = new Padding(3);
            tabPgeOverview.Size = new Size(807, 462);
            tabPgeOverview.TabIndex = 0;
            tabPgeOverview.Text = "Overview";
            // 
            // tabPageCPU
            // 
            tabPageCPU.ImageIndex = 1;
            tabPageCPU.Location = new Point(4, 32);
            tabPageCPU.Name = "tabPageCPU";
            tabPageCPU.Padding = new Padding(3);
            tabPageCPU.Size = new Size(804, 458);
            tabPageCPU.TabIndex = 1;
            tabPageCPU.Text = "CPU";
            tabPageCPU.UseVisualStyleBackColor = true;
            // 
            // tabPageMotherboard
            // 
            tabPageMotherboard.ImageIndex = 2;
            tabPageMotherboard.Location = new Point(4, 32);
            tabPageMotherboard.Name = "tabPageMotherboard";
            tabPageMotherboard.Size = new Size(804, 458);
            tabPageMotherboard.TabIndex = 2;
            tabPageMotherboard.Text = "Motherboard";
            tabPageMotherboard.UseVisualStyleBackColor = true;
            // 
            // tabPageMemory
            // 
            tabPageMemory.ImageIndex = 3;
            tabPageMemory.Location = new Point(4, 32);
            tabPageMemory.Name = "tabPageMemory";
            tabPageMemory.Size = new Size(804, 458);
            tabPageMemory.TabIndex = 3;
            tabPageMemory.Text = "Memory";
            tabPageMemory.UseVisualStyleBackColor = true;
            // 
            // tabPageGraphics
            // 
            tabPageGraphics.ImageIndex = 4;
            tabPageGraphics.Location = new Point(4, 32);
            tabPageGraphics.Name = "tabPageGraphics";
            tabPageGraphics.Size = new Size(804, 458);
            tabPageGraphics.TabIndex = 4;
            tabPageGraphics.Text = "Graphics";
            tabPageGraphics.UseVisualStyleBackColor = true;
            // 
            // tabPageOther
            // 
            tabPageOther.Controls.Add(label1);
            tabPageOther.Controls.Add(lblMessage);
            tabPageOther.Controls.Add(btnGetInformation);
            tabPageOther.Controls.Add(dgwInformation);
            tabPageOther.Controls.Add(cmbManagementClsses);
            tabPageOther.ImageIndex = 5;
            tabPageOther.Location = new Point(4, 32);
            tabPageOther.Name = "tabPageOther";
            tabPageOther.Size = new Size(804, 458);
            tabPageOther.TabIndex = 5;
            tabPageOther.Text = "Other";
            tabPageOther.UseVisualStyleBackColor = true;
            // 
            // tabsIcons
            // 
            tabsIcons.ColorDepth = ColorDepth.Depth8Bit;
            tabsIcons.ImageStream = (ImageListStreamer)resources.GetObject("tabsIcons.ImageStream");
            tabsIcons.TransparentColor = Color.Transparent;
            tabsIcons.Images.SetKeyName(0, "Overview.ico");
            tabsIcons.Images.SetKeyName(1, "CPU.ico");
            tabsIcons.Images.SetKeyName(2, "Motherboard.ico");
            tabsIcons.Images.SetKeyName(3, "memory.ico");
            tabsIcons.Images.SetKeyName(4, "graphics.ico");
            tabsIcons.Images.SetKeyName(5, "other.ico");
            tabsIcons.Images.SetKeyName(6, "memory_16.png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 43);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Machine :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 85);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 0;
            label3.Text = "Operating System :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 131);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 0;
            label4.Text = "Memory :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 173);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 0;
            label5.Text = "Processor :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 215);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 0;
            label6.Text = "Motherboard :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 260);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 0;
            label7.Text = "Video Cards :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 304);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 0;
            label8.Text = "Monitors :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 349);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 0;
            label9.Text = "Hard Disk :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 392);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 0;
            label10.Text = "Network Card:";
            // 
            // lblMachine
            // 
            lblMachine.AutoSize = true;
            lblMachine.Location = new Point(258, 43);
            lblMachine.Name = "lblMachine";
            lblMachine.Size = new Size(58, 20);
            lblMachine.TabIndex = 1;
            lblMachine.Text = "label11";
            // 
            // lblOS
            // 
            lblOS.AutoSize = true;
            lblOS.Location = new Point(258, 85);
            lblOS.Name = "lblOS";
            lblOS.Size = new Size(58, 20);
            lblOS.TabIndex = 1;
            lblOS.Text = "label11";
            // 
            // lblMemory
            // 
            lblMemory.AutoSize = true;
            lblMemory.Location = new Point(258, 131);
            lblMemory.Name = "lblMemory";
            lblMemory.Size = new Size(58, 20);
            lblMemory.TabIndex = 1;
            lblMemory.Text = "label11";
            // 
            // lblProcessor
            // 
            lblProcessor.AutoSize = true;
            lblProcessor.Location = new Point(258, 173);
            lblProcessor.Name = "lblProcessor";
            lblProcessor.Size = new Size(58, 20);
            lblProcessor.TabIndex = 1;
            lblProcessor.Text = "label11";
            // 
            // lblMotherboard
            // 
            lblMotherboard.AutoSize = true;
            lblMotherboard.Location = new Point(258, 215);
            lblMotherboard.Name = "lblMotherboard";
            lblMotherboard.Size = new Size(58, 20);
            lblMotherboard.TabIndex = 1;
            lblMotherboard.Text = "label11";
            // 
            // lblVideoCard
            // 
            lblVideoCard.AutoSize = true;
            lblVideoCard.Location = new Point(258, 260);
            lblVideoCard.Name = "lblVideoCard";
            lblVideoCard.Size = new Size(58, 20);
            lblVideoCard.TabIndex = 1;
            lblVideoCard.Text = "label11";
            // 
            // lblMonitors
            // 
            lblMonitors.AutoSize = true;
            lblMonitors.Location = new Point(258, 304);
            lblMonitors.Name = "lblMonitors";
            lblMonitors.Size = new Size(58, 20);
            lblMonitors.TabIndex = 1;
            lblMonitors.Text = "label11";
            // 
            // lblHardDisk
            // 
            lblHardDisk.AutoSize = true;
            lblHardDisk.Location = new Point(258, 349);
            lblHardDisk.Name = "lblHardDisk";
            lblHardDisk.Size = new Size(58, 20);
            lblHardDisk.TabIndex = 1;
            lblHardDisk.Text = "label11";
            // 
            // lblNetworkCard
            // 
            lblNetworkCard.AutoSize = true;
            lblNetworkCard.Location = new Point(258, 392);
            lblNetworkCard.Name = "lblNetworkCard";
            lblNetworkCard.Size = new Size(58, 20);
            lblNetworkCard.TabIndex = 1;
            lblNetworkCard.Text = "label11";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 498);
            Controls.Add(tabCtrlMenu);
            Name = "Form1";
            Text = "Hardware Info";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwInformation).EndInit();
            tabCtrlMenu.ResumeLayout(false);
            tabPgeOverview.ResumeLayout(false);
            tabPgeOverview.PerformLayout();
            tabPageOther.ResumeLayout(false);
            tabPageOther.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetInformation;
        private DataGridView dgwInformation;
        private ComboBox cmbManagementClsses;
        private DataGridViewTextBoxColumn colProperty;
        private DataGridViewTextBoxColumn ColValue;
        private Label label1;
        private Label lblMessage;
        private TabControl tabCtrlMenu;
        private TabPage tabPgeOverview;
        private TabPage tabPageCPU;
        private TabPage tabPageMotherboard;
        private TabPage tabPageMemory;
        private TabPage tabPageGraphics;
        private TabPage tabPageOther;
        private ImageList tabsIcons;
        private Label lblMachine;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblNetworkCard;
        private Label lblHardDisk;
        private Label lblMonitors;
        private Label lblVideoCard;
        private Label lblMotherboard;
        private Label lblProcessor;
        private Label lblMemory;
        private Label lblOS;
    }
}