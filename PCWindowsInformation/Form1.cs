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
    }
}