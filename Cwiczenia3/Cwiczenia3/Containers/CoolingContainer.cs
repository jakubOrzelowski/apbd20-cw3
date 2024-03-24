using Cwiczenia3.Enum;

namespace Cwiczenia3.Containers;

public class CoolingContainer : Container
{
    public int NextID = 1;
    public string ProductType { get; set; }
    public int Temp { get; set; }
    
    public CoolingContainer(double conHeight, double conWeigh, double conDeep, double maxWeighOfCargo, ContainerType type, string productType, int temp) : base(conHeight, conWeigh, conDeep, maxWeighOfCargo, type)
    {
        ProductType = productType;
        Temp = temp;
        CargoWeigh = 0;
        Id = NextID;
        SeriesNumber = "KON-" + "C-" + Id;
        NextID++;
    }
}