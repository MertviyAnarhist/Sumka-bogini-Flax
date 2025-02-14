using System;
using System.Drawing;
using System.Windows.Forms;


namespace Сумка_богини_Флакс
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowErrorMessage()
        {
            MessageBox.Show(this, "Введите число от 1 до 100", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void btn_OpenBagClick(object sender, EventArgs e)
        {
            Random random = new Random();
            int roll;

            if (textBox_main.Text == string.Empty)
            {
                roll = random.Next(1, 100);
            }

            bool is_number = int.TryParse(textBox_main.Text, out roll);
            if (is_number == false)
            {
                ShowErrorMessage();
                return;
            }

            if (roll < 1 || roll > 100)
            {
                ShowErrorMessage();
                return;

            }

            label2.Font = new Font("Microsoft Sans Serif", 12);
            label2.Text = ItemsRepository.Items[roll - 1];
        }
    }
}