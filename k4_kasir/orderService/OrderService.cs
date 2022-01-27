using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k4_kasir.orderService;

namespace k4_kasir.orderService {
  class OrderService {
    // jangan mengubah code dibawah ini !
    private static int countFoodKey = 0, countDrinkKey = 0, totalPrice = 0, promo = 0;
    private static Dictionary<int, Food> foodPil = new Dictionary<int, Food>();
    private static Dictionary<int, Drink> drinkPil = new Dictionary<int, Drink>();

    public void addMakanan(string namaBarang, int hargaBarang, int jumlahBeli, int jumlahPromo, bool[] optional, string idBarang) {
      promo += jumlahPromo;
      Food makanan = new Food(namaBarang, hargaBarang, idBarang, optional[0], optional[1], optional[2]);
      makanan.setJumlahBeli(jumlahBeli);

      foodPil.Add(countFoodKey, makanan);
      countFoodKey += 1;
    }

    public void addMinuman(string namaBarang, int hargaBarang, int jumlahBeli, int jumlahPromo, bool[] optional, string idBarang) {
      promo += jumlahPromo;
      Drink minuman = new Drink(namaBarang, hargaBarang, idBarang, optional[0]);
      minuman.setJumlahBeli(jumlahBeli);

      drinkPil.Add(countDrinkKey, minuman);
      countDrinkKey += 1;
    }
    
    public void clearAll() {
      foodPil.Clear();
      drinkPil.Clear();
      totalPrice = 0;
      promo = 0;
      countDrinkKey = 0;
      countFoodKey = 0;
    }

    public Dictionary<int, Food> getOrderListMakanan() {
      int count = 0;
      var orderList = new Dictionary<int, Food>();

      foreach (var order in foodPil) {
        orderList.Add(count, order.Value);
        count++;
      }

      return orderList;
    }

    public Dictionary<int, Drink> getOrderListMinuman() {
      int count = 0;
      var orderList = new Dictionary<int, Drink>();

      foreach (var order in drinkPil) {
        orderList.Add(count, order.Value);
        count++;
      }

      return orderList;
    }

    public int getSubTotalPriceOfOrders() {
      totalPrice = 0;

      if (foodPil.Count > 0) {
        foreach (var food in foodPil) {
          totalPrice += food.Value.getHargaTotal();
        }

        if (drinkPil.Count > 0) {
          foreach (var drink in drinkPil) {
            totalPrice += drink.Value.getHargaTotal();
          }
        }
      } else {
        foreach (var drink in drinkPil) {
          totalPrice += drink.Value.getHargaTotal();
        }
      }

      return totalPrice;
    }

    public double getTotalPriceOfOrders() {
      double discount = promo / 100;
      return totalPrice - (totalPrice * discount);
    }

    public double getPromo() {
      double discount, totalPriceAfterDiscount = 0;

      if (promo > 0) {
        discount = promo / 100;
        totalPriceAfterDiscount -= discount;
      }

      return totalPriceAfterDiscount;
    }
  }
}
