using UnityEngine;

// Класс - данные о заказе
// 
// Class - order data
public class CustomerOrder : MonoBehaviour
{
    [SerializeField] private int _requiredCapacity = 1;

    public int RequiredCapacity => _requiredCapacity;
}