// See https://aka.ms/new-console-template for more information

using EscuderiasNuget;


ListaEscuderias list = new ListaEscuderias();
Carrera ca = new Carrera();
//Crea un objeto de cada escuderia
Escuderia ferrari =  ca.RescuperarEscuderia(TiposEscuderia.Ferrari);
Escuderia Mclaren = ca.RescuperarEscuderia(TiposEscuderia.McLaren);
Escuderia Mercedes = ca.RescuperarEscuderia(TiposEscuderia.Mercedes);
Escuderia Redbull = ca.RescuperarEscuderia(TiposEscuderia.RedBull);
Escuderia Toro = ca.RescuperarEscuderia(TiposEscuderia.ToroRosso);
//
Escuderia[] escuderias = {ferrari, Mclaren, Mercedes, Redbull,Toro};
String pilotoCa = "";

for(int i = 0; i < escuderias.Length; i++)
{
    pilotoCa += "Escuderia: "+escuderias[i].Nombre+ ", Piloto: "+escuderias[i].Piloto + "\n";
}
Console.WriteLine(pilotoCa);