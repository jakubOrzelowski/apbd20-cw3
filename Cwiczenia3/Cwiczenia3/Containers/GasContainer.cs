using Cwiczenia3.Enum;
using Cwiczenia3.Exceptions;
using Cwiczenia3.Interfaces;

namespace Cwiczenia3.Containers;

public class GasContainer : Container,IHazardNotifier
{
    public int Pressure { get; set; }
    public int NextID { get; set; }


    public GasContainer(double conHeight, double conWeigh, double conDeep, double maxWeighOfCargo, ContainerType type, int pressure) : base(conHeight, conWeigh, conDeep, maxWeighOfCargo, type)
    {
        Pressure = pressure;
        CargoWeigh = 0;
        Id = NextID;
        SeriesNumber = "KON-" + "G-" + Id;
        NextID++;
    }
    
    public override void Load(double cargoWeigh)
    {
        if (cargoWeigh > MaxWeighOfCargo)
        {
            throw new OverfillException("Nie dozwolona masa cargo. kontener nie zaladowany");
        }
        else
        {
            CargoWeigh = cargoWeigh;
        }
    }

    public override void Unload()
    {
        CargoWeigh = 0.05 * CargoWeigh;

    }


    public void NotifyDanger(string seriesNumber)
    {
        Console.WriteLine("Zaszla niebezpieczna sytuacja z kontenerme o numerze: " + seriesNumber);
    }
}