namespace ex4
{
    public interface ICalc
    {
        /// <summary>
        /// This interface force the class to do a calc
        /// </summary>
        /// <returns>return a double dependency of your implementation</returns>
        double Calc(double x, double y);
    }
}
