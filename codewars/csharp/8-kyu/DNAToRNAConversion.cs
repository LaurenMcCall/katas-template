namespace Converter
{
    public class Converter
    {
        public string dnaToRna(string dna)
        {
            string tToU = dna.Replace("T", "U");
            return tToU;
        }
    }
}