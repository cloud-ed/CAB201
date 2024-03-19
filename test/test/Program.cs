using System.Runtime.CompilerServices;

namespace test
{
    /*
    public interface IMovable
    {
        public void Move(int dx, int dy);
    }

    public abstract class Movable : IMovable
    {
        public Movable() { }
        public abstract void Move(int dx, int dy);
    }

    public class Point : Movable
    {
        private int x, y;
        public Point(int x, int y)
        {
            this.y = y;
            this.x = x;
        }
        public override void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
    }
    */

    /*
    public class BankAccount
    {
        private string name { get; }
        public readonly int accountNr;
        public readonly double balance;
        public readonly double interestRate;
        public BankAccount(string name, int accountNr, double balance, double interestRate)
        {
            this.name = name;
            this.accountNr = accountNr;
            this.balance = balance;
            this.interestRate = interestRate; 
        }
        
        public BankAccount(string name, int accountNr, double interestRate)
        {
            this.name = name;
            this.accountNr = accountNr;
            this.interestRate= interestRate;
            balance = 0;
        }

        private BankAccount Change(double newBalance)
        {
            return new BankAccount(name, accountNr, newBalance, interestRate);
        }
    }
    */

    public abstract class Student
    {
        private string name;
        public Student(string name) { this.name = name; }
    }

    public class HighschoolStudent : Student
    {
        private string house;
        public HighschoolStudent(string name, string house) : base(name) { this.house = house; }
    }

    public class UniversityStudent : Student
    {
        private double GPA;
        public UniversityStudent(string name, double GPA) : base(name) { this. GPA = GPA; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}