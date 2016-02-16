using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//bool _b = true;  // true / false
			//bool _test = 5>100;

			int[] _i=new int[] {4,3,2};
			int _ui= Convert.ToInt32( Console.ReadLine());
			bool _check01= _ui <=_i.Length;
			bool _check02= _ui>0;

			bool _exp01 = _check01 && _check02; //логическо и &&
			bool _exp02 = _check01 || _check02; ////логическо или ||
			bool _exp03=!_check01;

			Console.WriteLine ("Логическо И: "+ _exp01);
			Console.WriteLine ("Логическо ИЛИ: "+ _exp02);
			Console.WriteLine ("Отрицани на "+ _check01.ToString()+": "+_exp03);
		}
	}
}
