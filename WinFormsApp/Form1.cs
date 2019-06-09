using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPFListViewControl;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var assembly = Assembly.GetExecutingAssembly();
            var resourceNames = assembly.GetManifestResourceNames();

            var customers = new List<Customer>();

            customers.Add(new Customer()
            {
                FirstName = "Dhoni",
                LastName = "Mahendra Sing",
                Age = 34,
                Role = "Wicket Keeper",
                Photo = Utils.ConvertStreamToByteArray(assembly.GetManifestResourceStream(resourceNames.Single(str => str.EndsWith("1.jpg"))))
            });

            customers.Add(new Customer()
            {
                FirstName = "Kohli",
                LastName = "Virath",
                Age = 30,
                Role = "Captain",
                Photo = Utils.ConvertStreamToByteArray(assembly.GetManifestResourceStream(resourceNames.Single(str => str.EndsWith("2.jpg"))))
            });

            customers.Add(new Customer()
            {
                FirstName = "Sharma",
                LastName = "Rohith",
                Age = 32,
                Role = "Bats Man",
                Photo = Utils.ConvertStreamToByteArray(assembly.GetManifestResourceStream(resourceNames.Single(str => str.EndsWith("3.jpg"))))
            });

            this.customListView_WinformsHost1.Customers = customers;
            this.customListView_WinformsHost1.SelectedIndex = 2;
        }
    }
}
