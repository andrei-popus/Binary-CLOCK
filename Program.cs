class Program
{
    static void Main()
    {
        //ex1();


        static void ex1()
        {
            Console.Write("Introduceți ora curentă (HH:mm:ss): ");
            string input = Console.ReadLine();

            // Verificăm formatul corect al orei
            if (DateTime.TryParseExact(input, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime oraCurenta))
            {
                // Extragem orele, minutele și secundele
                int ore = oraCurenta.Hour;
                int minute = oraCurenta.Minute;
                int secunde = oraCurenta.Second;

                // Afișăm ora curentă în format binar
                Console.WriteLine($"Ora curentă în binar: {ConvertToBinary(ore)}:{ConvertToBinary(minute)}:{ConvertToBinary(secunde)}");
            }
            else
            {
                Console.WriteLine("Formatul introdus nu este valid.");
            }
        }

        // Funcție pentru a converti un număr în binar
        static string ConvertToBinary(int numar)
        {
            return Convert.ToString(numar, 2).PadLeft(6, '0'); // Se presupune că ora, minutele și secundele sunt reprezentate pe 6 biți fiecare
        }
    }
}

