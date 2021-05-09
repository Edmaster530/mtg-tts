using MtgApiManager.Lib.Model;
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
        private readonly List<ICard> _deck;

        public Main()
        {
            provider = new MtgServiceProvider();
            _deck = new List<ICard>();
            InitializeComponent();
        }

        private async void DoSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var service = provider.GetCardService();
            var result = await service.Where(x => x.Name, SearchBox.Text)
                .AllAsync();
            CardLayout.Controls.AddRange(result.Value.Select(c =>
            {
                var control = new Controls.Card(c);
                control.DoubleClick += (o, e) => 
                {
                    DeckList.Items.Add(new ListViewItem(new string[] { c.Name, c.ManaCost })
                    {
                        Tag = c.Id
                    });
                    _deck.Add(c);
                };
                return control;
            }).ToArray());
            Cursor = Cursors.Default;
        }

        private void DoExport_Click(object sender, EventArgs e)
        {
            // cards have to be slapped on a template that is 5x7.2 in ratio
            // the template is the following:
            /*
             * [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
             * ...
             * [61, 62, 63 ... 67, 68, 69, **]
             * where '**' is for the 'hidden card'
             * i.e. the back of the card / base image
             */
            // TODO - handle more than 69 cards
            var chunks = _deck
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / 10)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
            var filename = $@"C:\Users\User\Desktop\deck_exported.jpg";
            var width = 223;
            var height = 321;

            using var bitmap = new Bitmap(width * 10, height * chunks.Count);
            using var template = Graphics.FromImage(bitmap);
            for(var row = 0; row < 6; row++)
            {
                if (chunks.Count < row) continue;
                // each list is a group of at most 10 cards
                // we are going to assume at this time that we have at most 69 items
                // i.e. "sunny day"
                // first we create a temp file from the given url
                for (var i = 0; i < chunks[row].Count; i++)
                {
                    var temp = System.IO.Path.GetTempFileName();
                    using var client = new System.Net.WebClient();
                    client.DownloadFile(chunks[row][i].ImageUrl.ToString(), temp);
                    var image = Image.FromFile(temp);
                    template.DrawImage(image, new Point(i * width, row * height));
                }
                row++;  // we move to the next row
            }
            // we add the last hidden card sleeve
            template.DrawImage(Image.FromFile(WinApp.Controls.Card.BlankCard), new Point(9*width, 6*height));
            bitmap.Save(filename);
        }
    }
}
