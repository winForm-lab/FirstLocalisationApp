using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLocalisationApp
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
 
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar");
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
