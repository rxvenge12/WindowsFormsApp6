using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private LinkedList<int> linkedList = new LinkedList<int>();

        public Form1()
        {
            InitializeComponent();
            // Добавляем обработчик события загрузки формы
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Добавляем текст в label1
            label1.Text = "Введите целое число:";
            // Добавляем текст на кнопку button1
            button1.Text = "Добавить в список";
            // Добавляем текст на кнопку button2
            button2.Text = "Вычислить среднее кратных 4";
            // Добавляем текст на label2
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, введено ли целое число
            if (int.TryParse(textBox1.Text, out int value))
            {
                linkedList.AddLast(value);
                UpdateListBox();
                // Очищаем текстовое поле
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Введите целое число!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            int sum = 0;

            // Перебираем элементы списка и считаем сумму элементов, кратных 4
            foreach (int item in linkedList)
            {
                if (item % 4 == 0)
                {
                    count++;
                    sum += item;
                }
            }

            // Проверяем, есть ли элементы кратные 4
            if (count > 0)
            {
                double average = (double)sum / count;
                label2.Text = "Среднее арифметическое значений элементов, кратных 4: " + average.ToString("F2");
            }
            else
            {
                label2.Text = "В списке нет элементов, кратных 4!";
            }
        }

        private void UpdateListBox()
        {
            // Очистка ListBox и добавление элементов из связанного списка
            listBox1.Items.Clear();
            foreach (int item in linkedList)
            {
                listBox1.Items.Add(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Обработчик изменения текста в textBox1
            // Вы можете добавить здесь код, который должен выполняться при изменении текста
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Обработчик клика по label1
            // Вы можете добавить здесь код, который должен выполняться при клике
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обработчик изменения выбранного элемента в listBox1
            // Вы можете добавить здесь код, который должен выполняться при изменении выбранного элемента
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Обработчик клика по label2
            // Вы можете добавить здесь код, который должен выполняться при клике
        }
    }
}
