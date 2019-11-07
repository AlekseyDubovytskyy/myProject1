using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassConsole
{   class Product
    {
        string name;
        double price;
        Currency cost;
        int quantity;
        string producer;
        double weight;

        public Product() { }
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        { this.name = name; this.price = price; this.cost = cost; this.quantity = quantity; this.weight = weight; this.producer = producer; }

        public void SetName(string name) { this.name = name; }
        public void SetPrice(double price) { this.price = price; }
        public void SetCost(Currency cost) { this.cost = cost; }
        public void SetQuantity(int quantity) { this.quantity = quantity; }
        public void SetProducer(string producer) { this.producer = producer; }
        public void SetWeight(double weight) { this.weight = weight; }
        
        public string GetName() { return name; }
        public double Getprice() { return price; }
        public Currency GetCost() { return cost; }
        public int GetQuantity() { return quantity; }
        public string GetProducer() { return producer; }
        public double Getweight() { return weight; }

        public double GetPriceInUAH() {
            return price * cost.GetExRate();
        }
        
    }
    class Currency
    {
        string name;
        double ExRate;

        public Currency() { }
        public Currency(string name, double ExRate) { this.name = name; this.ExRate = ExRate; }

        public void SetNameCurrency(string name) { this.name = name; }
        public void SetExRate(float ExRate) { this.ExRate = ExRate; }
        public string GetNameCurrency() { return name; }
        public double GetExRate() { return ExRate; }
    }
    class Program
    {
        static public double GetTotalPriceInUAH(string name, Product[] prod)
        {
            double suma = 0;
            for (int i = 0; i < prod.Length; i++)
            {
                if (name == prod[i].GetName())
                {
                    suma += prod[i].GetPriceInUAH();
                }
            }
            return suma;
        }

       static public double GetTotalWeight(string name, Product[] prod)
        {
            double suma = 0;
            for (int i = 0; i < prod.Length; i++)
            {
                if (name == prod[i].GetName())
                {
                    suma += prod[i].Getweight();
                }
            }
            return suma;
        }
        static public Product[] ReadProductArray() //читає з клавіатури дані і повертає масив об’єктів типу Air-plane(n штук)
        {
            int n;
            Console.Write("Kilkist`tovariv ");
            string sN = Console.ReadLine();

            if (int.TryParse(sN, out n))
            {
                n = int.Parse(sN);
            }
            else Console.WriteLine("Intvalid number");

            Product[] prod = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nazva tovaru - ");
                string a = Console.ReadLine();
                prod[i].SetName(a);
                Console.Write("Vartist`odynytsi tovaru - ");
                prod[i].SetPrice(Double.Parse(Console.ReadLine()));
                Console.Write("Groshova odynytsia [nazva, kurs] - ");
                prod[i].SetCost(new Currency(Console.ReadLine(), Double.Parse(Console.ReadLine())));
                Console.Write("Kilkist`tovariv na skladi - ");
                prod[i].SetQuantity(Int32.Parse(Console.ReadLine()));
                Console.WriteLine();
                Console.Write("Nazva kompanii vyrobnyka - ");
                prod[i].SetProducer((Console.ReadLine()));
                Console.WriteLine();
                Console.Write("Vaga tovaru - ");
                prod[i].SetWeight(Double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            return prod;
        }
        static void PrintProduct(Product prod) {
            Console.WriteLine(prod.GetName()+"\t"+prod.GetPriceInUAH()+"Hrn\t"+prod.GetQuantity()+"Shtuk\t"+prod.GetProducer()+"\t"+prod.Getweight()+"kg");
        }

        static void PrintProducts(Product[] prod)
        {
            for(int i=0; i<prod.Length; i++)
            {
                PrintProduct(prod[i]);
            }
        }

        static public void GetProductsInfo(Product[] prod, out int max, out int min) //приймає масив об’єктів типу Airplane і повертає через out-параметри найбільший та найменший час подорожі
        {
            double[] price = new double[prod.Length];
            for (int i = 0; i < prod.Length; i++)
            {
                price[i] = prod[i].GetPriceInUAH();
            }

           
            max = 0;
            min = 0;
        }

        static void Main(string[] args)
        {
            string tryN;
            Product[] prod = new Product[100];


            while (true)
            {

                Console.WriteLine(
                    "1 - Zapys tovariv\n" +
                    "2 - Vyvid\n" +
                    "3 - Min Max cina tovaru\n" +
                    "4 - Suma dannyh tovariv\n" +
                    "5 - Vaga dannyh tovariv\n" 
                );
                tryN = Console.ReadLine();

                char check = tryN[0];
                switch (check)
                {
                    case '1': prod = ReadProductArray(); break;
                    case '2': PrintProducts(prod); break;
                    case '3':
                        int max, min;
                        GetProductsInfo(prod, out max, out min);
                        Console.WriteLine("max = {0} main = {1}", max, min); break;
                    case '4':

                        Console.WriteLine(GetTotalPriceInUAH(Console.ReadLine(), prod));break;
                    case '5':
                        Console.WriteLine(GetTotalWeight(Console.ReadLine(), prod));break;
                    case '0': return;
                }
            }
        }
    }
}
