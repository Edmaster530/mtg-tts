using MtgApiManager.Lib.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace WinApp.Controls
{
    public partial class Card : UserControl
    {
        /// <summary>
        /// <see cref="ICard" />
        /// </summary>
        protected ICard PlayingCard
        {
            get { return _card; }
            set
            {
                BaseImage.ImageLocation = string.IsNullOrWhiteSpace(value?.ImageUrl?.ToString())
                    ? BlankCard
                    : value.ImageUrl.ToString();
                _card = value;
            }
        }
        private ICard _card;
        public static string BlankCard { get; } = Path.Join(AppDomain.CurrentDomain.BaseDirectory, $@"Images\blank.jfif");

        public Card(ICard card) : this() => PlayingCard = card;

        public Card()
        {
            InitializeComponent();
            BaseImage.DoubleClick += (o, e) => OnDoubleClick(e);
        }
    }
}
