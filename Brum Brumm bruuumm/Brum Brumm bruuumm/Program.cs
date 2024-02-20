
using EscuderiasNuget;
namespace MostrarEscuderias
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean si = true;
            while(si) { 
            String seleccion = mostrarMenu();
                Console.Clear();
            Escuderia es = new Escuderia();
            seleccion = seleccion.ToLower();
            Carrera ca = new Carrera();
            switch(seleccion)
            {
                case "1":
                    case "ferrari":
                    
                    es = ca.RescuperarEscuderia(TiposEscuderia.Ferrari);
                        Mostrar(es);
                    break;
                case "2":
                    case "mclaren":
                        es = ca.RescuperarEscuderia(TiposEscuderia.McLaren);
                        Mostrar(es);
                        break;
                case "3":
                case "redbull":
                        es = ca.RescuperarEscuderia(TiposEscuderia.RedBull);
                        Mostrar(es);
                        break;
                case "4":
                    case "mercedes":
                        es = ca.RescuperarEscuderia(TiposEscuderia.Mercedes);
                        Mostrar(es);
                        break;
                case "5":
                    case "tororosso":
                        es = ca.RescuperarEscuderia(TiposEscuderia.ToroRosso);
                        Mostrar(es);

                        break;
                case "6":
                    case "salir":
                        si = false;
                        break;
            }
            }
        }
        private static String mostrarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("     //==================================================\\\\");
            Console.Write("     ||             "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("//============     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("//||              "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||             "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("||               "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("//  ||              "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||             "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("||             "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("//    ||              "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||             "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("||           "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("        ||              "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||             "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("||======== "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("          ||              "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||             "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("||       "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("            ||              "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||             "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("||                   "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("||              "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||             "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("||                   "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("||              "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||             "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("||                   "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("||              "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||             "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("||                   "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("||              "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("==================================================||\n");
            Console.Write("     ||                                                  ||\n");
            Console.Write("     ||              "); Console.ForegroundColor = ConsoleColor.White; Console.Write("INFORMACION ESCUDERIA               "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||                                                  ||\n");
            Console.Write("     ||                   "); Console.ForegroundColor = ConsoleColor.White; Console.Write("1.Ferrari                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||                   "); Console.ForegroundColor = ConsoleColor.White; Console.Write("2.Mclaren                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||                   "); Console.ForegroundColor = ConsoleColor.White; Console.Write("3.RedBull                      "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||                   "); Console.ForegroundColor = ConsoleColor.White; Console.Write("4.Mercedes                     "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||                   "); Console.ForegroundColor = ConsoleColor.White; Console.Write("5.ToroRosso                    "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||                   "); Console.ForegroundColor = ConsoleColor.White; Console.Write("6.Salir                        "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("||\n");
            Console.Write("     ||                                                  ||\n");
            Console.Write("     ||                                                  ||\n");
            Console.Write("     \\\\"); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("==================================================//\n");
            Console.Write("        Escriba que escuderia desesa obtener información: ");
            String datos = Console.ReadLine();
            return datos;
        }
        private static void Mostrar(Escuderia es)
        {
            Console.WriteLine("\t===============================================");
            Console.WriteLine("\tid: " + es.IdEscuderia + "\nNombre: " + es.Nombre + "\nPiloto: " + es.Piloto + "\nPais: " + es.Pais + "\nImagen: " + es.Imagen);
            Console.WriteLine("\t===============================================");
            Console.Write("\tPulse cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }

}


