
Console.WriteLine("Ingrese la cantidad de alumnos por favor: ");
int cantidadAlumnos = int.Parse(Console.ReadLine());
int[] notas = new int[cantidadAlumnos];

Console.WriteLine("Ingrese las notas de cada alumno: ");

for (int posicion = 0; posicion < notas.Length; posicion++)
{
    Console.WriteLine($"Notas del alumno N° {posicion + 1}: ");
    notas[posicion] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("===============");
Console.WriteLine();
for (int posicion = 0; posicion < notas.Length; posicion++)
{
    Console.WriteLine($"La nota del alumno N° {posicion + 1} es {notas[posicion]}");
}