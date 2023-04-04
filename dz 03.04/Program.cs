using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz03_04
{
    interface IStrategy
    {
        object Drive();
    }

    class Context
    {
        private IStrategy strategy;

        public Context() { }
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            var result = strategy.Drive();
            Console.WriteLine(result);
        }
    }

    class Bicycle : IStrategy
    {
        public object Drive()
        {
            return " bicycle";
        }
    }

    class Bus : IStrategy
    {
        public object Drive()
        {
            return "bus";
        }
    }

    class Taxi : IStrategy
    {
        public object Drive()
        {
            return "taxi";
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            context.SetStrategy(new Bus());
            context.DoSomeBusinessLogic();



        }
    }
}