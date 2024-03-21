using Cwiczenia3.Enum;
using Cwiczenia3.Exceptions;
using Cwiczenia3.Interfaces;

namespace Cwiczenia3.Containers;

public abstract class Container : IContainer
{
    public double CargoWeigh { get; set; }
    public double ConHeight { get; set; }
    public double ConWeigh { get; set; }
    public double ConDeep { get; set; }
    public string SeriesNumber { get; set; }
    public double MaxWeighOfCargo { get; set; }
    public int ID { get; set; }
    private int NextID = 0;

    protected Container(double conHeight, double conWeigh, double conDeep, double maxWeighOfCargo,ContainerType e)
    {
        ConHeight = conHeight;
        ConWeigh = conWeigh;
        ConDeep = conDeep;
        MaxWeighOfCargo = maxWeighOfCargo;
        Unload();
        // if(e.Equals(ContainerType.Liquid))
    }

    public void Unload()
    {
        CargoWeigh = 0;
    }

    public virtual void Load(double cargoWeigh)
    {
        if (cargoWeigh > MaxWeighOfCargo)
        {
            throw new OverfillException();
        }
        else
        {
            CargoWeigh = cargoWeigh;
        }
    }
}