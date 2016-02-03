using System;

namespace Modul_R_02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
	
			//Дефиниране на променливи
			int a=0, b=0;
			int sum = 0;

			//Събиране на числа
			a=10;
			b = 5;
			sum = a + b;

			//писане в конзолата
			Console.Write(a);
			Console.Write(" + ");
			Console.Write ( b );
			Console.Write (" = ");
			Console.WriteLine(sum);
		
			// Допълнителни оператори
			Console.WriteLine("\nИзползване на +=");
			a+=b;  //а=10+5, a=a+b
			Console.WriteLine ( a );

			Console.WriteLine("\nИзползване на -=");
			a-=b;  //а=10-5, a=a-b
			Console.WriteLine ( a );	

			Console.WriteLine("\nИзползване на *=");
			a*=b;  //а=10*5, a=a*b
			Console.WriteLine ( a );
			Console.WriteLine("\nИзползване на ++");
			a++;  // a=a+1
			Console.WriteLine ( a );

			Console.WriteLine("\nИзползване на --");
			a--;  // a=a-1
			Console.WriteLine ( a );

			Console.WriteLine ("Стандартно деление: " + (14 / 4).ToString ()); //->2 (7/3 = 2.3333)
			Console.WriteLine ("Остатък от деление: " + (14 % 4).ToString ()); //->1 (1/3 = 0.3333)
		}
	}
}
