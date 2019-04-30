using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Window_Population
{
    public partial class DynamicView2 : BaseView
    {
        public DynamicView2()
        {
            InitializeComponent();
        }

        public DynamicView2(BaseViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;            
        }

        protected override void UpdateBindings()
        {
            //Clear the bindings first to prevent a crash
            foreach (Control c in this.Controls)
            {
                c.DataBindings.Clear();
            }

            panel1.DataBindings.Add("BackColor", ViewModel, "PanelBackground", false, DataSourceUpdateMode.OnPropertyChanged);
            panel2.DataBindings.Add("BackColor", ViewModel, "PanelBackground", false, DataSourceUpdateMode.OnPropertyChanged);
            tbHex.DataBindings.Add("Text", ViewModel, "Hex", false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
