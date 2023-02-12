class Calculation
{
    public int CalculationSystem(int trumTemp, int metroTemp, int dayTamp)
    {
        int result;
        int temp = 0;
        for (int i = 1; i <= dayTamp; i++)
        {

            temp = (trumTemp * 2) + (metroTemp * 2) + temp;

        }
        return result = temp;
    }
}