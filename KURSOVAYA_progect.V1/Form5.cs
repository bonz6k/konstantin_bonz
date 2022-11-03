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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        OleDbConnection connect1 = new OleDbConnection();
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =";
            cstr += Form2.str;
            connect1.ConnectionString = @cstr;
            connect1.Open();
            switch (comboBox5.SelectedItem)
            {
                case "Услуги":
                    OleDbCommand c1 = new OleDbCommand();
                    c1.Connection = connect1;
                    c1.CommandText = "SELECT Услуга.Код_услуги, Услуга.Код_персонала, Услуга.Цена_услуги, Услуга.Наименование_услуги FROM Услуга;";
                    OleDbDataAdapter dat1 = new OleDbDataAdapter();
                    dat1.SelectCommand = c1;
                    DataTable datb1 = new DataTable();
                    dat1.Fill(datb1);
                    dataGridView3.DataSource = datb1;
                    break;
                case "Должность":
                    OleDbCommand c2 = new OleDbCommand();
                    c2.Connection = connect1;
                    c2.CommandText = "SELECT Должность.Код_должности, Должность.Должность FROM Должность;";
                    OleDbDataAdapter dat2 = new OleDbDataAdapter();
                    dat2.SelectCommand = c2;
                    DataTable datb2 = new DataTable();
                    dat2.Fill(datb2);
                    dataGridView3.DataSource = datb2;
                    break;
                case "Комнаты":
                    OleDbCommand c3 = new OleDbCommand();
                    c3.Connection = connect1;
                    c3.CommandText = "SELECT Вид_комнаты.Код_вида_комнаты, Вид_комнаты.Цена, Вид_комнаты.Наименование_комнаты FROM Вид_комнаты;";
                    OleDbDataAdapter dat3 = new OleDbDataAdapter();
                    dat3.SelectCommand = c3;
                    DataTable datb3 = new DataTable();
                    dat3.Fill(datb3);
                    dataGridView3.DataSource = datb3;
                    break;
                case "Персонал":
                    OleDbCommand c4 = new OleDbCommand();
                    c4.Connection = connect1;
                    c4.CommandText = "SELECT Персонал.Код_персонала, Персонал.ФИО, Персонал.Код_должности FROM Персонал;";
                    OleDbDataAdapter dat4 = new OleDbDataAdapter();
                    dat4.SelectCommand = c4;
                    DataTable datb4 = new DataTable();
                    dat4.Fill(datb4);
                    dataGridView3.DataSource = datb4;
                    break;
            }
            connect1.Close();
        }
        Form6 f6 = new Form6();
        private void bt1_Click(object sender, EventArgs e)
        {
            string cstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =";
            cstr += Form2.str;
            connect1.ConnectionString = @cstr;
            connect1.Open();
            if (comboBox5.SelectedItem != null)
            {
                switch (comboBox5.SelectedItem)
                {
                    case "Услуги":
                        if (tb1.Text.Replace(" ", "") != "" && tb2.Text.Replace(" ", "") != "" && tb3.Text.Replace(" ", "") != "" && tb4.Text.Replace(" ", "") != "")
                        {
                            OleDbCommand t = new OleDbCommand();
                            t.Connection = connect1;
                            t.CommandText = "INSERT INTO Услуга(Код_услуги, Код_персонала, Цена_услуги, Наименование_услуги) Values (@kys, @kp, @cy, @ny);";
                            t.Parameters.AddWithValue("@kys", tb1.Text);
                            t.Parameters.AddWithValue("@kp", tb2.Text);
                            t.Parameters.AddWithValue("@cy", tb3.Text);
                            t.Parameters.AddWithValue("@ny", tb4.Text);
                            t.ExecuteNonQuery();
                        }
                        else { f6.ShowDialog(); }
                        break;
                    case "Должность":
                        if (tb1.Text.Replace(" ", "") != "" && tb2.Text.Replace(" ", "") != "")
                        {
                            OleDbCommand t1 = new OleDbCommand();
                            t1.Connection = connect1;
                            t1.CommandText = "INSERT INTO Должность(Код_должности, Должность) Values (@kdo, @do);";
                            t1.Parameters.AddWithValue("@kdo", tb1.Text);
                            t1.Parameters.AddWithValue("@do", tb2.Text);
                            t1.ExecuteNonQuery();
                        }
                        else { f6.ShowDialog(); }
                        break;
                    case "Комнаты":
                        if (tb1.Text.Replace(" ", "") != "" && tb2.Text.Replace(" ", "") != "" && tb3.Text.Replace(" ", "") != "")
                        {
                            OleDbCommand t2 = new OleDbCommand();
                            OleDbCommand t21 = new OleDbCommand();
                            t21.Connection = connect1;
                            t2.Connection = connect1;
                            t2.CommandText = "INSERT INTO Вид_комнаты(Код_вида_комнаты, Цена, Наименование_комнаты) Values (@kvd, @Cen, @nak);";
                            t2.Parameters.AddWithValue("@kvd", tb1.Text);
                            t2.Parameters.AddWithValue("@Cen", tb2.Text);
                            t2.Parameters.AddWithValue("@nak", tb3.Text);
                            t2.ExecuteNonQuery();
                            t21.CommandText = "INSERT INTO Комната(Код_вида_комнаты) VALUES(@kvd)";
                            t21.Parameters.AddWithValue("@kvd", tb1.Text);
                            t21.ExecuteNonQuery();
                        }
                        else { f6.ShowDialog(); }
                        break;
                    case "Персонал":
                        if (tb1.Text.Replace(" ", "") != "" && tb2.Text.Replace(" ", "") != "" && tb3.Text.Replace(" ", "") != "")
                        {
                            OleDbCommand t3 = new OleDbCommand();
                            t3.Connection = connect1;
                            t3.CommandText = "INSERT INTO Персонал(Код_персонала, ФИО, Код_должности) Values (@kper, @fio, @kdol);";
                            t3.Parameters.AddWithValue("@kper", tb1.Text);
                            t3.Parameters.AddWithValue("@fio", tb2.Text);
                            t3.Parameters.AddWithValue("@kdol", tb3.Text);
                            t3.ExecuteNonQuery();
                        }
                        else { f6.ShowDialog(); }
                        break;
                }
            }
            else { f6.ShowDialog(); }
            connect1.Close();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            string cstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =";
            cstr += Form2.str;
            connect1.ConnectionString = @cstr;
            connect1.Open();
            if (comboBox5.SelectedItem != null)
            {
                switch (comboBox5.SelectedItem)
                {
                    case "Услуги":
                        OleDbCommand t4 = new OleDbCommand();
                        t4.Connection = connect1;
                        t4.CommandText = "Delete Услуга.* FROM Услуга WHERE Услуга.Код_услуги = @kyss;";
                        t4.Parameters.AddWithValue("@kyss", tb1.Text);
                        t4.ExecuteNonQuery();
                        break;
                    case "Должность":
                        OleDbCommand t5 = new OleDbCommand();
                        t5.Connection = connect1;
                        t5.CommandText = "Delete Должность.* FROM Должность WHERE Должность.Код_должности = @kdoo;";
                        t5.Parameters.AddWithValue("@kdoo", tb1.Text);
                        t5.ExecuteNonQuery();
                        break;
                    case "Комнаты":
                        OleDbCommand t6 = new OleDbCommand();
                        t6.Connection = connect1;
                        t6.CommandText = "Delete Вид_комнаты.* FROM Вид_комнаты WHERE Вид_комнаты.Код_вида_комнаты = @kdvv;";
                        t6.Parameters.AddWithValue("@kdvv", tb1.Text);
                        t6.ExecuteNonQuery();
                        break;
                    case "Персонал":
                        OleDbCommand t7 = new OleDbCommand();
                        t7.Connection = connect1;
                        t7.CommandText = "Delete Персонал.* FROM Персонал WHERE Персонал.Код_персонала = @kpers;";
                        t7.Parameters.AddWithValue("@kpers", tb1.Text);
                        t7.ExecuteNonQuery();
                        break;
                }
            }
            else { f6.ShowDialog(); }
            connect1.Close();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            string cstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =";
            cstr += Form2.str;
            connect1.ConnectionString = @cstr;
            connect1.Open();
            switch (comboBox5.SelectedItem)
            {
                case "Услуги":
                    OleDbCommand t8 = new OleDbCommand();
                    t8.Connection = connect1;
                    t8.CommandText = "SELECT Услуга.Код_услуги, Услуга.Код_персонала, Услуга.Цена_услуги, Услуга.Наименование_услуги FROM Услуга;";
                    OleDbDataAdapter datt1 = new OleDbDataAdapter();
                    datt1.SelectCommand = t8;
                    DataTable datbb1 = new DataTable();
                    datt1.Fill(datbb1);
                    dataGridView3.DataSource = datbb1;
                    break;
                case "Должность":
                    OleDbCommand t9 = new OleDbCommand();
                    t9.Connection = connect1;
                    t9.CommandText = "SELECT Должность.Код_должности, Должность.Должность FROM Должность;";
                    OleDbDataAdapter datt2 = new OleDbDataAdapter();
                    datt2.SelectCommand = t9;
                    DataTable datbb2 = new DataTable();
                    datt2.Fill(datbb2);
                    dataGridView3.DataSource = datbb2;
                    break;
                case "Комнаты":
                    OleDbCommand t0 = new OleDbCommand();
                    t0.Connection = connect1;
                    t0.CommandText = "SELECT Вид_комнаты.Код_вида_комнаты, Вид_комнаты.Цена, Вид_комнаты.Наименование_комнаты FROM Вид_комнаты;";
                    OleDbDataAdapter datt3 = new OleDbDataAdapter();
                    datt3.SelectCommand = t0;
                    DataTable datbb3 = new DataTable();
                    datt3.Fill(datbb3);
                    dataGridView3.DataSource = datbb3;
                    break;
                case "Персонал":
                    OleDbCommand t00 = new OleDbCommand();
                    t00.Connection = connect1;
                    t00.CommandText = "SELECT Персонал.Код_персонала, Персонал.ФИО, Персонал.Код_должности FROM Персонал;";
                    OleDbDataAdapter datt4 = new OleDbDataAdapter();
                    datt4.SelectCommand = t00;
                    DataTable datbb4 = new DataTable();
                    datt4.Fill(datbb4);
                    dataGridView3.DataSource = datbb4;
                    break;
            }
            connect1.Close();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            string cstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =";
            cstr += Form2.str;
            connect1.ConnectionString = @cstr;
            connect1.Open();
            if (comboBox5.SelectedItem != null)
            {
                switch (comboBox5.SelectedItem)
                {
                    case "Услуги":
                        if (tb1.Text.Replace(" ", "") != "" && tb2.Text.Replace(" ", "") != "" && tb3.Text.Replace(" ", "") != "" && tb4.Text.Replace(" ", "") != "")
                        {
                            OleDbCommand u = new OleDbCommand();
                            u.Connection = connect1;
                            u.CommandText = "UPDATE Услуга SET Код_персонала = @kp1, Цена_услуги = @cy1, Наименование_услуги = @ny1 WHERE Код_услуги = @kys1";
                            u.Parameters.AddWithValue("@kp1", tb2.Text);
                            u.Parameters.AddWithValue("@cy1", tb3.Text);
                            u.Parameters.AddWithValue("@ny1", tb4.Text);
                            u.Parameters.AddWithValue("@kys1", tb1.Text);
                            u.ExecuteNonQuery();
                        }
                        else { f6.ShowDialog(); }
                        break;
                    case "Должность":
                        if (tb1.Text.Replace(" ", "") != "" && tb2.Text.Replace(" ", "") != "")
                        {
                            OleDbCommand u1 = new OleDbCommand();
                            u1.Connection = connect1;
                            u1.CommandText = "UPDATE Должность SET Должность = @do WHERE Код_должности = @kdo";
                            u1.Parameters.AddWithValue("@do", tb2.Text);
                            u1.Parameters.AddWithValue("@kdo", tb1.Text);
                            u1.ExecuteNonQuery();
                        }
                        else { f6.ShowDialog(); }
                        break;
                    case "Комнаты":
                        if (tb1.Text.Replace(" ", "") != "" && tb2.Text.Replace(" ", "") != "" && tb3.Text.Replace(" ", "") != "")
                        {
                            OleDbCommand u2 = new OleDbCommand();
                            u2.Connection = connect1;
                            u2.CommandText = "UPDATE Вид_комнаты SET Цена = @cen, Наименование_комнаты = @nak WHERE Код_вида_комнаты = @kvd";
                            u2.Parameters.AddWithValue("@Cen", tb2.Text);
                            u2.Parameters.AddWithValue("@nak", tb3.Text);
                            u2.Parameters.AddWithValue("@kvd", tb1.Text);
                            u2.ExecuteNonQuery();
                        }
                        else { f6.ShowDialog(); }
                        break;
                    case "Персонал":
                        if (tb1.Text.Replace(" ", "") != "" && tb2.Text.Replace(" ", "") != "" && tb3.Text.Replace(" ", "") != "")
                        {
                            OleDbCommand u3 = new OleDbCommand();
                            u3.Connection = connect1;
                            u3.CommandText = "UPDATE Персонал SET ФИО = @fio, Код_должности = @kdol WHERE Код_персонала = @kper";
                            u3.Parameters.AddWithValue("@fio", tb2.Text);
                            u3.Parameters.AddWithValue("@kdol", tb3.Text);
                            u3.Parameters.AddWithValue("@kper", tb1.Text);
                            u3.ExecuteNonQuery();
                        }
                        else { f6.ShowDialog(); }
                        break;
                }
            }
            else { f6.ShowDialog(); }
            connect1.Close();
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb1.Text = dataGridView3[0, dataGridView3.CurrentRow.Index].Value.ToString();
            tb2.Text = dataGridView3[1, dataGridView3.CurrentRow.Index].Value.ToString();
            if (dataGridView3.CurrentRow.Cells.Count > 2)
            {
                tb3.Text = dataGridView3[2, dataGridView3.CurrentRow.Index].Value.ToString();
            }
            else { tb3.Text = ""; }
            if (dataGridView3.CurrentRow.Cells.Count > 3)
            {
                tb4.Text = dataGridView3[3, dataGridView3.CurrentRow.Index].Value.ToString();
            }
            else { tb4.Text = ""; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
