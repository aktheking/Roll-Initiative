using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll_Initiative
{
    public partial class DynamicGridRow : Component
    {
        public TextBox Combatant;
        public TextBox InitiativeValue;
        public Button RemoveButton;

        public DynamicGridRow(string combatant, string initiativeValue)
        {
            InitializeComponent();
            Combatant = new TextBox();
            Combatant.Text = combatant;
            InitiativeValue = new TextBox();
            InitiativeValue.Text = initiativeValue;
            RemoveButton = new Button();
        }

        public DynamicGridRow(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        //public CreateTextBox (string )
    }
}
