using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public delegate void MyDel(string arg);
	public delegate string FuncDel(string arg, int num);
	public class Test
    {
	    public string Name { get; set; }
	    public Test(string name)
	    {
		    Name = name;
	    }

	    public void CallSomething(MyDel callback)
	    {
		    callback(Name);
	    }

	    public string CallFunc(Func<string, int, string> someFunc) => someFunc(Name, 5);
		public string CallFuncDel(FuncDel someFunc) => someFunc(Name, 5);


	}
}
