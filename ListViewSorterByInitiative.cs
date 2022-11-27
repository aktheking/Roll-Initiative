namespace Roll_Initiative
{
    public class ListViewSorterByInitiative : System.Collections.IComparer
    {
        private const int SORT_COLUMN = frmMainScreen.INITATIVE_COLUMN_NUM;


        public int Compare(object? x, object? y)
        {
            InitiativeValue xValue = new((x as ListViewItem).SubItems[SORT_COLUMN].Text);
            InitiativeValue yValue = new((y as ListViewItem).SubItems[SORT_COLUMN].Text);

            bool xSuccessfulCast = xValue != null && xValue.IsValid();
            bool ySuccessfulCast = yValue != null && yValue.IsValid();

            if (xSuccessfulCast && ySuccessfulCast)
            {
                return yValue.CompareTo(xValue);
            }
            else if (xSuccessfulCast && !ySuccessfulCast)
            {
                return -1;
            }
            else if (xSuccessfulCast && ySuccessfulCast)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
