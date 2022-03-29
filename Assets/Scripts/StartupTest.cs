using UnityEngine;

// Класс теста цепочки обязанностей
// 
// Chain of Responsibility Test Class
public class StartupTest : MonoBehaviour
{
    [SerializeField] private CustomerOrder _order;
    [SerializeField] private Car _passenger, _minibus, _truck;

    private void Start()
    {
        _passenger.NextCar = _minibus;
        _minibus.NextCar = _truck;

        _passenger.ToOrder(_order);
    }
}