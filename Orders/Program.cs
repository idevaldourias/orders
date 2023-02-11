using Orders.Entities;
using Orders.Entities.Enums;
using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            Enum status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int qtdItems = int.Parse(Console.ReadLine());

            Order order = new Order(status, client);

            for (int i = 1; i <= qtdItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, priceProduct);

                Console.Write("Quantity: ");
                int quantProduct = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantProduct, priceProduct, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();

            Console.WriteLine(order);
        }
    }
}