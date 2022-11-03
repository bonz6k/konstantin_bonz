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
    public partial class Form1 : Form
    {
        public OleDbConnection connection = new OleDbConnection();
        static public int kv;
        public Form1()
        {
            InitializeComponent(); 
            string cstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =";
            cstr += Form2.str;
            connection.ConnectionString = @cstr;
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Клиент.ФИО, Клиент.Телефон, Клиент.Паспортные_данные, Вид_комнаты.Наименование_комнаты, Бронирование.Дата_заезда, Бронирование.Дата_выезда, Услуга.Наименование_услуги FROM((Вид_комнаты INNER JOIN Комната ON Вид_комнаты.[Код_вида_комнаты] = Комната.[Код_вида_комнаты]) INNER JOIN(Клиент INNER JOIN Бронирование ON Клиент.[Код_клиента] = Бронирование.[Код_клиента]) ON Комната.[Код_комнаты] = Бронирование.[Код_комнаты]) INNER JOIN(Услуга INNER JOIN Обслуживание ON Услуга.[Код_услуги] = Обслуживание.[Код_услуги]) ON Бронирование.[Код_бронирования] = Обслуживание.[Код_бронирования];";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter();
            dataadapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            dataadapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            kv = dataGridView1.Rows.Count;
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        static public int kx;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker1.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            dateTimePicker2.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox1.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox2.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            kx = dataGridView1.CurrentRow.Index + 1;
        }  
        public static Form6 f6 = new Form6();
        private void button2_Click(object sender, EventArgs e)
        {
            int bl = 0;
            TimeSpan bn;
            connection.Open();
                if
                    (
                    textBox1.Text.Replace(" ", "") != "" && textBox2.Text.Replace(" ", "") != "" && textBox3.Text.Replace(" ", "") != ""
                    && comboBox1.SelectedItem != null && dateTimePicker2.Value > dateTimePicker1.Value && comboBox2.SelectedItem != null
                    ) 
                {
                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = connection;
                    command1.CommandText = "Insert into Клиент(ФИО,Телефон,Паспортные_данные) Values(@a1, @a2, @a3);";
                    command1.Parameters.AddWithValue("@a1", textBox1.Text);
                    command1.Parameters.AddWithValue("@a2", textBox2.Text);
                    command1.Parameters.AddWithValue("@a3", textBox3.Text);
                    command1.ExecuteNonQuery();
                    bl = Convert.ToInt32(comboBox1.SelectedIndex) + 1;
                    bn = dateTimePicker2.Value - dateTimePicker1.Value; int days = bn.Days + 1;
                    OleDbCommand command3 = new OleDbCommand();
                    command3.Connection = connection;
                    command3.CommandText = "Insert into Бронирование(Код_клиента,Дата_заезда,Дата_выезда,Код_комнаты,Срок_проживания) Values(@a4, @a5, @a6, @a7, @a8)";
                    command3.Parameters.AddWithValue("@a4", kv);
                    command3.Parameters.AddWithValue("@a5", dateTimePicker1.Value.ToString());
                    command3.Parameters.AddWithValue("@a6", dateTimePicker2.Value.ToString());
                    command3.Parameters.AddWithValue("@a7", bl);
                    command3.Parameters.AddWithValue("@a8", days);
                    command3.ExecuteNonQuery();
                int l;
                l = Convert.ToInt32(comboBox2.SelectedIndex) + 1;
                    OleDbCommand command5 = new OleDbCommand();
                    command5.Connection = connection;
                    command5.CommandText = "Insert into Обслуживание(Код_услуги,Код_бронирования) Values(@b1, @b2);";
                    command5.Parameters.AddWithValue("@b1", l);
                    command5.Parameters.AddWithValue("@b2", kv);
                    command5.ExecuteNonQuery();
                }
                else { f6.ShowDialog(); }
            connection.Close();
                OleDbCommand command15 = new OleDbCommand();
                command15.Connection = connection;
                command15.CommandText = "SELECT Клиент.ФИО, Клиент.Телефон, Клиент.Паспортные_данные, Вид_комнаты.Наименование_комнаты, Бронирование.Дата_заезда, Бронирование.Дата_выезда, Услуга.Наименование_услуги FROM((Вид_комнаты INNER JOIN Комната ON Вид_комнаты.[Код_вида_комнаты] = Комната.[Код_вида_комнаты]) INNER JOIN(Клиент INNER JOIN Бронирование ON Клиент.[Код_клиента] = Бронирование.[Код_клиента]) ON Комната.[Код_комнаты] = Бронирование.[Код_комнаты]) INNER JOIN(Услуга INNER JOIN Обслуживание ON Услуга.[Код_услуги] = Обслуживание.[Код_услуги]) ON Бронирование.[Код_бронирования] = Обслуживание.[Код_бронирования];";
                OleDbDataAdapter dataadapter15 = new OleDbDataAdapter();
                dataadapter15.SelectCommand = command15;
                DataTable dataTable15 = new DataTable();
                dataadapter15.Fill(dataTable15);
                dataGridView1.DataSource = dataTable15;

                Form1 f1 = new Form1();
                f1.Refresh();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            TimeSpan bn1; 
            connection.Open();  
            if
                    (
                    textBox1.Text.Replace(" ", "") != "" && textBox2.Text.Replace(" ", "") != "" && textBox3.Text.Replace(" ", "") != ""
                    && comboBox1.SelectedItem != null && dateTimePicker2.Value > dateTimePicker1.Value && comboBox2.SelectedItem != null
                    )
            { 
                OleDbCommand commandred2 = new OleDbCommand();
                commandred2.Connection = connection;
                commandred2.CommandText = "UPDATE Клиент SET ФИО = @red3, Телефон = @red4,  Паспортные_данные = @red5 WHERE Код_клиента = @kxx";
                commandred2.Parameters.AddWithValue("@red3", textBox1.Text);
                commandred2.Parameters.AddWithValue("@red4", textBox2.Text);
                commandred2.Parameters.AddWithValue("@red5", textBox3.Text);
                commandred2.Parameters.AddWithValue("@kxx", kx);
                commandred2.ExecuteNonQuery();
                int bl1 = Convert.ToInt32(comboBox1.SelectedIndex) + 1;             
                bn1 = dateTimePicker2.Value - dateTimePicker1.Value; int dayss = bn1.Days + 1;
                OleDbCommand commandred3 = new OleDbCommand();
                commandred3.Connection = connection;
                commandred3.CommandText = "UPDATE Бронирование SET Код_клиента = @red6, Дата_заезда = @red7, Дата_выезда = @red8, Код_комнаты = @red9, Срок_проживания = @red0 WHERE Код_бронирования = @kxxx";
                commandred3.Parameters.AddWithValue("@red6", kx);
                commandred3.Parameters.AddWithValue("@red7", dateTimePicker1.Value.ToString());
                commandred3.Parameters.AddWithValue("@red8", dateTimePicker2.Value.ToString());
                commandred3.Parameters.AddWithValue("@red9", bl1);
                commandred3.Parameters.AddWithValue("@red0", dayss);
                commandred3.Parameters.AddWithValue("@kxxx", kx);
                commandred3.ExecuteNonQuery();
                OleDbCommand commandred1 = new OleDbCommand();
                commandred1.Connection = connection;
                commandred1.CommandText = "UPDATE Обслуживание SET Код_услуги = @red1, Код_бронирования = @red2 WHERE Код_обслуживания = @red2";
                int l1 = Convert.ToInt32(comboBox2.SelectedIndex) + 1;   
                commandred1.Parameters.AddWithValue("@red1", l1);
                commandred1.Parameters.AddWithValue("@red2", kx);
                commandred1.ExecuteNonQuery();
            }
            else { f6.ShowDialog(); }
            connection.Close();
            OleDbCommand command15 = new OleDbCommand();
            command15.Connection = connection;
            command15.CommandText = "SELECT Клиент.ФИО, Клиент.Телефон, Клиент.Паспортные_данные, Вид_комнаты.Наименование_комнаты, Бронирование.Дата_заезда, Бронирование.Дата_выезда, Услуга.Наименование_услуги FROM((Вид_комнаты INNER JOIN Комната ON Вид_комнаты.[Код_вида_комнаты] = Комната.[Код_вида_комнаты]) INNER JOIN(Клиент INNER JOIN Бронирование ON Клиент.[Код_клиента] = Бронирование.[Код_клиента]) ON Комната.[Код_комнаты] = Бронирование.[Код_комнаты]) INNER JOIN(Услуга INNER JOIN Обслуживание ON Услуга.[Код_услуги] = Обслуживание.[Код_услуги]) ON Бронирование.[Код_бронирования] = Обслуживание.[Код_бронирования];";
            OleDbDataAdapter dataadapter15 = new OleDbDataAdapter();
            dataadapter15.SelectCommand = command15;
            DataTable dataTable15 = new DataTable();
            dataadapter15.Fill(dataTable15);
            dataGridView1.DataSource = dataTable15;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command72 = new OleDbCommand();
            command72.Connection = connection;
            command72.CommandText = "Delete Клиент.* FROM Клиент where Клиент.Код_клиента = @с2";
            command72.Parameters.AddWithValue("@с2", kx);
            command72.ExecuteNonQuery();
            connection.Close();
            OleDbCommand command15 = new OleDbCommand();
            command15.Connection = connection;
            command15.CommandText = "SELECT Клиент.ФИО, Клиент.Телефон, Клиент.Паспортные_данные, Вид_комнаты.Наименование_комнаты, Бронирование.Дата_заезда, Бронирование.Дата_выезда, Услуга.Наименование_услуги FROM((Вид_комнаты INNER JOIN Комната ON Вид_комнаты.[Код_вида_комнаты] = Комната.[Код_вида_комнаты]) INNER JOIN(Клиент INNER JOIN Бронирование ON Клиент.[Код_клиента] = Бронирование.[Код_клиента]) ON Комната.[Код_комнаты] = Бронирование.[Код_комнаты]) INNER JOIN(Услуга INNER JOIN Обслуживание ON Услуга.[Код_услуги] = Обслуживание.[Код_услуги]) ON Бронирование.[Код_бронирования] = Обслуживание.[Код_бронирования];";
            OleDbDataAdapter dataadapter15 = new OleDbDataAdapter();
            dataadapter15.SelectCommand = command15;
            DataTable dataTable15 = new DataTable();
            dataadapter15.Fill(dataTable15);
            dataGridView1.DataSource = dataTable15;
        }

    }
}
