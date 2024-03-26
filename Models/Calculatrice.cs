namespace Server_Calculator.Models
{
    public class Calculatrice
    {
        public int ID { get; set; }
        public double Number1 { get; set; }
        public string? Operator { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }
    }
}