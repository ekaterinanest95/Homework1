    Console.Write("Введите чило N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    int count = 1;

    while (count <= numberN)
    {
        if(count %2 == 0)
        {
            Console.WriteLine(count);
            count++;
        }
        else
        {
            count++;
        }    
    }


