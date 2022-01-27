using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k4_kasir {
  public partial class SplashForm : Form {
    public SplashForm() {
      InitializeComponent();

      _ = SetInterval(() => progressBar1.PerformStep(), TimeSpan.FromSeconds(.18));
    }

    public static async Task SetInterval(Action action, TimeSpan timeout) {
      await Task.Delay(timeout).ConfigureAwait(false);

      action();

      _ = SetInterval(action, timeout);
    }
  }
}
