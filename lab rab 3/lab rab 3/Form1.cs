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

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            private void buttonOpen_Click_1(object sender, EventArgs e)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) //��������� ��� �� ������ ����
                {
                    richTextBox.Clear(); //������� richTextBox
                    openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //��������� ��� ��� ����������
                    ������ ��������� �����
                string fileName = openFileDialog1.FileName; //�������� ������������ ���� � ���� �
                    ����.
                    richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //��������
                    ���������� ����� � richTextBox
                }
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            private void buttonSave_Click_1(object sender, EventArgs e)
            {
                saveFileDialog1.Filter = "Text Files|*.txt";//������ ��������� ����������
                saveFileDialog1.DefaultExt = ".txt"; //������ ���������� �� ���������
                3
if (saveFileDialog1.ShowDialog() == DialogResult.OK) //��������� �������������
                    ���������� ����������.
{
                    var name = saveFileDialog1.FileName; //������ ��� �����
                    File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //����������
                    � ���� ���������� textBox � ���������� 1251
}
                richTextBox.Clear();
            }

        }
    }
}
using System.IO;