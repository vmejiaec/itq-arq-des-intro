using System.Diagnostics;

await HacerCafe();

async Task HacerCafe()
{
    Stopwatch reloj = new Stopwatch();
    reloj.Start();

    Console.WriteLine("+ Empiezo a hacer café");
    
    var x = HervirElAgua();
    var y = CalentarLaLeche();
    PrepararLaMesa();
    
    await x;
    await y;    
    ServirElCafe();
    Console.WriteLine("- El café está listo");



    reloj.Stop();
    Console.WriteLine("Tiempo transcurrido: "+reloj.Elapsed.ToString());
}

void ServirElCafe()
{
    Console.WriteLine("  + Empiezo a servir el café");
    Thread.Sleep(1000);
    Console.WriteLine("  - Termino de servir el café");
}

void PrepararLaMesa()
{
    Console.WriteLine("  + Empiezo a preparar la mesa");
    Thread.Sleep(1000);
    Console.WriteLine("  - Termino de preparar la mesa");
}

async Task CalentarLaLeche()
{
    Console.WriteLine("  + Empiezo a calentar la leche");
    await Task.Delay(2000);
    Console.WriteLine("  - Termino de calentar la leche");
}

async Task HervirElAgua()
{
    Console.WriteLine("  + Empiezo a hervir el agua");
    await Task.Delay(3000);
    Console.WriteLine("  - Termino de hervir el agua");
}