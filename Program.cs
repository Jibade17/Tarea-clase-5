Console.Clear();

var respuesta = "S";

while (respuesta.ToUpper() ==  "S")
{
    Console.WriteLine("Ingrese su nombre");
    var Nombre = Console.ReadLine();
    Console.WriteLine("Hola " + Nombre);
    Console.WriteLine("Desea continuar S/N?");
    respuesta = Console.ReadLine();
}

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opción no válida");
}