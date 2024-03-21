using Cwiczenia3.Enum;
using Cwiczenia3.Interfaces;

namespace Cwiczenia3.Containers;

public class LiquidContainer : Container,IHazardNotifier
{
    public bool IsCargoDanger { get; set; }
    public int NextID = 1;
    public LiquidContainer(double conHeight, double conWeigh, double conDeep, double maxWeighOfCargo,ContainerType type, bool isCargoDanger) : base(conHeight,conWeigh,conDeep,maxWeighOfCargo,type)
    {
        IsCargoDanger = isCargoDanger;
        CargoWeigh = 0;
        Id = NextID;
        SeriesNumber = "KON-" + "L-" + Id;
        NextID++;
    }
    
    public override void Load(double cargoWeigh)
    {
        if (IsCargoDanger)
        {
            MaxWeighOfCargo /= 2;
        }
        else
        {
            MaxWeighOfCargo = cargoWeigh * 0.9;
        }

        if (cargoWeigh > MaxWeighOfCargo)
        {
            NotifyDanger(SeriesNumber);
            CargoWeigh = 0;
        }
        else
        {
            CargoWeigh = cargoWeigh;
        }
    }

    public void NotifyDanger(string seriesNumber)
    {
        Console.WriteLine("Na konterner o numerze " + seriesNumber + "zostala podjeta proba zaladowania niedozwolonej wagi towaru ");
    }
}