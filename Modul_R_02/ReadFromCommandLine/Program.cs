using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0;

			//Въвеждане на входни параметри
			Console.Write("Моля въведете а:");
			b=Convert.ToInt32( Console.ReadLine ());

			//Печат на резултат
			Console.WriteLine ("Резултата a + b е "+(a+b).ToString()+"\n");
			string test = "1";
			test += ",2";
			test += ",100";
			test += ",4";
			test += ",5";

			Console.WriteLine ("Събиране с += : " + test + "\n");

			test = test.Replace (",", ";");
			Console.WriteLine ("Работа с Repleace += : " + test + "\n");

			Console.WriteLine ("3-ти знак : " + test.Split(';')[2]);

			string d = "Hello", e = "World";
			object f = d + " " + e+"\n";
			Console.WriteLine (f);

			string A1 = (string)f;
			Console.WriteLine (A1);

			Console.Write("Моля въведете число или цифра:");
			int B1=Convert.ToInt32( Console.ReadLine ());

			Console.Write("Моля дума:");
			string C1=( Console.ReadLine ());

			//string D1 = B1.ToString; // + " " + C1 + "\n";
			Console.WriteLine (B1.ToString().Length +" "+C1);

		}
	}
}
