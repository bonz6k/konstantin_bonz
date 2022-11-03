using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KURSOVAYA_progect.V1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public OleDbConnection connection1 = new OleDbConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            string cstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =";
            cstr += Form2.str;
            connection1.ConnectionString = @cstr;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection1;
            command1.CommandText = "SELECT DISTINCT Бронирование.Код_комнаты, Вид_комнаты.Наименование_комнаты AS Свободные FROM(Вид_комнаты INNER JOIN Комната ON Вид_комнаты.Код_вида_комнаты = Комната.Код_вида_комнаты) INNER JOIN Бронирование ON Комната.Код_комнаты = Бронирование.Код_комнаты WHERE(((Бронирование.Код_комнаты)Not In(SELECT Код_комнаты FROM Бронирование WHERE @Дата >= [Дата_заезда] AND @Дата <= [Дата_выезда])));";
            command1.Parameters.AddWithValue("@Дата", dateTimePicker1.Value.ToString("dd-MM-yyyy"));
            OleDbDataAdapter dataadapter1 = new OleDbDataAdapter();
            dataadapter1.SelectCommand = command1;
            DataTable dataTable1 = new DataTable();
            dataadapter1.Fill(dataTable1);
            dataGridView2.DataSource = dataTable1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string cstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =";
            cstr += Form2.str;
            connection1.ConnectionString = @cstr;
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connection1;
            command2.CommandText = "SELECT Вид_комнаты.Наименование_комнаты AS Занятые, Бронирование.Код_комнаты FROM(Вид_комнаты INNER JOIN Комната ON Вид_комнаты.Код_вида_комнаты = Комната.Код_вида_комнаты) INNER JOIN Бронирование ON Комната.Код_комнаты = Бронирование.Код_комнаты WHERE((@Дата >=[Дата_заезда] And @Дата <= [Дата_выезда])); ";
            command2.Parameters.AddWithValue("@Дата", dateTimePicker1.Value.ToString("dd-MM-yyyy"));
            OleDbDataAdapter dataadapter2 = new OleDbDataAdapter();
            dataadapter2.SelectCommand = command2;
            DataTable dataTable2 = new DataTable();
            dataadapter2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string cstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =";
            cstr += Form2.str;
            connection1.ConnectionString = @cstr;
            OleDbCommand command3 = new OleDbCommand();
            command3.Connection = connection1;
            command3.CommandText = "SELECT Вид_комнаты.Наименование_комнаты, Вид_комнаты.Цена FROM Вид_комнаты;";
            OleDbDataAdapter dataadapter3 = new OleDbDataAdapter();
            dataadapter3.SelectCommand = command3;
            DataTable dataTable3 = new DataTable();
            dataadapter3.Fill(dataTable3);
            dataGridView2.DataSource = dataTable3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            string cstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =";
            cstr += Form2.str;
            connection1.ConnectionString = @cstr;
            try
            {
                if (f4.dateTimePicker3.Value < f4.dateTimePicker4.Value)
                {
                    OleDbCommand command4 = new OleDbCommand();
                    command4.Connection = connection1;
                    command4.CommandText = "SELECT Бронирование.Дата_выезда, Бронирование.Срок_проживания, Вид_комнаты.Цена, Услуга.Цена_услуги, [Цена_услуги]+[Цена]*[Срок_проживания] AS Выручка FROM Услуга INNER JOIN((Вид_комнаты INNER JOIN Комната ON Вид_комнаты.Код_вида_комнаты = Комната.Код_вида_комнаты) INNER JOIN(Бронирование INNER JOIN Обслуживание ON Бронирование.Код_бронирования = Обслуживание.Код_бронирования) ON Комната.Код_комнаты = Бронирование.Код_комнаты) ON Услуга.Код_услуги = Обслуживание.Код_услуги WHERE(((Бронирование.Дата_выезда)Between[@Начальная дата] And[@Конечная дата])); ";
                    command4.Parameters.AddWithValue("@Начальная дата", f4.dateTimePicker3.Value);
                    command4.Parameters.AddWithValue("@Конечная дата", f4.dateTimePicker4.Value);
                    OleDbDataAdapter dataadapter4 = new OleDbDataAdapter();
                    dataadapter4.SelectCommand = command4;
                    DataTable dataTable4 = new DataTable();
                    dataadapter4.Fill(dataTable4);
                    dataGridView2.DataSource = dataTable4;
                }
                else { f6.ShowDialog(); }
            }
            catch { f6.ShowDialog(); }
        }
    }
}
