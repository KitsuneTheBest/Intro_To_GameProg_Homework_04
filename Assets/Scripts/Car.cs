using UnityEngine;

// Basic abstract class for machines(chain)
public abstract class Car : MonoBehaviour, ICustomСar
{
    [SerializeField] private int _capacity = 2;

    // The next machine for the chain
    public Car NextCar { get; set; }
    private string CarName => gameObject.name;
    
    public void ToOrder(CustomerOrder order)
    {
        if (order.RequiredCapacity <= _capacity)
        {
            print("The car is on the way - " + CarName);
            return;
        }

        if (NextCar != null)
        {
            print("This car is not eligible  - " + CarName);
            NextCar.ToOrder(order);
            return;
        }

        print("No eligible cars found");
    }
}