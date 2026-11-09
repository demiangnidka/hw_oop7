using System;
using System.Collections.Generic;

namespace SolidTask1
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Task1
    {
        private List<Item> itemList = new List<Item>();
        public IReadOnlyList<Item> Items => itemList.AsReadOnly();

        public void CalculateTotalSum() { /* підрахунок суми */ }
        public void GetItems() { /* отримання списку */ }
        public void GetItemCount() { /* кількість позицій */ }
        public void AddItem(Item item) { itemList.Add(item); }
        public void DeleteItem(Item item) { itemList.Remove(item); }
    }

    public class OrderViewer
    {
        public void PrintOrder(Task1 order) { /* друк замовлення */ }
        public void ShowOrder(Task1 order) { /* відображення на екрані */ }
    }

    public class OrderRepository
    {
        public Task1 Load(int orderId) { return new Task1(); }
        public void Save(Task1 order) { /* збереження в БД */ }
        public void Update(Task1 order) { /* оновлення в БД */ }
        public void Delete(Task1 order) { /* видалення з БД */ }
    }

    class Program
    {
        static void Main() { }
    }
}


//class Item
//{

//}
//class Order
//{
//    private List<Item> itemList;
//    internal List<Item> ItemList
//    {
//        get
//        {
//            return itemList;
//        }
//        set
//        {
//            itemList = value;
//        }
//    }
//313
// public void CalculateTotalSum() {/*...*/}
//    public void GetItems() {/*...*/}
//    public void GetItemCount() {/*...*/}
//    public void AddItem(Item item) {/*...*/}
//    public void DeleteItem(Item item) {/*...*/}
//    public void PrintOrder() {/*...*/}
//    public void ShowOrder() {/*...*/}
//    public void Load() {/*...*/}
//    public void Save() {/*...*/}
//    public void Update() {/*...*/}
//    public void Delete() {/*...*/}
//}