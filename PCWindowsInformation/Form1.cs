//using System.man

using PCWindowsInformation.Properties;
using System.Data;
using System.Management;
using System.Reflection;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Microsoft.EnterpriseManagement.Common

namespace PCWindowsInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetInformation_Click(object sender, EventArgs e)
        {

            dgwInformation.Rows.Clear();
            try
            {
                lblMessage.Text = "Please wait...";
                btnGetInformation.Enabled = false;
                cmbManagementClsses.Enabled = false;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + cmbManagementClsses.SelectedValue.ToString().Trim());
                ManagementObjectCollection Moc = searcher.Get();
                //foreach (ManagementObject share in searcher.Get())
                //{
                foreach (ManagementObject m in Moc)
                {
                    foreach (PropertyData PC in m.Properties)
                    {
                        dgwInformation.Rows.Add(PC.Name, PC.Value);
                    }
                }
                //}
                if (dgwInformation.Rows.Count < 1)
                {
                    lblMessage.Text = "No Properties found";
                }
                else lblMessage.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            finally
            {
                btnGetInformation.Enabled = true;
                cmbManagementClsses.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadOverview();
            cmbManagementClsses.Visible = true;

            var WMIClasses = ReadWMIClasses();
            if (WMIClasses.Count > 0)
            {
                cmbManagementClsses.DataSource = new BindingSource(WMIClasses, null);
                cmbManagementClsses.DisplayMember = "Value";
                cmbManagementClsses.ValueMember = "Key";
            }
            else
            {
                MessageBox.Show("No WMI Classes found");
            }
        }

        private Dictionary<string, string> ReadWMIClasses()
        {
            var response = new Dictionary<string, string>();
            var WMIClasses = Resources.WMIClassesFile.Split("\r\n").ToList();
            foreach (string WMIClass in WMIClasses)
            {
                var x = SplitOnCamelCase(WMIClass.Split('_')[1]);
                response.Add(WMIClass, SplitOnCamelCase(WMIClass.Split(new[] { '_' }, 2)[1]));
            }
            return response;
        }

        private string SplitOnCamelCase(string param)
        {
            return System.Text.RegularExpressions.Regex.Replace(param, "(?<=[a-z0-9])([A-Z_])", " $1", System.Text.RegularExpressions.RegexOptions.Compiled).Trim();
        }

        private void LoadOverview()
        {
            LoadComputerSystem();
            LoadOS();
            LoadMemory();
            LoadProcessor();
            LoadMotherBoard();
            LoadVideoCard();
            LoadMonitors();
            LoadNetworkCard();
            LoadHardDrives();
        }

        private void LoadComputerSystem()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_ComputerSystem");
            foreach (ManagementObject mo in searcher.Get())
            {
                lblMachine.Text = mo["Model"].ToString();
            }
        }

        private void LoadOS()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            foreach (ManagementObject mo in searcher.Get())
            {
                lblOS.Text = mo["Caption"].ToString() + " - " + mo["OSArchitecture"].ToString();
            }
        }

        private void LoadMemory()
        {

            long MemSize = 0;
            long mCap = 0;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
            foreach (ManagementObject mo in searcher.Get())
            {
                mCap = Convert.ToInt64(mo["Capacity"]);
                MemSize += mCap;
                //lblOS.Text = mo["Caption"].ToString() + " - " + mo["OSArchitecture"].ToString();
            }
            MemSize = (MemSize / 1024) / 1024 / 1024;
            lblMemory.Text =  MemSize.ToString() + " GB";
        }

        private void LoadProcessor()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject mo in searcher.Get())
            {
                lblProcessor.Text = mo["Name"].ToString();
            }
        }

        private void LoadMotherBoard()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_BaseBoard");
            foreach (ManagementObject mo in searcher.Get())
            {
                lblMotherboard.Text = mo["Manufacturer"].ToString() + " - " + mo["Product"].ToString();
            }
        }

        private void LoadVideoCard()
        {
            lblVideoCard.Text = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_VideoController");
            foreach (ManagementObject mo in searcher.Get())
            {
                lblVideoCard.Text = lblVideoCard.Text.Length > 0 ? lblVideoCard.Text + @" / " + mo["Caption"].ToString() : mo["Caption"].ToString();
            }
        }

        private void LoadMonitors()
        {
            lblMonitors.Text = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_DesktopMonitor");
            foreach (ManagementObject mo in searcher.Get())
            {
                lblMonitors.Text = (lblMonitors.Text.Length > 0 ? (lblMonitors.Text + " / ") : "") + mo["Caption"].ToString();
            }
        }

        private void LoadHardDrives()
        {
            lblHardDisk.Text = string.Empty;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_DiskDrive");
            foreach (ManagementObject mo in searcher.Get())
            {
                long size = Convert.ToInt64(mo["Size"]) / 1024 / 1024 / 1024;
                lblHardDisk.Text = (lblHardDisk.Text.Length > 0 ? (lblHardDisk.Text + " / ") : "") + mo["Model"].ToString() + " (" + size + " GB)";
            }
        }

        private void LoadNetworkCard()
        {
            lblNetworkCard.Text = string.Empty;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_NetworkAdapter");
            foreach (ManagementObject mo in searcher.Get())
            {
                if (mo["MACAddress"] != null && !string.IsNullOrWhiteSpace(mo["MACAddress"].ToString()) && mo["Manufacturer"].ToString() != "Microsoft")
                {
                    var x = mo["MACAddress"].ToString();
                    lblNetworkCard.Text = (lblNetworkCard.Text.Length > 0 ? (lblNetworkCard.Text + " / ") : "") + mo["Name"].ToString();
                }
            }
        }
    }
}