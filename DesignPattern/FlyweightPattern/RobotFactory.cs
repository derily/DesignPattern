using System;
using System.Collections.Generic;

namespace DesignPattern.FlyweightPattern
{
    public class RobotFactory
    {
        Dictionary<string, IRobot> shapes = new Dictionary<string, IRobot>();
        public int TotalObjectsCreated{
            get { return shapes.Count; }
        }
        public IRobot GetRobotFromFactory(string robotType){
            IRobot robotCategory = null;
            if(shapes.ContainsKey(robotType)){
                robotCategory = shapes[robotType];
            }else{
                switch(robotType){
                    case "Small":
                        robotCategory = new SmallRobot();
                        shapes.Add("Small", robotCategory);
                        break;
                    case "Large":
                        robotCategory = new LargeRobot();
                        shapes.Add("Large", robotCategory);
                        break;
                    default:
                        throw new Exception("Robot factory can create only small and large robots");
                }
            }
            return robotCategory;
        }
    }
}
