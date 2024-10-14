using csv1;

        Console.WriteLine("Bem vindo a calculadora simples !!\n");   
        Console.WriteLine("Escolha uma operação!!\n");
        Console.WriteLine("1. Soma +\n");
        Console.WriteLine("2. Multiplicação *\n");
        Console.WriteLine("3. Divisão / \n");
        Console.WriteLine("4. Subtração -\n");

        int metodo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("---------------------------------------------------------------------------------------------------");

        Console.WriteLine("\nDigite um número");
        double num1 = double.Parse(Console.ReadLine()); 

        Console.WriteLine("\nDigite outro número");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch(metodo){
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"Resultado : { num1} + {num2} = {resultado}");
                break;
            case 2:
                resultado = num1 * num2;
                Console.WriteLine($"Resultado : { num1} * {num2} = {resultado}");
                break;
            case 3:
                resultado = num1 / num2;
                Console.WriteLine($"Resultado : { num1} / {num2} = {resultado}");
                break;
            case 4:
                resultado = num1 - num2;
                Console.WriteLine($"Resultado : { num1} - {num2} = {resultado}");
                break;

                 default:
            Console.WriteLine("\nPor gentileza escolha uma opção plaúsivel");
            break;
        }
       

        

