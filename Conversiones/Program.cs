using System.Collections;
using System.ComponentModel.Design;
using System.Linq;

Console.WriteLine("ELige a que quieres convertir tu notacion Infija:");
Console.WriteLine("1 -- Prefija");
Console.WriteLine("2 -- Posfija");

Stack pila = new();
string o = "()-+*/";
string Resultado = "";
int opcion = int.Parse(Console.ReadLine());
string infija = Console.ReadLine();


if (opcion == 1) 
{
    for (int i = infija.Length-1; i >=0; i--)
    {
        if (o.Contains(infija[i]))
        {
            if (infija[i] == '(')
            {
                Resultado = Resultado + pila.Pop();
                pila.Pop();
            }
            else
            {
                pila.Push(infija[i]);
            }
        }
        else
        {
            Resultado = Resultado + infija[i];
        }
    }
    if (pila.Count == 1) Resultado = Resultado + pila.Pop();

    Resultado = ReverseString(Resultado);
} 
else if( opcion == 2)
{
    for (int i = 0; i < infija.Length; i++)
    {
        if (o.Contains(infija[i]))
        {
            if (infija[i] == ')')
            {
                Resultado = Resultado + pila.Pop();
                pila.Pop();
            }
            else
            {
                pila.Push(infija[i]);
            }

        }
        else
        {
            Resultado = Resultado + infija[i];
        }


    }
    if (pila.Count == 1) Resultado = Resultado + pila.Pop();
}



Console.WriteLine(Resultado);


static string ReverseString(string input)
{
    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
