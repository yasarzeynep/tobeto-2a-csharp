using Core.Entities;

namespace Entities.Concrete;

public class Model : Entity<int>
{
    public int BrandId { get; set; }
    public string Name { get; set; }
    //public short Year { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId {  get; set; }
    public decimal DailyPrice {  get; set; }

    //Her modelin bir markaya ait olması gerekiyorsa ve BrandId zaten bu bilgiyi içeriyorsa,
    //Brand özelliği nullable olmasına gerek yok
    public Brand Brand { get; set; }

    //eğer her modelin bir markaya ait olması zorunlu değilse
    //ve bazı modellerin markası tanımlanmamışsa, o zaman nullable olması mantıklı
    //public Brand? Brand { get; set; } = null;

    public Transmission Transmission { get; set; }
    public Fuel Fuel { get; set; } = null; //???

    public Model()
    {
        
    }
}
