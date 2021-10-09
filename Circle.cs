using System;


namespace programmingtest
{
    public class Circle : Shape
    {
        public Double Radius {get; set;}

        public Circle(string name, Double radius) : base(name) {
            this.Radius = radius;
        }
        public override Double GetArea(){
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public override string ToString()
        {
            return   String.Format("Radius = {0}; Area = {1}",  this.Radius.ToString(), this.GetArea().ToString());
        }
    }
}
