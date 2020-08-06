using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentGame
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        // Closes the tutorial form when the close button is clicked
        private void btnClose_Click(object sender, EventArgs e)
        {
            // hides the current form
            this.Hide();
        }
    }
}
