using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFListViewControl
{
    /// <summary>
    /// Interaction logic for CustomListView.xaml
    /// </summary>
    public partial class CustomListView : UserControl
    {
        public CustomListView()
        {
            InitializeComponent();

            this.SelectedIndex = 0;
            this.DataContext = this;
        }

        public int SelectedIndex
        {
            get
            {
                return listBox.SelectedIndex;
            }
            set
            {
                listBox.SelectedIndex = value;
            }
        }

        public List<Customer> Customers { get; set; }
    }
}
