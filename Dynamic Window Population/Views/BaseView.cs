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
    public partial class BaseView : UserControl
    {
        #region Private Fields
        private BaseViewModel _viewModel;
        #endregion

        #region Public Properties
        public BaseViewModel ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                UpdateBindings();
            }
        }
        #endregion

        #region Constructor
        public BaseView()
        {
            InitializeComponent();
        }

        public BaseView(BaseViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;            
        }
        #endregion

        protected virtual void UpdateBindings()
        {
            //MessageBox.Show("BEEP");
        }
    }
}
