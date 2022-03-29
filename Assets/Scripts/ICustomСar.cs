interface ICustomСar
{
    Car NextCar { get; set; }
    void ToOrder(CustomerOrder order);
}