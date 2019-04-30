using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Window_Population
{
    public partial class BaseForm : Form
    {
        #region Private Fields
        private BaseView _view; 
        #endregion

        #region Public Properties
        public BaseView View
        {
            get { return _view; }
            set
            {
                _view = value;
                this.Controls.Clear();
                this.Controls.Add(_view);
            }
        }
        #endregion

        #region Constructor
        public BaseForm()
        {
            InitializeComponent();
        }
        #endregion
    }
}
