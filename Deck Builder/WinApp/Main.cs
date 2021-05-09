using MtgApiManager.Lib.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Main : Form
    {
        private readonly IMtgServiceProvider provider;

        public Main()
        {
            provider = new MtgServiceProvider();

            InitializeComponent();
        }

        private async void DoSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var service = provider.GetCardService();
            var result = await service.Where(x => x.Name, SearchBox.Text)
                .AllAsync();
            CardLayout.Controls.AddRange(result.Value.Select(c => new Controls.Card(c)).ToArray());
            Cursor = Cursors.Default;
        }
    }
}
