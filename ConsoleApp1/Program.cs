using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入一正整數(N)");
			int num = Convert.ToInt32(Console.ReadLine());
			Calculator op = new Calculator(num);
			Console.WriteLine($"1~{num}的總和是:" + op.CalculateSum());
			Console.WriteLine($"{num}是:" + op.ValueEvenOdd());
			Console.WriteLine($"{num}!是:" + op.CalculateMultiply());
		}
	}
	class Calculator
	{
		public int num { get; set; }
		public Calculator(int a)
		{
			num = a;
		}
		public int CalculateSum()
		{
			int sum = (num + 1) * num / 2;
			return sum;
		}
		public string ValueEvenOdd()
		{
			string message = (num % 2 == 0) ? "偶數" : "奇數";
			return message;
		}
		public int CalculateMultiply()
		{
			int factorialCount = 1;
			for (int k = 1; k <= num; k++)
			{ factorialCount *= k; }
			return factorialCount;
		}
	}
}
