namespace TallerPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estado estado = new Estado
            {
                PosicionActual = 0,
                PosicionObjetivo = 5
            };

            // Armar árbol
            SelectorDistancia selectorDistancia = new SelectorDistancia(estado, 10);
            selectorDistancia.AgregarHijo(new TareaMover(estado));

            Selector selectorGeneral = new Selector();
            selectorGeneral.AgregarHijo(selectorDistancia);
            selectorGeneral.AgregarHijo(new TareaSaltar());

            Secuencia secuencia = new Secuencia();
            secuencia.AgregarHijo(selectorGeneral);
            secuencia.AgregarHijo(new TareaEsperar(2));

            Raiz raiz = new Raiz(secuencia);

            // Ciclos
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\n--- Ciclo {i} ---");
                raiz.Ejecutar();
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nEjecución finalizada.");
            Console.ResetColor();
        }
    }
}
