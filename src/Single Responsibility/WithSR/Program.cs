// See https://aka.ms/new-console-template for more information


using WithSR.Data;
using WithSR.Models;
using WithSR.Services;


Context Context = new WithSR.Data.Context();
Car car = new Car();

CarServices carServices = new CarServices(Context);

carServices.CreateCar(car);


Console.ReadKey();