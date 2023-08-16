// See https://aka.ms/new-console-template for more information




using NoSR.Models;
using NoSR.Services;

Car car =new Car();

CarServices carServices = new CarServices();

carServices.CreateCar(car);


Console.ReadKey();
