using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to HayWhy Berry's shop. Please place your demands\n\n");
			double price = GetPrice();
			int qty = GetQuantity();
			double subtotal = price * qty;
			Console.WriteLine("Price entered = {0} and Quantity ordered = {1}", price.ToString("C"), qty);
			CalcDiscount(subtotal, qty);

		}

		private static double GetPrice()
		{
			Console.Write("Kindly, enter a price ");
			double price = Convert.ToDouble(Console.ReadLine());

			return price;
		}

		private static int GetQuantity()
		{
			Console.Write("How many of this do you wanna buy? ");
			int qty = Convert.ToInt32(Console.ReadLine());

			return qty;
		}

		private static void CalcDiscount(double subtotal, int qty)
		{
			double discount;
			if (qty < 10)
				discount = 0;
			else
				discount = 0.10;

			double discountedTotal = discount * subtotal;
			double total = subtotal - discountedTotal;
			Console.WriteLine("Sub Total = {0} \nDiscount Amount is {1} \nTotal is {2}", subtotal.ToString("C"), discountedTotal.ToString("C"), total.ToString("C"));
			Console.ReadLine();
		}
	}
}
