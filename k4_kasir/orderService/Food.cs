using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_kasir.orderService {
  class Food : Menu {
    private bool fried, spicy, salty;

    public Food(string name, int price, string id, bool spicy = false, bool fried = false, bool salty = false ) : base(name, price, id) {
      this.fried = fried;
      this.spicy = spicy;
      this.salty = salty;
    }

    public bool getSpicy() {
      return spicy;
    }

    public bool getFried() {
      return fried;
    }

    public bool getSalty() {
      return salty;
    }
  }
}
