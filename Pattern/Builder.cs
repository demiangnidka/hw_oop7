using System;

namespace Builder
{
    class Program
    {
        class Pizza
        {
            string dough;
            string sauce;
            string topping;

            public Pizza() { }
            public void SetDough(string d) { dough = d; }
            public void SetSauce(string s) { sauce = s; }
            public void SetTopping(string t) { topping = t; }

            public void Info()
            {
                Console.WriteLine("Dough: {0}\nSauce: {1}\nTopping: {2}\n", dough, sauce, topping);
            }
        }

        // Abstract Builder
        abstract class PizzaBuilder
        {
            protected Pizza pizza;
            public PizzaBuilder() { }
            public Pizza GetPizza() { return pizza; }
            public void CreateNewPizza() { pizza = new Pizza(); }

            public abstract void BuildDough();
            public abstract void BuildSauce();
            public abstract void BuildTopping();
        }

        // Concrete Builder 1
        class HawaiianPizzaBuilder : PizzaBuilder
        {
            public override void BuildDough() { pizza.SetDough("cross"); }
            public override void BuildSauce() { pizza.SetSauce("mild"); }
            public override void BuildTopping() { pizza.SetTopping("ham+pineapple"); }
        }

        // Concrete Builder 2
        class SpicyPizzaBuilder : PizzaBuilder
        {
            public override void BuildDough() { pizza.SetDough("pan baked"); }
            public override void BuildSauce() { pizza.SetSauce("hot"); }
            public override void BuildTopping() { pizza.SetTopping("pepparoni+salami"); }
        }

// ============================================================

        // Concrete Builder 3
        class MargaritaPizzaBuilder : PizzaBuilder
        {
            public override void BuildDough() { pizza.SetDough("thin"); }
            public override void BuildSauce() { pizza.SetSauce("tomato"); }
            public override void BuildTopping() { pizza.SetTopping("mozzarella+basil"); }
        }

// ============================================================
        // "Director"
        class Waiter
        {
            private PizzaBuilder pizzaBuilder;
            public void SetPizzaBuilder(PizzaBuilder pb) { pizzaBuilder = pb; }
            public Pizza GetPizza() { return pizzaBuilder.GetPizza(); }

            public void ConstructPizza()
            {
                pizzaBuilder.CreateNewPizza();
                pizzaBuilder.BuildDough();
                pizzaBuilder.BuildSauce();
                pizzaBuilder.BuildTopping();
            }
        }

        // A customer ordering a pizza
        class BuilderExample
        {
            public static void Main(string[] args)
            {
                Waiter waiter = new Waiter();
                PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
                PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
                PizzaBuilder margaritaPizzaBuilder = new MargaritaPizzaBuilder();

                waiter.SetPizzaBuilder(hawaiianPizzaBuilder);
                waiter.ConstructPizza();
                Pizza pizza = waiter.GetPizza();
                Console.WriteLine("Hawaiian Pizza:");
                pizza.Info();

// ============================================================

                waiter.SetPizzaBuilder(margaritaPizzaBuilder);
                waiter.ConstructPizza();
                Pizza margarita = waiter.GetPizza();
                Console.WriteLine("Margarita Pizza:");
                margarita.Info();

// ============================================================
                Console.ReadKey();
            }
        }
    }
}