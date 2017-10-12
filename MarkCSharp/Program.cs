using System;
using Library;
using static System.Console;

namespace MarkCSharp
{
	class Program
	{
		static void CallConsole(string arg) => WriteLine(arg.ToUpper());

		static string JoinArgWithNumber(string arg, int num) => arg + num * num;
		static void Main(string[] args)
		{
			var t = new Test("My Test Instance");

			//MyDel act = CallConsole;

			t.CallSomething(CallConsole);

			var result = t.CallFunc((name, count) =>
			{
				var newName = name + count.ToString();
				return newName;
			});
			WriteLine(result);

			Func<string, int, string> myFunc = JoinArgWithNumber;
			
			WriteLine(t.CallFunc(JoinArgWithNumber));
			WriteLine(t.CallFuncDel(JoinArgWithNumber));
			WriteLine(t.CallFuncDel((name, count) =>
			{
				var newName = count + name;
				return newName;
			}));
			WriteLine(t.CallFunc(myFunc));

			Read();
		}
	}
}
