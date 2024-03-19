using Cwiczenia3.Interfaces;

namespace Cwiczenia3.Containers;

public abstract class Container : IContainer
{
    public double CargoWeigh { get; set; }

    protected Container(double cargoWeigh)
    {
        CargoWeigh = cargoWeigh;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeigh)
    {
        throw new NotImplementedException();
    }
}