using Entidades.Calificaciones;

namespace Modelos.Calificaciones
{
    public class Calif
    {
        public static void Calc(CalifCaso caso)
        {
            switch (caso.CalifTipo.Metodo)
            {
                case CalifMetodo.TresNotas:
                    decimal suma = 0.0m;
                    for (int i = 0; i < 3; i++)
                    {
                        CalcPonderado(caso.CasoNotas[i]);
                        suma += caso.CasoNotas[i].ValorPonderado;
                    }
                    
                    break;
                case CalifMetodo.CuatroNotas:
                    break;
                default:
                    break;
            }
        }

        private static void CalcPonderado(CasoNota nota)
        {
            nota.ValorPonderado = nota.Valor * nota.CalifTipoDet.Peso;
        }
    }
}
