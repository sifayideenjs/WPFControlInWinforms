using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFListViewControl;

namespace WinFormsApp
{
    [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
    [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]
    class CustomListView_WinformsHost : System.Windows.Forms.Integration.ElementHost
    {
        protected CustomListView _CustomListView = new CustomListView();

        public CustomListView_WinformsHost()
        {
            base.Child = _CustomListView;
        }

        public int SelectedIndex
        {
            get
            {
                return _CustomListView.SelectedIndex;
            }
            set
            {
                _CustomListView.SelectedIndex = value;
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return _CustomListView.Customers;
            }
            set
            {
                _CustomListView.Customers = value;
            }
        }
    }
}
