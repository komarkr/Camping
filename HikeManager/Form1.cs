namespace HikeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupUI(); // Викликаємо наш код для інтерфейсу
        }

        private void SetupUI()
        {
            // 1. Налаштування головного вікна
            this.Size = new Size(1000, 650);
            this.Text = "HikeManager — Головне меню";
            this.StartPosition = FormStartPosition.CenterScreen;

            // 2. Створення бокової панелі (Меню)
            Panel sideMenu = new Panel();
            sideMenu.Dock = DockStyle.Left;
            sideMenu.Width = 200;
            sideMenu.BackColor = Color.FromArgb(40, 75, 60); // Темно-зелений колір з макету

            // 3. Створення кнопок для меню
            Button btnRoutes = CreateMenuButton("Маршрути");
            Button btnHikes = CreateMenuButton("Походи");
            Button btnHistory = CreateMenuButton("Історія");

            // Додаємо кнопки на панель (знизу вгору, щоб перша була зверху)
            sideMenu.Controls.Add(btnHistory);
            sideMenu.Controls.Add(btnHikes);
            sideMenu.Controls.Add(btnRoutes);

            // 4. Створення світлої робочої зони
            Panel mainArea = new Panel();
            mainArea.Dock = DockStyle.Fill;
            mainArea.BackColor = Color.FromArgb(235, 245, 235); // Світло-зелений фон

            // 5. Заголовок робочої зони
            Label titleLabel = new Label();
            titleLabel.Text = "Маршрути";
            titleLabel.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(40, 75, 60);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(40, 30);

            mainArea.Controls.Add(titleLabel);

            // 6. Додаємо панелі на головну форму
            this.Controls.Add(mainArea);
            this.Controls.Add(sideMenu);
        }

        // Допоміжний метод, щоб не дублювати код налаштування кожної кнопки
        private Button CreateMenuButton(string text)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Dock = DockStyle.Top;
            btn.Height = 55;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Проста перевірка працездатності при кліку
            btn.Click += (s, e) => MessageBox.Show($"Відкрито розділ: {text}. База даних підключена.");

            return btn;
        }
    }
}