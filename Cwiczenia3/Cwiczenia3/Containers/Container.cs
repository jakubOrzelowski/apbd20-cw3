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
    public ContainerType Type { get; set; }
    public int Id { get; set; }
    private int NextID = 1;

    protected Container(double conHeight, double conWeigh, double conDeep, double maxWeighOfCargo,ContainerType type)
    {
        ConHeight = conHeight;
        ConWeigh = conWeigh;
        ConDeep = conDeep;
        MaxWeighOfCargo = maxWeighOfCargo;
        Type = type;
        CargoWeigh = 0;
        Id = NextID;
        NextID++;
    }

    public virtual void Unload()
    {
        CargoWeigh = 0;
    }

    public virtual void Load(double cargoWeigh)
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

    public override string ToString()
    {
        return $"{nameof(CargoWeigh)}: {CargoWeigh}, {nameof(ConHeight)}: {ConHeight}, {nameof(ConWeigh)}: {ConWeigh}, {nameof(ConDeep)}: {ConDeep}, {nameof(SeriesNumber)}: {SeriesNumber}, {nameof(MaxWeighOfCargo)}: {MaxWeighOfCargo}, {nameof(Type)}: {Type}";
    }
}