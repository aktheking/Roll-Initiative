namespace Roll_Initiative
{
    public partial class frmMainScreen : Form
    {
        public const int COMBATANT_COLUMN_NUM = 0;
        public const int INITATIVE_COLUMN_NUM = 1;
        public Color DEFAULT_GRID_COLOR = Color.White;
        public Color DUPLICATE_HIGHLIGHT_COLOR = Color.Red;

        public List<string> combatants = new List<string>();

        public frmMainScreen()
        {
            InitializeComponent();
            InitializeListViewSettings();
            combatants = Constants.PartyMembers;
        }

        private void InitializeListViewSettings()
        {
            InitializeListViewProperties();
            AddListViewColumns();
        }

        private void InitializeListViewProperties()
        {
            lvwInitiative.View = System.Windows.Forms.View.Details;
            lvwInitiative.FullRowSelect = true;
            lvwInitiative.Font = new Font(lvwInitiative.Font, FontStyle.Bold);
        }

        private void AddListViewColumns()
        {
            lvwInitiative.Columns.Add(new ColumnHeader());
            lvwInitiative.Columns.Add(new ColumnHeader());
            lvwInitiative.Columns[COMBATANT_COLUMN_NUM].Text = "Combatant";
            lvwInitiative.Columns[INITATIVE_COLUMN_NUM].Text = "Initiative";

            SetColumnWidths();
        }

        private void SetColumnWidths()
        {
            foreach (ColumnHeader column in lvwInitiative.Columns)
            {
                column.Width = lvwInitiative.Width / lvwInitiative.Columns.Count;
            }
        }

        private void ResetListView()
        {
            ClearListView();
            InitializeListViewSettings();
        }

        private void ClearListView()
        {
            lvwInitiative.Clear();
        }

        private void RollPreexistingCombatants()
        {
            List<string> combatantsToRemove = new List<string> ();

            foreach (string combatant in combatants)
            {
                using (frmInsertCombatantIntoInitiative frm = new frmInsertCombatantIntoInitiative(combatant))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        AddRow(new InitiativeTurn(frm.Combatant, frm.Initiative));
                    }
                    else
                    {
                        combatantsToRemove.Add(combatant);                        
                    }
                }
            }

            RemoveCombatants(combatantsToRemove);
        }

        private void RemoveCombatants(List<string> combatantsToRemove)
        {
            foreach (string combatant in combatantsToRemove)
            {
                combatants.Remove(combatant);
            }
        }

        private void RollNewCombatants()
        {
            bool AddMoreCombatants = true;
            while (AddMoreCombatants)
            {
                using (frmInsertCombatantIntoInitiative frm = new frmInsertCombatantIntoInitiative())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        combatants.Add(frm.Combatant);
                        AddRow(new InitiativeTurn(frm.Combatant, frm.Initiative));
                    }
                    else
                    {
                        AddMoreCombatants = false;
                    }
                }
            }
        }

        private void AddNewCombatant()
        {
            using (frmInsertCombatantIntoInitiative frm = new frmInsertCombatantIntoInitiative())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    combatants.Add(frm.Combatant);
                    AddRow(new InitiativeTurn(frm.Combatant, frm.Initiative));
                }
            }
        }

        private void OrderCombatants()
        {
            lvwInitiative.ListViewItemSorter = new ListViewSorterByInitiative();
        }

        private void AddRow(InitiativeTurn turn)
        {
            ListViewItem item = new ListViewItem(new string[] { turn.Combatant, turn.Initiative });
            lvwInitiative.Items.Add(item);
            item.Font = new Font(item.Font, FontStyle.Regular);
        }

        //returns list of deleted items
        private List<ListViewItem> RemoveSelectedCombatants()
        {
            List<ListViewItem> list = new List<ListViewItem>();
            foreach (ListViewItem item in lvwInitiative.SelectedItems)
            {
                list.Add(item);
                lvwInitiative.Items.Remove(item);
            }
            return list;
        }

        private void AfterChangingCombatants()
        {
            CheckDuplicates();
        }

        private void CheckDuplicates()
        {
            UnhighlightRows();

            for (int i = 0; i < lvwInitiative.Items.Count - 1; i++)
            {
                ListViewItem currentItem = lvwInitiative.Items[i];
                ListViewItem nextItem = lvwInitiative.Items[i + 1];

                string currentInitative = ((ListViewItem)currentItem).SubItems[INITATIVE_COLUMN_NUM].Text;
                string nextInitiative = ((ListViewItem)nextItem).SubItems[INITATIVE_COLUMN_NUM].Text;

                if (currentInitative == nextInitiative)
                {
                    HighlightRow(i);
                    HighlightRow(i + 1);
                }
            }
        }

        private void UnhighlightRows()
        {
            foreach (ListViewItem item in lvwInitiative.Items)
            {
                item.BackColor = DEFAULT_GRID_COLOR;
            }
        }

        private void HighlightRow(int row)
        {
            lvwInitiative.Items[row].BackColor = DUPLICATE_HIGHLIGHT_COLOR;
        }

        private void btnRollInitiative_Click(object sender, EventArgs e)
        {
            StartMusic();
            ResetListView();
            RollPreexistingCombatants();
            RollNewCombatants();
            OrderCombatants();
            AfterChangingCombatants();
        }

        private void StartMusic()
        {
            if (File.Exists(Constants.COMBAT_MUSIC_FILE))
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Constants.COMBAT_MUSIC_FILE);
                player.PlayLooping();
            }
        }

        private void btnAddCombatant_Click(object sender, EventArgs e)
        {
            AddNewCombatant();
            OrderCombatants();
            AfterChangingCombatants();
        }

        private void btnRemoveCombatant_Click(object sender, EventArgs e)
        {
            if (lvwInitiative.SelectedItems.Count > 0)
            {
                RemoveSelectedCombatants();
            }
            AfterChangingCombatants();
        }

        private void btnRerollCombatant_Click(object sender, EventArgs e)
        {
            if (lvwInitiative.SelectedItems.Count > 0)
            {
                List<ListViewItem> deletedItems = RemoveSelectedCombatants();
                foreach (ListViewItem item in deletedItems)
                {
                    using (frmInsertCombatantIntoInitiative frm = new frmInsertCombatantIntoInitiative(item.SubItems[COMBATANT_COLUMN_NUM].Text))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            AddRow(new InitiativeTurn(frm.Combatant, frm.Initiative));
                        }
                    }
                }
            }
            AfterChangingCombatants();
        }
    }
}