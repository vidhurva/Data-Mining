using System;

namespace FirstDemo
{
    class Program
    {
      class client
        {
            public string name;
            public int salary;
        }

        // Derived class
        class info: client
        {
            public info(string _name, int _salary)
            {
                name = _name;
                salary = _salary;    
            }

            public void Print()
            {
                Console.WriteLine("Employee: " + name);
                Console.WriteLine("Salary: " + salary);
            }
        }

        public static void Main(string[] args)
        {
            info client_1 = new info("A", 87000);
            info client_2 = new info("B", 73600);
            info client_3 = new info("C", 65000);
            info client_4 = new info("D", 76000);
            info client_5 = new info("E", 56200);
            info client_6 = new info("F", 56900);
            info client_7 = new info("G", 92000);
            info client_8 = new info("H", 88000);
            info client_9 = new info("I", 92300);
            info client_10 = new info("J", 93560);
            info client_11 = new info("K", 86541);
            info client_12 = new info("L", 65320);
            info client_13 = new info("M", 76022);
            info client_14 = new info("N", 58000);
            info client_15 = new info("O", 57000);
            info client_16 = new info("P", 78360);
            info client_17 = new info("Q", 59630);
            info client_18 = new info("R", 69000);
            info client_19 = new info("S", 87200);
            info client_20 = new info("T", 76000);
            info client_21 = new info("U", 63000);

            client_1.Print();
            client_2.Print();
            client_3.Print();
            client_4.Print();
            client_5.Print();
            client_6.Print();
            client_7.Print();
            client_8.Print();
            client_9.Print();
            client_10.Print();
            client_11.Print();
            client_12.Print();
            client_13.Print();
            client_14.Print();
            client_15.Print();
            client_16.Print();
            client_17.Print();
            client_18.Print();
            client_19.Print();
            client_20.Print();
            client_21.Print();
            Console.ReadKey();
        }
    }
} 