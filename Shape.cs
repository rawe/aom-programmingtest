using System;

namespace programmingtest
{
    public abstract class Shape : IComparable<Shape>
    {
        String Name {get; init;}

        public Shape(string name){
            this.Name = name;
        }
        public abstract Double GetArea();

        public int CompareTo(Shape otherShape){
            if(otherShape == null) return 1;

            var areaComparison = this.GetArea().CompareTo(otherShape.GetArea());
            if(areaComparison != 0) return areaComparison * -1;

            return this.Name.CompareTo(otherShape.Name);
        }
    }
}
