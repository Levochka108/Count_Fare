//Hello, this is me first program on C#.
//It calculates your money for usage transport in RUSSIA.

using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        int result;
        Write("Цена на трамвай > ");
        int tempTrum;
        int.TryParse(ReadLine(), out tempTrum);

        Write("Цена на метро > ");
        int tempMetro;
        int.TryParse(ReadLine(), out tempMetro);

        Write("Сколько дней планируется ездить > ");
        int tempDay;
        int.TryParse(ReadLine(), out tempDay);

        Calculation calculation = new Calculation();
        result = calculation.CalculationSystem(tempTrum, tempMetro, tempDay);
        WriteLine($"Сумма туда и обратно > {result} руб.");
    }
}