// See https://aka.ms/new-console-template for more information
//using System.Numerics;
//(812) 373 - 3290

using System.Timers;

string[] number_phone = new string[10];

string numero_telefono;

while (true)
{
    Console.WriteLine("Escribe un numero de telefono");
    numero_telefono = Console.ReadLine();

    if (!numero_telefono.All(char.IsDigit))
    {
        Console.WriteLine("ingresaste una letra, intenta de nuevo por favor\n");
        continue;
    }

    if (numero_telefono.Length < 10)
    {
        Console.WriteLine("El numero necesita tener 10 digitos, intenta de nuevo por favor\n");
        continue;
    }

    if (numero_telefono.Length > 10)
    {
        Console.WriteLine("Solamente se necesitan 10 digitos, intenta de nuevo por favor\n");
        continue;
    }

    for (int i = 0; i < numero_telefono.Length; i++)
    {
        number_phone[i] = numero_telefono[i].ToString();
    }
    break;
}
string resultado = NumeroTelefono(numero_telefono, number_phone);
Console.Write($"\nEl numero de telefono es: {resultado}");






static string NumeroTelefono(string PNumero, string[] number_phone)
{
    string cadena1 = "";
    string cadena2 = "";
    string cadena3 = "";
    //string cadena_total = "";

    foreach (var cadena in Enumerable.Range(0, number_phone.Length))
    {
        if (cadena >= 0 && cadena <= 2)
        {
            cadena1 = cadena1 + number_phone[cadena];
        }

        if (cadena >= 3 && cadena <= 5)
        {
            cadena2 = cadena2 + number_phone[cadena];
        }

        if (cadena >= 6 && cadena <= 9)
        {
            cadena3 = cadena3 + number_phone[cadena];
        }

    }
    return $"({cadena1}) {cadena2}-{cadena3}";
}


