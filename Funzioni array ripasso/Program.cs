class Program
{
    static void Main()
    {
        // Dichiarazioni
        int scelta = 0;
        int dim = 0;
        int[] array = new int[100];
        int x, y;
        // Elaborazione
        Console.Write("Inserire la lunghezza dell'array: ");
        dim = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < dim; i++)
        {
            Console.Write($"Inserire elemento in posizione {i}: ");
            x = Convert.ToInt32(Console.ReadLine());
            array[i] = x;
        }

        // Menù
        do
        {
            Console.Clear();
            Console.WriteLine("Premere uno seguenti tasti per selezionare l'operazione: \n\t1 - Aggiungi elemento \n\t2 - Stampa elementi \n\t3 - Stampa stringa HTML \n\t4 - Ricerca elemento \n\t5 - Elimina elemento \n\t6 - Aggiungi elemento alla posizione desiderata \n\t0 - Uscita");
            scelta = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.Write("Inserire un elemento: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (FA(array, x, ref dim))
                    {
                        Console.WriteLine("Elemento inserito");
                    }
                    else
                    {
                        Console.WriteLine("Array completo");
                    }
                    break;
                case 2:
                    for (int i = 0; i < dim; i++)
                    {
                        Console.Write(array[i] + " ");
                    }
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("<!DOCTYPE html>\r\n<html lang=\"it\">\r\n<head>\r\n    <title>Ripasso degli Array-21</title>\r\n</head>\r\n<body>");
                    Console.WriteLine(Html(array, ref dim));
                    Console.WriteLine("</body>\r\n</html>");
                    break;
                case 4:
                    Console.Write("Inserire l'elemento da ricercare: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (FR(array, x) == -1)
                    {
                        Console.WriteLine("L'elemento non è stato trovato");
                    }
                    else
                    {
                        Console.WriteLine($"L'elemento {x} è in posizione {FR(array, x)}");
                    }
                    break;
                case 5:
                    Console.Write("Inserire l'elemento da eliminare: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (FC(array, x, ref dim))
                    {
                        Console.WriteLine("L'elemento è stato cancellato");
                    }
                    else
                    {
                        Console.WriteLine("Non è stato possibile cancellare l'elemento");
                    }
                    break;
                case 6:
                    Console.Write("Inserire la posizione dove verrà inserito l'elemento: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inserire l'elemento: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (FI(array, x, y))
                        Console.WriteLine($"L'elemento {x} è stato inserito nella posizione {y}");
                    else
                        Console.WriteLine("L'elemento non è stato inserito");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }

            Thread.Sleep(1000);
        } while (scelta != 0);
    }

    // Funzione Aggiunta
    static bool FA(int[] array, int x, ref int index)
    {
        bool ins = true;
        if (index < array.Length)
        {
            array[index] = x;
            index++;
        }
        else
        {
            ins = false;
        }
        return ins;
    }

    // Funzione Html
    static string Html(int[] array, ref int dim)
    {
        string code = "    <table>\n";
        for (int i = 0; i < dim; i++)
        {
            code += "         <tr>\n";
            code += "             <td>" + array[i] + "</td>\n";
            code += "         </tr>\n";
        }
        code += "   </table>";
        return code;
    }

    // Funzione Ricerca
    static int FR(int[] array, int x)
    {
        int R = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == x)
            {
                R = i;
                break;
            }
            else
            {
                R = -1;
            }
        }

        return R;
    }
    static bool FC(int[] array, int x, ref int dim)
    {
        bool canc = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == x)
            {
                dim--;
                for (int j = i; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                canc = true;
                break;
            }
        }

        return canc;
    }

    // Funzione Inserimento
    static bool FI(int[] array, int x, int y)
    {
        bool ins = false;

        if (y < array.Length)
        {
            for (int i = 0; i < array.Length - 1; i++)
                array[i] = array[i - 1];
            array[y] = x;
            ins = true;
        }

        return FI;
    }
}
