namespace ADO_Task_2;

public class Car
{
    public int Id { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }

    public Car(int Id,string marka, string model)
    {
        this.Id = Id;
        Marka = marka;
        Model = model;
    }

    public Car()
    {
        
    }
    public override string ToString()
    {
        return $"{Id}           {Marka}         {Model}";
    }
}
