using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Window_Population
{
    public class ViewModel1 : BaseViewModel
    {
        public Color PanelBackground { get; set; } = Color.Green;

        public string Hex
        {
            get
            {
                return "#" + PanelBackground.R.ToString("X2") + PanelBackground.G.ToString("X2") + PanelBackground.B.ToString("X2");
            }
        }
    }
}
