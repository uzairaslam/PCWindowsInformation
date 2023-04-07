//using System.man

using System.Data;
using System.Management;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
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
            //string clsName = cmbManagementClsses.SelectedItem.ToString();
            //if (!string.IsNullOrWhiteSpace(clsName))
            //{

            //}
            //Win32_PhysicalMemory
            //Win32_BaseBoard
            //Win32_Processor

            ManagementClass managementClass = new ManagementClass(cmbManagementClsses.SelectedItem.ToString());

            ManagementObjectCollection managementObjects = managementClass.GetInstances();
            foreach (ManagementObject managementObject in managementObjects)
            {
                // Retrieve the desired properties
                //string manufacturer = (string)managementObject["Manufacturer"];
                //string product = (string)managementObject["Product"];
                //string serialNumber = (string)managementObject["SerialNumber"];
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Value");
                foreach (var property in managementObject.Properties)
                {
                    var row = dt.NewRow();
                    row[0] = property.Name;
                    row[1] = property.Value;
                    dt.Rows.Add(row);
                }
                dgwInformation.DataSource = dt;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbManagementClsses.Visible = true;
            cmbManagementClsses.Items.Add("Win32_PhysicalMemory");
            cmbManagementClsses.Items.Add("Win32_BaseBoard");
            cmbManagementClsses.Items.Add("Win32_Processor");
            cmbManagementClsses.Items.Add("Win32_BIOS");
            cmbManagementClsses.Items.Add("Win32_Battery");
            cmbManagementClsses.Items.Add("Win32_Fan");
            cmbManagementClsses.Items.Add("Win32_DiskDrive");
            //ManagementClass managementClass = new ManagementClass(new ManagementScope("root\\CIMV2"), new ManagementPath(), null);

            //// Get all classes in the CIMV2 namespace
            //ManagementObjectCollection managementObjects = managementClass.GetSubclasses();

            //// Loop through each ManagementObject in the collection

            //foreach (ManagementObject managementObject in managementObjects)
            //{
            //    // Retrieve the class name
            //    string className = managementObject["__CLASS"].ToString();

            //    // Display the class name
            //    //Console.WriteLine(className);
            //    if (className.StartsWith("Win32_") || className.StartsWith("MSFT_"))
            //        cmbManagementClsses.Items.Add(className);
            //}
        }
    }
}