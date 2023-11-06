namespace Roll_Initiative
{
    public static class Constants
    {
        public readonly static List<string> PartyMembers = new List<string>()
        {
            "Thelmyr",
            "Ilalo",
            "Clover",
            "Ser Aeros",
            "Maeda"
        };

        public readonly static string COMBAT_MUSIC_FILE = Path.Combine(Path.GetFullPath("."), @"Combat (generic).wav");

        public readonly static string INITIATIVE_PATTERN = @"\d+[\+\-]?";
    }
}
