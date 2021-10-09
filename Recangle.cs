using System;


namespace programmingtest
{
    public class Rectangle : Shape
    {
        Double Width {get; set;} = 0;
        Double Height {get; set;} = 0;

        public Rectangle(string name, Double width, Double height) : base(name) {
            this.Width = width;
            this.Height = height;
        }
        public override Double GetArea(){
            return this.Width * this.Height;
        }

        public override string ToString()
        {
            return   String.Format("Width x Height = {0} x {1}; Area = {2}",  this.Width.ToString(), this.Height.ToString(), this.GetArea().ToString());
        }
    }
}
