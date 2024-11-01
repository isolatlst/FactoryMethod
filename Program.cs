using System;

namespace FactoryMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FactoryMethod deliveryLogistic = new CreateRoadDelivery();
            //deliveryLogistic = new CreateSeaDelivery();
            IDeliver concreteDeliveryVehicle = deliveryLogistic.Create();
            concreteDeliveryVehicle.Deliver();
        }

        #region Abstractions
            public interface IDeliver
            {
                void Deliver();
            }
        
            public abstract class FactoryMethod
            {
                public abstract IDeliver Create();
            }
        #endregion
        
        #region ConcreteCreator
            public class CreateRoadDelivery : FactoryMethod
            {
                public override IDeliver Create() => new Truck();
            }
            
            public class CreateSeaDelivery : FactoryMethod
            {
                public override IDeliver Create() => new Ship();
            }
        #endregion
        
        #region ConcreteProduct
            public class Truck : IDeliver
            {
                public void Deliver()
                {
                    Console.WriteLine("Truck Delivered");
                }
            }

            public class Ship : IDeliver
            {
                public void Deliver()
                {
                    Console.WriteLine("Ship Delivered");
                }
            }
        #endregion
    }
}