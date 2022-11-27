using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll_Initiative
{
    public partial class frmInsertCombatantIntoInitiative : Form
    {
        public frmInsertCombatantIntoInitiative() : this("") {}

        public frmInsertCombatantIntoInitiative(string combatant)
        {
            InitializeComponent();
            txtCombatant.Text = combatant;
            if (txtCombatant.Text == "")
            {
                txtCombatant.Select();
            }
            else
            {
                txtInitiative.Select();
            }
        }

        public string Combatant
        {
            get
            {
                return txtCombatant.Text;
            }
        }

        public string Initiative
        {
            get
            {
                return txtInitiative.Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
