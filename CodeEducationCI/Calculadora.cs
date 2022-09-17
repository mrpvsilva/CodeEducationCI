namespace CodeEducationCI
{
    public class Calculadora
    {
        public static int Somar(params int[] value)
        {
            return value.Sum(x => x);
        }
    }
}
