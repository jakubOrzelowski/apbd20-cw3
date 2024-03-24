using System.ComponentModel;
using System.Text;
using Container = Cwiczenia3.Containers.Container;

namespace Cwiczenia3.Ships;

public class ContaierShip
{
    public int MaxVelocity { get; set; }
    public int MaxNumOfContainers { get; set; }
    public int MaxWeightOfContainers { get; set; }
    public List<Containers.Container> Containers { get; set; }

    public ContaierShip(int maxVelocity, int maxNumOfContainers, int maxWeightOfContainers)
    {
        MaxVelocity = maxVelocity;
        MaxNumOfContainers = maxNumOfContainers;
        MaxWeightOfContainers = maxWeightOfContainers;
        Containers = new List<Container>();
    }

    public void AddContainer(Containers.Container container)
    {
        Containers.Add(container);
    }

    public void AddContainers(List<Containers.Container> containers)
    {
        for (int i = 0; i < containers.Count; i++)
        {
            Containers.Add(containers[i]);
        }
    }

    public void RemoveContainer(string seriesNumber)
    {
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].SeriesNumber.Equals(seriesNumber))
            {
                Containers.Remove(Containers[i]);
            }
        }
    }

    public void ChangeContainers(string seriesNumber, Containers.Container con2)
    {
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].SeriesNumber.Equals(seriesNumber))
            {
                Containers.Remove(Containers[i]);
            }
        }
        Containers.Add(con2);
    }

    public void MoveConToAnotherShip(Container container, ContaierShip contaierShip)
    {
        Containers.Remove(container);
        contaierShip.AddContainer(container);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append($"{nameof(MaxVelocity)}: {MaxVelocity}, ");
        sb.Append($"{nameof(MaxNumOfContainers)}: {MaxNumOfContainers}, ");
        sb.Append($"{nameof(MaxWeightOfContainers)}: {MaxWeightOfContainers}, ");

        sb.Append($"{nameof(Containers)}: \n[");
        for (int i = 0; i < Containers.Count; i++)
        {
            sb.Append(Containers[i]);
            if (i < Containers.Count - 1)
                sb.Append(", \n");
        }
        sb.Append("]\n");

        return sb.ToString();
    }
}