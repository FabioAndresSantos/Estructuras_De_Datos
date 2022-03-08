using System;
public class soma
{

	public static void Main()
	{

		Console.WriteLine("Hola");
		int N, n;

		Console.WriteLine("Escribe un nuemero que cumpla con la conjetura Collatz ");
		N = int.Parse(Console.ReadLine());
		n = N;

		if (N == 1)
		{
			Console.WriteLine("Es imposible realizar la conjetura el valor es 1 ");
			System.Console.ReadLine();
		}
		else
		{
			Console.WriteLine("La conjetura Collatz es: ");


			while (n > 1)

			{
				if (n % 2 == 0)


				{
					n = (n / 2);
					Console.WriteLine(" " + n);

				}
				else
				{
					n = (n * 3) + 1;
					Console.WriteLine(" " + n);
				}
			}

		}
		Console.WriteLine("Fin");
		System.Console.ReadLine();

	}
}
