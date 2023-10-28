using System.Collections;
using System.ComponentModel.Design;
using System.Linq;


Console.WriteLine("Conversiones disponibles de Infija a:");
Console.WriteLine("1 -- Prefija");
Console.WriteLine("2 -- Postfija");
Console.WriteLine("ELige a que quieres convertir tu notacion Infija:");
int opcion = int.Parse(Console.ReadLine());

while (opcion != 0 && opcion < 3)
{
    Console.WriteLine("Ingrese la notacion Infija:");
    string infija = Console.ReadLine();
    if (opcion == 1)
    {
        Console.WriteLine(InfijaToPrefija(infija));
    }
    else if (opcion == 2)
    {
        Console.WriteLine(InfijaToPostfija(infija));
    }

    infija = "";
    Console.WriteLine("ELige a que quieres convertir tu notacion Infija:");
    opcion = int.Parse(Console.ReadLine());
}


static int valor(char operador)
{
	switch (operador)
	{
        case '^':
            return 2;
            break;
		case '*' :
			return 3;
			break;
        case '/':
            return 3;
            break;
        case '-':
            return 4;
            break;
        case '+':
            return 4;
            break;

        default: 
			return int.MaxValue;
	}
}

static bool EsOperador(char operador)
{
    return (operador >= 'a' && operador <= 'z') || (operador >= 'A' && operador <= 'Z') || (operador >= '1' && operador <= '9');
}

static string ReverseString(string input)
{
    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

static string InfijaToPostfija (string infija)
{
    Stack<char> pila = new();
    string postfija = "";

    foreach (char c in infija)
    {
        if(c == '(')
        {
            pila.Push(c);
        }
        else if (c==')')
        {
            while (pila.Peek() != '(') 
            {
                postfija += pila.Pop();
            }
            pila.Pop();
        }
        else if (EsOperador(c))
        {
            postfija += c;
        }
        else
        {
            while(pila.Count != 0 && valor(c) >= valor(pila.Peek()))
            {
                postfija += pila.Pop();
            }
            pila.Push(c);
        }
        
    }
    while (pila.Count != 0)
    {
        postfija += pila.Pop();
    }
    return "Postfija: "+postfija;
}

static string InfijaToPrefija(string infija)
{
    Stack<char> pila = new();
    string prefija = "";
     
    infija = ReverseString(infija);

    foreach (char c in infija)
    {
        if (c == ')')
        {
            pila.Push(c);
        }
        else if (c == '(')
        {
            while (pila.Peek() != ')')
            {
                prefija += pila.Pop();
            }
            pila.Pop();
        }
        else if (EsOperador(c))
        {
            prefija += c;
        }
        else
        {
            while (pila.Count != 0 && valor(c) >= valor(pila.Peek()))
            {
                prefija += pila.Pop();
            }
            pila.Push(c);
        }

    }
    while (pila.Count != 0)
    {
        prefija += pila.Pop();
    }
    return "Prefija: " + ReverseString(prefija);
}
