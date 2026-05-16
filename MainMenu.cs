using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;
using System.Text.Json;

namespace Week6_Activity_Dizon
{
    public partial class MainMenu : Form
    {
        public string uname { get; set; }

        public MainMenu()
        {
            InitializeComponent();

        }
        string name;
        int price;
        int cost;
        private Random random = new Random();

        private void mainDish1_Load(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            name = "Bibimbap";
            int qty = int.Parse(numericUpDown1.Value.ToString());
            price = 150;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sideDish2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            name = "Bulgogi";
            int qty = int.Parse(numericUpDown2.Value.ToString());
            price = 130;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grid.Rows.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 1)
            {
                int rowIndex = grid.SelectedRows[0].Index;
                grid.Rows.RemoveAt(rowIndex);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = "Samgyeopsal";
            int qty = int.Parse(numericUpDown3.Value.ToString());
            price = 140;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            name = "Kimchi Jjigae";
            int qty = int.Parse(numericUpDown4.Value.ToString());
            price = 110;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            name = "Jjajangmyeon";
            int qty = int.Parse(numericUpDown5.Value.ToString());
            price = 120;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            name = "Galbi";
            int qty = int.Parse(numericUpDown6.Value.ToString());
            price = 130;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            name = "Kimchi";
            int qty = int.Parse(numericUpDown7.Value.ToString());
            price = 25;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            name = "Namul";
            int qty = int.Parse(numericUpDown8.Value.ToString());
            price = 20;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            name = "Gamja Jorim";
            int qty = int.Parse(numericUpDown9.Value.ToString());
            price = 25;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            name = "Pickled Radish";
            int qty = int.Parse(numericUpDown11.Value.ToString());
            price = 10;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            name = "Fishcake";
            int qty = int.Parse(numericUpDown10.Value.ToString());
            price = 15;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            name = "Gyeran Jjim";
            int qty = int.Parse(numericUpDown12.Value.ToString());
            price = 30;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            name = "Tteokbokki";
            int qty = int.Parse(numericUpDown13.Value.ToString());
            price = 150;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            name = "Gimbap";
            int qty = int.Parse(numericUpDown14.Value.ToString());
            price = 100;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            name = "Mandu";
            int qty = int.Parse(numericUpDown15.Value.ToString());
            price = 75;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            name = "Kimchi Jeon";
            int qty = int.Parse(numericUpDown16.Value.ToString());
            price = 70;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            name = "Gyeran Jjim";
            int qty = int.Parse(numericUpDown17.Value.ToString());
            price = 50;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            name = "Japchae";
            int qty = int.Parse(numericUpDown18.Value.ToString());
            price = 80;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            name = "Bingsu";
            int qty = int.Parse(numericUpDown19.Value.ToString());
            price = 120;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            name = "Mochi";
            int qty = int.Parse(numericUpDown20.Value.ToString());
            price = 40;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            name = "Dalgona";
            int qty = int.Parse(numericUpDown21.Value.ToString());
            price = 15;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            name = "Bungeoppang";
            int qty = int.Parse(numericUpDown22.Value.ToString());
            price = 60;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            name = "Hotteok";
            int qty = int.Parse(numericUpDown23.Value.ToString());
            price = 50;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            name = "Yaksik";
            int qty = int.Parse(numericUpDown24.Value.ToString());
            price = 30;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            name = "Soju";
            int qty = int.Parse(numericUpDown25.Value.ToString());
            price = 70;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            name = "Coke";
            int qty = int.Parse(numericUpDown26.Value.ToString());
            price = 30;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            name = "Iced Tea";
            int qty = int.Parse(numericUpDown27.Value.ToString());
            price = 30;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            name = "Strawberry Shake";
            int qty = int.Parse(numericUpDown28.Value.ToString());
            price = 75;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            name = "Iced Coffee";
            int qty = int.Parse(numericUpDown29.Value.ToString());
            price = 65;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            name = "Hot Coffee";
            int qty = int.Parse(numericUpDown30.Value.ToString());
            price = 60;
            cost = qty * price;
            this.grid.Rows.Add(name, qty, cost);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            label62.Text = uname;

        }

        private void button33_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int row = 0; row < grid.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(grid.Rows[row].Cells[2].Value);
            }
            totaltext.Text = sum.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            gcash gc = new gcash();
            gc.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            paymaya pc = new paymaya();
            pc.Show();

        }

        private void totaltext_TextChanged(object sender, EventArgs e)
        {

        }

        private void payment_TextChanged(object sender, EventArgs e)
        {

        }

        private void change_TextChanged(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

            string username = userbox.Text;
            string items = ConvertDataGridViewToJson(grid);

            string modeOfPayment;
            if (onlinepay.Checked && cashpay.Checked)
            {
                modeOfPayment = "Both";
            }
            else if (onlinepay.Checked)
            {
                modeOfPayment = "Online Payment";
            }
            else if (cashpay.Checked)
            {
                modeOfPayment = "Cash Payment";
            }
            else
            {
                modeOfPayment = "NONE";
            }

            decimal totalAmount = decimal.Parse(totaltext.Text);
            decimal payment = decimal.Parse(paymenttxt.Text);
            decimal change = decimal.Parse(changetxt.Text);

            string connectionString = "server=localhost;database=registration_db;uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO receipt (username, items, mode_of_payment, total_amount, payment, change_pay) " +
                               "VALUES (@Username, @Items, @ModeOfPayment, @TotalAmount, @Payment, @Change)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Items", items);
                    command.Parameters.AddWithValue("@ModeOfPayment", modeOfPayment);
                    command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    command.Parameters.AddWithValue("@Payment", payment);
                    command.Parameters.AddWithValue("@Change", change);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Payment confirmed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to confirm payment.");
                    }
                }
            }
        }
        private string ConvertDataGridViewToJson(DataGridView dataGridView)
        {
           

            var itemsList = new List<Dictionary<string, object>>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                var itemDict = new Dictionary<string, object>();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    itemDict[cell.OwningColumn.Name] = cell.Value;
                }

                itemsList.Add(itemDict);
            }

            return JsonSerializer.Serialize(itemsList);
        
    
   
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("         K-Town Seoul Delight", new Font("Stencil", 12), Brushes.Black, new Point(10, 15));
            e.Graphics.DrawString("                 Cabcaben, Mariveles, Bataan", new Font("Source Code Pro", 8), Brushes.Black, new Point(10, 33));
            e.Graphics.DrawString("                    Contact No. 09666592022", new Font("Source Code Pro", 8), Brushes.Black, new Point(10, 46));
            e.Graphics.DrawString("                       [ RECEIPT ]", new Font("Source Code Pro", 10), Brushes.Black, new Point(10, 60));


            e.Graphics.DrawString("==========================================", new Font("Source Code Pro", 08), Brushes.Black, new Point(10, 450));
            string date = DateTime.Now.ToString("MMMM dd, yyyy HH:mm:ss");
            e.Graphics.DrawString("Date: " + date, new Font("Source Code Pro", 08), Brushes.Black, new Point(10, 470));
            e.Graphics.DrawString("Username: " + label62.Text, new Font("Source Code Pro", 08), Brushes.Black, new Point(10, 480));
            int queueingNumber = random.Next(1, 100);
            e.Graphics.DrawString("Queueing Number: " + queueingNumber.ToString(), new Font("Source Code Pro", 08), Brushes.Black, new Point(10, 490));
            e.Graphics.DrawString("==========================================", new Font("Source Code Pro", 08), Brushes.Black, new Point(10, 510));
            
            if (onlinepay.Checked)
            {
                e.Graphics.DrawString("Mode of Payment : Online Payment", new Font("Source Code Pro", 08), Brushes.Black, new Point(10, 525));
            }
            else if (cashpay.Checked)
            {
                e.Graphics.DrawString("Mode of Payment : Cash Payment", new Font("Source Code Pro", 08), Brushes.Black, new Point(10, 525));
            }
            e.Graphics.DrawString("Total Amount:      ₱" + totaltext.Text + ".00", new Font("Source Code Pro", 15), Brushes.Black, new Point(10, 430));
            e.Graphics.DrawString("Cash: ₱" + paymenttxt.Text + ".00", new Font("Source Code Pro", 10), Brushes.Black, new Point(10, 540));
            e.Graphics.DrawString("Change: ₱" + changetxt.Text + ".00", new Font("Source Code Pro", 10), Brushes.Black, new Point(10,560));


            // Set up drawing variables
            int startX = e.MarginBounds.Left;
            int startY = e.MarginBounds.Top;
            int offsetY = 0;
            int cellHeight = 0;

            // Print header
            foreach (DataGridViewColumn column in grid.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, grid.Font, Brushes.Black, startX, startY + offsetY);
                startX += column.Width / 2;
            }

            offsetY += grid.ColumnHeadersHeight / 2;
            startX = e.MarginBounds.Left;
            // Print rows
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(cell.Value?.ToString(), grid.Font, Brushes.Black, startX, startY + offsetY);
                    startX += cell.OwningColumn.Width / 2;
                    cellHeight = cell.Size.Height;
                }
                offsetY += cellHeight;
                startX = e.MarginBounds.Left;

                // Check if we need to add a new page
                if (startY + offsetY + cellHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;


                }
            }
        }
    


        private void button37_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.PaperSize("Suit Detail", 285, 600);
            printPreviewDialog1.ShowDialog();
        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {
            SignOut so = new SignOut();
           
            so.Show();
            Hide();

            


  
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Promo pr = new Promo();
            pr.Show();
            
        }

        private void button41_Click(object sender, EventArgs e)
        {
            MenuDish pr = new MenuDish();
            pr.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            AboutUs us = new AboutUs();
            us.Show();
            Hide();
        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {


        }


        internal void SetTextBoxValue(string text)
        {
            userbox.Text = text;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            decimal totalAmount = Convert.ToDecimal(totaltext.Text);
            decimal paymentAmount = Convert.ToDecimal(paymenttxt.Text);
            decimal change = paymentAmount - totalAmount;


            changetxt.Text = change.ToString();
        }

        private void grid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

