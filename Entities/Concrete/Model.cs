using Core.Entities;

namespace Entities.Concrete;

public class Model : Entity<int>
{
    public int BrandId { get; set; } // normalizasyon
    public string Name { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId {  get; set; }
    public decimal DailyPrice {  get; set; }
   public short Year { get; set; }

    //Her modelin bir markaya ait olması gerekiyorsa ve BrandId zaten bu bilgiyi içeriyorsa,
    //Brand özelliği nullable olmasına gerek yok
    //public Brand Brand { get; set; }
    //eğer her modelin bir markaya ait olması zorunlu değilse
    //ve bazı modellerin markası tanımlanmamışsa, o zaman nullable olması mantıklı

    //lazy loading
    public Brand? Brand { get; set; } = null; //one-to-one iliskisi
    public Transmission? Transmission { get; set; } = null; //one-to-one iliskisi
    public Fuel? Fuel { get; set; } = null; //one-to-one iliskisi

    public ICollection<Car>? Cars { get; set; } = null; // model ile car arasında one-to-many  iliskisi var

    public Model()
    {
        
    }
    public Model(int brandId, string name, int fuelId, int transmissonId, decimal dailyPrice, short year)
    {
        BrandId = brandId;
        Name = name;
        FuelId = fuelId;
        TransmissionId = transmissonId;
        DailyPrice = dailyPrice;
        Year = year; 
    }
}
