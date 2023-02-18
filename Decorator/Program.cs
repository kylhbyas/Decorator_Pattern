// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/// Kyle Byassee
/// 2023-02-17
/// 
/// This program demonstrates inheritance and overloading functions.
/// 

namespace decorator {
    class program
    {
        interface Widget
        {
            public virtual void draw() { }
        }

        abstract class Decorator : Widget
        {
            private Widget wid;

            // public Decorator() { }

            public Decorator(Widget w)
            {
                wid = w;
            }

            public virtual void draw()
            {
                Console.Write(" holding a ");
                wid.draw();
            }
        }

        class BorderDecorator : Decorator
        {
            // calls the parent version
            public BorderDecorator(Widget w) : base(w) { }

            // calls the parent one, also prints out its name
            public override void draw()
            {
                Console.Write("BorderDecorator");
                base.draw();
            }
        }

        class ScrollDecorator : Decorator
        {
            // calls parent constructor
            public ScrollDecorator(Widget w) : base(w) { }

            // calls parent, then prints out "  ScrollDecorator"
            public override void draw()
            {
                Console.Write("ScrollDecorator");
                base.draw();
            }
        }

        class Sparkles : Decorator
        {
            public Sparkles(Widget w) : base(w) { }

            public override void draw()
            {
                Console.Write("Sparkles");
                base.draw();
            }
        }

        class TextField : Widget
        {
            private int width;
            private int height;

            public TextField(int w, int h)
            {
                width = w;
                height = h;
            }

            // print: "TextField: " + width + ", " + height
            public void draw()
            {
                Console.WriteLine("TextField: " + width + ", " + height);
            }
        }

        class DecoratorDemo
        {
            static void Main(string[] args)
            {
                //int width = 0;
                Console.WriteLine("Define Width: ");
                int width = Int32.Parse(Console.ReadLine());

                //int height = 0;
                Console.WriteLine("Define Height: ");
                int height = Int32.Parse(Console.ReadLine());

                TextField tony = new TextField(width, height);
                tony.draw();

                BorderDecorator gordon = new BorderDecorator(tony);
                gordon.draw();

                ScrollDecorator gary = new ScrollDecorator(gordon);
                gary.draw();

                Sparkles michael = new Sparkles(gary);
                michael.draw();

                Console.ReadKey();
             }
        }
    }
}