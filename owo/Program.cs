//int n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    string case1 = Console.ReadLine();
//    string case2 = Console.ReadLine();
//    string salida ="";

//    if (case1.Length > case2.Length)
//    {
//        for (int j = 0; j < case1.Length; j++)
//        {
//            if (j < case2.Length)
//            {
//                salida = salida + case1[j] + case2[j];
//            }
//            else
//            {
//                salida = salida + case1[j];
//            }
//            Console.WriteLine(salida);
//        }


//    }
//    else
//    {
//        for (int k = 0; k < case2.Length; k++)
//        {
//            if (k < case1.Length)
//            {
//                salida = salida + case1[k] + case2[k];
//            }
//            else
//            {
//                salida = salida + case2[k];
//            }
//            Console.WriteLine(salida);
//        }
//    }

//}

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string case1 = Console.ReadLine();
    string case2 = Console.ReadLine();
    string salida = "";

    int maxLength = Math.Max(case1.Length, case2.Length);

    for (int j = 0; j < maxLength; j++)
    {
        if (j < case1.Length)
        {
            salida += case1[j];
        }

        if (j < case2.Length)
        {
            salida += case2[j];
        }

        
    }
    Console.WriteLine(salida);
}