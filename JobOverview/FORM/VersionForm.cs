using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobOverview.POCO;

namespace JobOverview.FORM
{
    public partial class VersionForm : Form
    {
        public VersionForm()
        {
            InitializeComponent();
            
        }

        protected override void OnLoad(EventArgs e)
        {
            cbLogiciel.DataSource = ListeDonnees.ListeLogiciel;
            cbLogiciel.DisplayMember = "Nom";
            cbLogiciel.ValueMember = "CodeLogiciel";
            base.OnLoad(e);
        }
    }
}
