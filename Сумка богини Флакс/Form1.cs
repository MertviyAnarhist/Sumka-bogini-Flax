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

        private bool IsNumberInRange(int roll)
        {
            return roll >= 1 && roll <= 100;
        }

        public void btn_OpenBagClick(object sender, EventArgs e)
        {
            int roll = -1;
            bool isNumber = true;

            if (textBox_main.Text == string.Empty)
            {
                roll = new Random().Next(1, 100);
            }
            else
            {
                isNumber = int.TryParse(textBox_main.Text, out roll);
            }

            if (!IsNumberInRange(roll) || !isNumber)
            {
                ShowErrorMessage();
                return;
            }

            label2.Font = new Font("Microsoft Sans Serif", 12);
            label2.Text = ItemsRepository.Items[roll - 1];
        }
    }
}