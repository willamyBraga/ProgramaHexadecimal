using System;

namespace ProgramaHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "id=1234#cpf=35312376524#nome=Luis";
            byte[] bytes = System.Text.Encoding.Default.GetBytes(value);
            string hexString = BitConverter.ToString(bytes);
            hexString = hexString.Replace("-", "");
            Console.WriteLine("Codigo hexadeximal: " + hexString);
        }
    }
}
