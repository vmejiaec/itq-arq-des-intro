// See https://aka.ms/new-console-template for more information
using Entidades.Calificaciones;
using Modelos.Calificaciones;

Console.WriteLine("Configuración del métod de calificación de tres notas");

var TresNotas_Nota1 = new CalifTipoDet() { Nombre = "Nota 1", Orden = 0, Peso = 30m, Calculado = false };
var TresNotas_Nota2 = new CalifTipoDet() { Nombre = "Nota 2", Orden = 1, Peso = 35m, Calculado = false };
var TresNotas_Nota3 = new CalifTipoDet() { Nombre = "Nota 3", Orden = 2, Peso = 35m, Calculado = false };
var TresNotas_Prom123 = new CalifTipoDet() { Nombre = "Promedio ponderado Notas 1,2 y 3", Peso = 100m, Orden = 4, Calculado = true };
var TresNotas_Recup = new CalifTipoDet() { Nombre = "Recuperación", Orden = 5, Peso = 35m, Calculado = false };
var TresNotas_Final = new CalifTipoDet() { Nombre = "Nota Final", Orden = 6, Peso = 100m, Calculado = true };

CalifTipo CalifTipoTresNotas = new CalifTipo() {
    Descripcion = "Calificación por 3 notas.",
    CalifTipoDets = new List<CalifTipoDet>()
    {
        TresNotas_Nota1,
        TresNotas_Nota2,
        TresNotas_Nota3,
        TresNotas_Prom123,
        TresNotas_Recup,
        TresNotas_Final
    }
};

CalifCaso CasoBuenAlumno = new CalifCaso() {
    CalifTipo = CalifTipoTresNotas,
    CasoNotas = new List<CasoNota>()
    {
        new CasoNota(){ CalifTipoDet = TresNotas_Nota1, Valor = 7m},
        new CasoNota(){ CalifTipoDet = TresNotas_Nota2, Valor = 7m},
        new CasoNota(){ CalifTipoDet = TresNotas_Nota3, Valor = 7m},
        new CasoNota(){ CalifTipoDet = TresNotas_Recup, Valor = 0m}
    }
};

Calif.Calc(CasoBuenAlumno);





