using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k4_kasir.databaseService;

namespace k4_kasir.orderService {
  class QueueService {
    public static int nomor = 1;
    private static Dictionary<int, Food> foodPil = new Dictionary<int, Food>();
    private static Dictionary<int, Drink> drinkPil = new Dictionary<int, Drink>();

    public void add() {
      AntrianService antrianService = new AntrianService();
      AntrianPesananBarangService antrianPesananBarangService = new AntrianPesananBarangService();

      string idAntrian = antrianService.addAntrian(nomor, 0);

      foreach (var makanan in foodPil) {
        string optionalChoiceForFood = "";
        string useFried = makanan.Value.getFried() == true ? "Goreng" : "";
        string useSpicy = makanan.Value.getSpicy() == true ? "Pedas" : "";
        string useSalty = makanan.Value.getFried() == true ? "Asin" : "";

        optionalChoiceForFood = $"{useFried} {useSpicy} {useSalty}";

        antrianPesananBarangService.addAntrianPesanan(idAntrian, makanan.Value.id, makanan.Value.getJumlahBeli(), optionalChoiceForFood); 
      }

      foreach (var minuman in drinkPil) {
        string optionalChoiceForDrink = minuman.Value.getUseIce() == true ? "es" : "";

        antrianPesananBarangService.addAntrianPesanan(idAntrian, minuman.Value.id, minuman.Value.getJumlahBeli(), optionalChoiceForDrink);
      }

      nomor++;
    }

    public void addMakanan(Dictionary<int, Food> listMakanan) {
      int count = 0;
      foodPil.Clear();

      foreach (var order in listMakanan) {
        foodPil.Add(count, order.Value);
        count++;
      }
    }

    public void addMinuman(Dictionary<int, Drink> listMinuman) {
      int count = 0;
      drinkPil.Clear();

      foreach (var order in listMinuman) {
        drinkPil.Add(count, order.Value);
        count++;
      }
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
  }
}
