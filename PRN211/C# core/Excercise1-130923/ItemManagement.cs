// See https://aka.ms/new-console-template for more information
using Excercise1_130923;

namespace MyExercises {
    internal class ItemManagement {
        private static List<Order> orderList = new List<Order>();

        public static List<Order> getOrderList() { return orderList; }

        public void addOrder(Order order) {
/*            //check if the order List is empty or not
            if (orderList.Count() == 0) {
                orderList.Add(new Order(1));
            }
            else {
                orderList.Add(orderList.FindLastIndex());
            }*/
        
        }

        public void removeOrderById(int id) { orderList.RemoveAt(id); }
    }
}