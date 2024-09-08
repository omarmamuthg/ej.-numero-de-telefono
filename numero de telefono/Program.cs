// See https://aka.ms/new-console-template for more information
//using System.Numerics;
//(812) 373 - 3290
//string[] number_phone = new string[10];
//Console.WriteLine("Escribe un numero de telefono");
//string numero_telefono = Console.ReadLine();

//for (int i = 0; i < numero_telefono.Length; i++)
//{

//    number_phone[i] = numero_telefono[i].ToString();
//}
//string cadena1 = "";
//string cadena2 = "";
//string cadena3 = "";
//string cadena_total = "";

//foreach (var cadena in Enumerable.Range(0, number_phone.Length))
//{
//    if (cadena >= 0 && cadena <= 2)
//    {
//        cadena1 = cadena1 + number_phone[cadena];
//    }

//    if (cadena >= 3 && cadena <= 5)
//    {
//        cadena2 = cadena2 + number_phone[cadena];
//    }

//    if (cadena >= 6 && cadena <= 9)
//    {
//        cadena3 = cadena3 + number_phone[cadena];
//    }

//}

//Console.Write($"\n({cadena1}) {cadena2}-{cadena3}");
string[] number_phone = new string[10];

Console.WriteLine("Escribe un numero de telefono");
string numero_telefono = Console.ReadLine();


for (int i = 0; i < numero_telefono.Length; i++)
{

    number_phone[i] = numero_telefono[i].ToString();
}

string resultado= NumeroTelefono(numero_telefono, number_phone);

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


