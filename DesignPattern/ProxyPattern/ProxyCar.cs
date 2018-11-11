using System;
namespace DesignPattern.ProxyPattern
{
    public class ProxyCar:ICar
    {
        private Driver driver;
        private ICar realCar;
        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            this.realCar = new Car();
        }

        public void DriveCar()
        {
            //pre checking
            if(driver.Age<16){
                Console.WriteLine("Sorry,the driver is too young to driver");
            }else{
                this.realCar.DriveCar();
            }
        }
    }
}
