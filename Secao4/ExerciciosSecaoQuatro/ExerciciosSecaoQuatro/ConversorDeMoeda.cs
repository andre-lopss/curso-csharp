namespace ExerciciosSecaoQuatro
{
    internal class ConversorDeMoeda
    {
        public static double ValorEmReais(double dolar, double quantidade)
        {
            double _valorConvertido = dolar * quantidade;
            double _iof = _valorConvertido * 0.06;
            return _valorConvertido += _iof;
        }
    }
}
