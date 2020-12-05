using System;

namespace Abstract_Factory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FactoryProducer factoryProducer = new FactoryProducer();
            IAbstractFactory abstractFactory = factoryProducer.getFactory("normal");
            IShape shape = abstractFactory.getShape("square");
            shape.draw();
            factoryProducer.getFactory("rounded").getShape("roundedRectangle").draw();
            */

            MainFactory mainFactory = new MainFactory();

            AbstractFactory shapeFactory = mainFactory.GetFactory("shape");
            IShape circle = shapeFactory.getShape("circle");
            circle.draw();

            AbstractFactory colorFactory = mainFactory.GetFactory("color");
            IColor red = colorFactory.getColor("red");
            red.fill();

            Console.ReadKey();
        }
    }

    public class MainFactory
    {
        public AbstractFactory GetFactory(string factoryType)
        {
            if(factoryType == "shape")
            {
                return new ShapeFactory();
            }
            else if(factoryType == "color")
            {
                return new ColorFactory();
            }
            else
            {
                return null;
            }
        }
    }

    public abstract class AbstractFactory
    {
        public abstract IShape getShape(string shape);
        public abstract IColor getColor(string color);
    }

    public class ShapeFactory : AbstractFactory
    {
        public override IColor getColor(string color)
        {
            throw new NotImplementedException();
        }

        public override IShape getShape(string shape)
        {
            if(shape == "circle")
            {
                return new Circle();
            }
            else if(shape == "rectangle")
            {
                return new Rectangle();
            }
            else if(shape == "square")
            {
                return new Square();
            }
            else
            {
                return null;
            }
        }
    }

    public class ColorFactory : AbstractFactory
    {

        public override IColor getColor(string color)
        {
            if (color == "red")
            {
                return new Red();
            }
            else if (color == "green")
            {
                return new Green();
            }
            else if (color == "blue")
            {
                return new Blue();
            }
            else
            {
                return null;
            }
        }

        public override IShape getShape(string shape)
        {
            throw new NotImplementedException();
        }
    }


    public interface IShape
    {
        public void draw();
    }

    public interface IColor
    {
        public void fill();
    }

    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("I am a Circle");
        }
    }

    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("I am a Rectangle");
        }
    }

    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("I am a Square");
        }
    }


    public class Red : IColor
    {
        public void fill()
        {
            Console.WriteLine("I am a Red");
        }
    }

    public class Green : IColor
    {
        public void fill()
        {
            Console.WriteLine("I am a Green");
        }
    }

    public class Blue : IColor
    {
        public void fill()
        {
            Console.WriteLine("I am a Blue");
        }
    }







    /*
public class FactoryProducer
{
    public IAbstractFactory getFactory(string shape)
    {
        if(shape == "normal")
        {
            return new ShapeFactory();
        }
        else if (shape == "rounded")
        {
            return new RoundedShapeFactory();
        }
        else
        {
            return null;
        }
    }
}

public interface IAbstractFactory
{
    public IShape getShape(string shape);
}

public class ShapeFactory : IAbstractFactory
{
    public IShape getShape(string shape)
    {
        if (shape == "rectangle")
        {
            return new Rectangle();
        }
        else if (shape == "square")
        {
            return new Square();
        }
        else
        {
            return null;
        }
    }
}

public class RoundedShapeFactory : IAbstractFactory
{
    public IShape getShape(string shape)
    {
        if (shape == "roundedRectangle")
        {
            return new RoundedRectangle();
        }
        else if (shape == "roundedSquare")
        {
            return new RoundedSquare();
        }
        else
        {
            return null;
        }
    }
}

public interface IShape
{
    public void draw();
}

public class Rectangle : IShape
{
    public void draw()
    {
        Console.WriteLine("I am a Rectangle");
    }
}

public class Square : IShape
{
    public void draw()
    {
        Console.WriteLine("I am a Square");
    }
}

public class RoundedRectangle : IShape
{
    public void draw()
    {
        Console.WriteLine("I am a RoundedRectangle");
    }
}

public class RoundedSquare : IShape
{
    public void draw()
    {
        Console.WriteLine("I am a RoundedSquare");
    }
}
*/


}
