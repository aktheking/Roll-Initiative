using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll_Initiative
{
    public partial class DynamicGrid : Component
    {
        public List<DynamicGridRow> GridRows;

        public DynamicGrid(List<DynamicGridRow> gridRows)
        {
            GridRows = gridRows;
            InitializeComponent();
        }

        public DynamicGrid(List<string> combatants)
        {
            InitializeComponent();
            GridRows = new List<DynamicGridRow>();
            foreach (string combatant in combatants)
            {
                GridRows.Add(new DynamicGridRow(combatant, ""));
            }
        }

        public DynamicGrid(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
