using System;
namespace DesignPattern.BuilderPattern
{
    public class Director
    {
        IBuilder builder;
        //a series of steps in real life,steps are complex.
        public void Construct(IBuilder builder){
            this.builder = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }
}
