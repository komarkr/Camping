using System.Drawing;
using System.Windows.Forms;

namespace HikeManager.Views
{
    public class RoutesView : UserControl
    {
        public RoutesView()
        {
            Dock = DockStyle.Fill;
            BackColor = Theme.BackgroundColor;

            Label title = new Label
            {
                Text = "Каталог маршрутів",
                Font = Theme.TitleFont,
                ForeColor = Theme.PrimaryColor,
                Location = new Point(30, 30),
                AutoSize = true
            };

            Label subtitle = new Label
            {
                Text = "Каркас екрану маршрутів (буде наповнено в гілці feature/routes)",
                Font = Theme.RegularFont,
                ForeColor = Theme.TextMuted,
                Location = new Point(32, 75),
                AutoSize = true
            };

            Controls.Add(title);
            Controls.Add(subtitle);
        }
    }
}
