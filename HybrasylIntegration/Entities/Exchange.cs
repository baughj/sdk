namespace Hybrasyl.Entities
{
    public class Exchange
    {
        public Inventory SourceItems { get; set; }
        public Inventory TargetItems { get; set; }
        public uint SourceGold { get; set; }
        public uint TargetGold { get; set; }
        public int SourceSize { get; set; }
        public int TargetSize { get; set; }
        public User Source { get; set; }
        public User Target { get; set; }
        public bool Active { get; set; }
        public int SourceWeight { get; set; }
        public int TargetWeight { get; set; }
        public bool SourceConfirmed { get; set; }
        public bool TargetConfirmed { get; set; }

        public Exchange(User source, User target)
        {
            Source = source;
            Target = target;
            SourceItems = new Inventory(60);
            TargetItems = new Inventory(60);
            SourceGold = 0;
            TargetGold = 0;
            SourceWeight = 0;
            TargetWeight = 0;
            SourceSize = source.Inventory.EmptySlots;
            TargetSize = target.Inventory.EmptySlots;
        }
    }
}
