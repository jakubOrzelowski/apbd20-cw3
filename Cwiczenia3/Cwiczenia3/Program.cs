using Cwiczenia3.Containers;
using Cwiczenia3.Enum;
using Cwiczenia3.Ships;

Container container1 = new LiquidContainer(5.5,2100,2.4,5000,ContainerType.Liquid,true);
Container container2 = new GasContainer(5.4,2100,3.8,1400,ContainerType.Gas,2000);
Container container3 = new CoolingContainer(5.4,2100,3.8,1400,ContainerType.Gas,"banany",12);

container1.Load(500);
container2.Load(599);
container3.Load(1300);

ContaierShip contaierShip = new ContaierShip(30, 4,7000);
List<Container> containers = new List<Container>();
containers.Add(container1);
containers.Add(container2);
containers.Add(container3);

contaierShip.AddContainers(containers);
container2.Unload();

Container container4 = new GasContainer(5.5, 2300, 3.8, 4000, ContainerType.Gas, 2500);
contaierShip.ChangeContainers(container2.SeriesNumber,container4);

Console.WriteLine(contaierShip.ToString());
Console.WriteLine(container2.ToString());
Console.WriteLine(container4.ToString());

Container container5 = new CoolingContainer(4.4, 1900, 2.2, 6000, ContainerType.Gas, "zelki", 5);
Container container6 = new LiquidContainer(5.2,2150,2.5,5500,ContainerType.Liquid,false);

ContaierShip contaierShip2 = new ContaierShip(25,3,5000);
contaierShip2.AddContainer(container5);
contaierShip2.AddContainer(container6);

Console.WriteLine(contaierShip2.ToString());

contaierShip.MoveConToAnotherShip(container1,contaierShip2);

Console.WriteLine(contaierShip.ToString());
Console.WriteLine(contaierShip2.ToString());