namespace Geometry
{
    public abstract class GeometricFigure
    {
      public string Name { get; set; }
        public GeometricFigure(string name) => Name = name;

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name,-12}:=> Area: {GetArea(),10:F5}, Perimeter: {GetPerimeter(),10:F5}";
        }

    }

    public class Square : GeometricFigure
    {
        protected double _a;
        public double A 
        { 
            get => _a;
            set
            {
                ValidateA(value);    
                _a = value;
            }
        }

        public Square(string name, double a) : base(name)
        {   
            A = a; 
        }
        private void ValidateA(double value)
        {
            if (value <= 0)
                throw new Exception("A is invalid");
        }

        public override double GetArea() => A * A;
        public override double GetPerimeter() => 4 * A;
    }

    public class Circle : GeometricFigure
    {
        private double _r;
        public double R 
        { 
            get => _r;
            set
            {
                ValidateR(value);
                _r = value;

            }
        }

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }
        private void ValidateR(double value)
        {
            if (value <= 0)
                throw new Exception("R is invalid");
        }

        public override double GetArea() => Math.PI * R * R;
        public override double GetPerimeter() => 2 * Math.PI * R;

    }

    public class Rhombus : Square
    {
        private double _d1, _d2;
        public double D1 
        { 
            get => _d1;
            set
            {
                ValidateD1(value);
                _d1 = value;
            }
        }
        public double D2 
        { 
            get => _d2;
            set
            {
                ValidateD2(value);
                _d2 = value;
            }
        }

        public Rhombus(string name, double d1, double d2, double a) : base(name, a)
        {
            D1 = d1; 
            D2 = d2;
        }

        private void ValidateD1(double value)
        {
            if (value <= 0)
                throw new Exception("D1 is invalid");
        }
        private void ValidateD2(double value)
        {
            if (value <= 0)
                throw new Exception("D2 is invalid");
        }

        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 4 * A;
    }

    public class Kite : Rhombus
    {

        private double _b;
        public double B 
        { 
            get => _b;
            set
            {
                ValidateB(value);
                _b = value;
            }
        }
        public Kite(string name, double d1, double d2, double a, double b) : base(name, d1, d2, a)
        {
            B = b;
        }
        private void ValidateB(double value)
        {
            if (value <= 0)
                throw new Exception("B is invalid");
        }
        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 2 * (A + B);
        
    }

    public class Rectangle : Square
    {
        private double _b;
        public double B 
        { 
            get => _b;
            set
            { 
                ValidateB(value);
                _b = value;
            }
        }
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }
        private void ValidateB(double value)
        {
            if (value <= 0)
                throw new Exception("B is invalid");
        }
        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
    }

    public class Triangle : Rectangle
    {
        private double _c, _h;
        public double C 
        { 
            get => _c; 
            set
            {
                 ValidateC(value);
                _c = value;
            }
        }
        public double H
        {
            get => _h;
            set
            {
                 ValidateH(value);
                _h = value;
            }
        }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c; 
            H = h;
        }
        private void ValidateC(double value)
        {
            if (value <= 0)
                throw new Exception("C is invalid");
        }
        private void ValidateH(double value)
        {
            if (value <= 0)
                throw new Exception("H is invalid");
        }


        public override double GetArea() => (B * H) / 2;
        public override double GetPerimeter() => A + B + C;

    }

    public class Parallelogram : Rectangle
    {
        private double _h;
        public double H 
        { 
            get => _h;
            set
            {
                ValidateH(value);
                _h = value;
            }
        }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }
        private void ValidateH(double value)
        {
            if (value <= 0)
                throw new Exception("H is invalid");
        }

        public override double GetArea() => B * H;
        public override double GetPerimeter() => 2 * (A + B);

    }

    public class Trapeze : Triangle
    {
        private double _d;
        public double D 
        { 
            get => _d;
            set
            {
                ValidateD(value);
                _d = value;
            }
        }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
        }
        private void ValidateD(double value)
        {
            if (value <= 0)
                throw new Exception("D is invalid");
        }

        public override double GetArea() => ((B + D) * H) / 2;
        public override double GetPerimeter() => A + B + C + D;
    }

}

