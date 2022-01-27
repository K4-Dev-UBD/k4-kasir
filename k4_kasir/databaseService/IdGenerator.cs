using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k4_kasir.databaseService {
  public class IdGenerator {
    public string generate(int saltRound = 7) {
      var random = new Random();
      var bytes = new byte[saltRound];
      random.NextBytes(bytes);

      var hexArray = Array.ConvertAll(bytes, x => x.ToString("X2"));
      var hexStr = string.Concat(hexArray);
      return hexStr;
    }
  }
}
