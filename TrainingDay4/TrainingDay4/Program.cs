﻿using System;

namespace TrainingDay4
{

    /*internal class Product
    {
        string prodname;
        int price, quantity;
        public void setDetails(string prodname, int price, int quantity)
        {
            this.prodname = prodname;
            this.price = price;
            this.quantity = quantity;
        }
        public void getDetails()
        {
            Console.WriteLine("Product: " + prodname + "\t Price: " + price + "\t Quantity: " + quantity);
        }
    }

    internal class customer
    {
        string customername, address, contactNo;
        Product[] product;
        int i = 0;

        public void productquantity(int n)
        {
            product = new Product[n];
        }
        public void CustomerDetails()
        {
            Console.WriteLine("Enter Customer name");
            customername = Console.ReadLine();
            Console.WriteLine("Enter address");
            address = Console.ReadLine();
            Console.WriteLine("Enter contactno.");
            contactNo = Console.ReadLine();
        }
        public void addProduct(Product prod)
        {
            product[i] = prod;
            Console.WriteLine("Product Added \n");
            i++;
        }

        public void showCustomer()
        {
            Console.WriteLine("Customer Name: " + customername + "\t Address: " + address + "\t contactNo: " + contactNo);
        }
        public Product[] getProducts()
        {
            return product;
        }
    }

    internal class sales
    {
        customer c = new customer();
        public void addDetails()
        {
            c.CustomerDetails();
        }

        public void prodDetails(int n)
        {
            c.productquantity(n);
            for (int i = 0; i < n; i++)
            {
                string prodname;
                int price, quantity;
                Product prod = new Product();
                Console.WriteLine("Enter Product Name ");
                prodname = Console.ReadLine();
                Console.WriteLine("Enter price ");
                price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter quantity ");
                quantity = Convert.ToInt32(Console.ReadLine());
                prod.setDetails(prodname, price, quantity);
                c.addProduct(prod);
            }
        }

        public void showDetails()
        {
            c.showCustomer();
            Product[] prod = c.getProducts();
            for (int i = 0; i < prod.Length; i++)
            {
                prod[i].getDetails();
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            sales s = new sales();
            s.addDetails();
            Console.WriteLine("Enter the no. of products to add");
            int n = Convert.ToInt32(Console.ReadLine());
            s.prodDetails(n);
            s.showDetails();
        }
    }*/
    public abstract class Employee
    {
        public string employeeName, department, designation;
        public Salary s = new Salary();

        public abstract void setDetails(string a, int c, int d, int e, int f, int g, int h);
    }
    public class Salary
    {
        public int basic, da, hra, pf, gross, net;

    }
    public class Manager : Employee
    {

        public override void setDetails(string a, int c, int d, int e, int f, int g, int h)
        {
            this.employeeName = a;
            this.department = "Business";
            this.designation = "Manager";
            this.s.basic = c;
            this.s.da = d;
            this.s.hra = e;
            this.s.pf = f;
            this.s.gross = g;
            this.s.net = h;
        }

    }
    public class Engineer : Employee
    {

        public override void setDetails(string a, int c, int d, int e, int f, int g, int h)
        {
            this.employeeName = a;
            this.department = "software";
            this.designation = "Engineer";
            this.s.basic = c;
            this.s.da = d;
            this.s.hra = e;
            this.s.pf = f;
            this.s.gross = g;
            this.s.net = h;
        }

    }
    public class LineStaff : Employee
    {

        public override void setDetails(string a, int c, int d, int e, int f, int g, int h)
        {
            this.employeeName = a;
            this.department = "hardware";
            this.designation = "LineStaff";
            this.s.basic = c;
            this.s.da = d;
            this.s.hra = e;
            this.s.pf = f;
            this.s.gross = g;
            this.s.net = h;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.setDetails("hdfk", 15, 56, 25, 63, 45, 88);
            Console.WriteLine($"The name of employee is {m.employeeName}.\nThe department is {m.department}.\nThe designation is {m.designation}.\nThe basic is {m.s.basic}.\n The da is {m.s.da}.\nThe HRA is {m.s.hra}.\n The PF is {m.s.pf}.\n The Gross is {m.s.gross}.\n The net is {m.s.net}");
            Engineer e = new Engineer();
            e.setDetails("hdfk", 15, 56, 25, 63, 45, 88);
            Console.WriteLine();
            Console.WriteLine($"The name of employee is {e.employeeName}.\nThe department is {e.department}.\nThe designation is {e.designation}.\nThe basic is {e.s.basic}.\n The da is {e.s.da}.\nThe HRA is {e.s.hra}.\n The PF is {e.s.pf}.\n The Gross is {e.s.gross}.\n The net is {e.s.net}");
            LineStaff l = new LineStaff();
            l.setDetails("hdfk", 15, 56, 25, 63, 45, 88);
            Console.WriteLine();
            Console.WriteLine($"The name of employee is {l.employeeName}.\nThe department is {l.department}.\nThe designation is {l.designation}.\nThe basic is {m.s.basic}.\n The da is {l.s.da}.\nThe HRA is {l.s.hra}.\n The PF is {l.s.pf}.\n The Gross is {l.s.gross}.\n The net is {l.s.net}");

        }
    }
}

