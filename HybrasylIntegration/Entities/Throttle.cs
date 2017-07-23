namespace Hybrasyl.Entities
{
    public class Throttle
    {
        public byte OpCode { get; set; }
        public int Time { get; set; }
        public int SquelchCount { get; set; }
        public int SquelchWithin { get; set; }
        public int SquelchDuration { get; set; }
        public int DisconnectAfter { get; set; }
    }
}
