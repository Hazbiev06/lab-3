using System.Text;
using System.Windows.Forms;

namespace lab_rab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            private void buttonOpen_Click_1(object sender, EventArgs e)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
                {
                    richTextBox.Clear(); //Очищаем richTextBox
                    openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют
                    только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к
                    нему.
                    richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем
                    содержимое файла в richTextBox
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            private void buttonSave_Click_1(object sender, EventArgs e)
            {
                saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
                saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
                3
if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение
                    сохранения информации.
{
                    var name = saveFileDialog1.FileName; //Задаем имя файлу
                    File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем
                    в файл содержимое textBox с кодировкой 1251
}
                richTextBox.Clear();
            }

        }
    }
}
using System.IO;