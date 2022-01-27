using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_kasir.orderService {
  class Drink : Menu {
    private bool useIce;

    public Drink(string name, int price, string id, bool useIce = false) : base(name, price, id) {
      this.useIce = useIce;
    }

    public bool getUseIce() {
      return useIce;
    }
  }
}
