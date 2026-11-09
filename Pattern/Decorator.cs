using System;
using System.Text;

namespace DecoratorExample
{
    abstract class Tree
    {
        public abstract void Display();
    }

    class ChristmasTree : Tree
    {
        public override void Display()
        {
            Console.WriteLine("A regular green Christmas tree.");
        }
    }

    abstract class TreeDecorator : Tree
    {
        protected Tree tree;

        public TreeDecorator(Tree tree)
        {
            this.tree = tree;
        }

        public override void Display()
        {
            if (tree != null)
            {
                tree.Display();
            }
        }
    }

    class OrnamentsDecorator : TreeDecorator
    {
        public string Ornaments { get; set; }

        public OrnamentsDecorator(Tree tree, string ornaments) : base(tree)
        {
            Ornaments = ornaments;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($" - Decorated with toys: {Ornaments}.");
        }
    }

    class GarlandDecorator : TreeDecorator
    {
        public GarlandDecorator(Tree tree) : base(tree) { }

        public override void Display()
        {
            base.Display();
            Glow();
        }

        public void Glow()
        {
            Console.WriteLine(" - The string of lights is on the Christmas tree: The Christmas tree is glowing brightly!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("1. Basic Christmas tree:");
            Tree myTree = new ChristmasTree();
            myTree.Display();

            Console.WriteLine("\n2. A Christmas tree with decorations:");
            Tree treeWithOrnaments = new OrnamentsDecorator(myTree, "red balls, pinecones, a star");
            treeWithOrnaments.Display();

            Console.WriteLine("\n3. A Christmas tree with ornaments and a string of lights:");
            Tree fullyDecoratedTree = new GarlandDecorator(treeWithOrnaments);
            fullyDecoratedTree.Display();

            Console.ReadKey();
        }
    }
}