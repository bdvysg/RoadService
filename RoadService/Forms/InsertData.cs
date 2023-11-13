using RoadService.Classes;
using RoadService.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = RoadService.Classes.Task;

namespace RoadService.Forms
{
    public partial class InsertData : Form
    {
        private UnitOfWork unitOfWork;
        private AddressList addressList;
        private ResourceTimeTable resourceTimeTable;
        private EmployeeTimeTable employeeTimeTable;
        private Task task;
        private List<Employee> employees;
        private List<Resource> resources;
        private List<Stock> stocks;

        public InsertData()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork(new RoadServiceDBContext());
            addressList = new AddressList(unitOfWork);
            task = new Task();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);

            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker3.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            dateTimePicker4.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);

            comboBox2.Items.Add("Матеріал");
            comboBox2.Items.Add("Інструмент");
            comboBox2.Items.Add("Транспорт");
            comboBox2.SelectedIndex = 0;

            LoadEmployees();
            LoadResources();
        }

        public void LoadEmployees()
        {
            employees = unitOfWork.Employee.GetAll().ToList();

            comboBox1.Items.AddRange(employees.Where(u => u.Position == "Дорожній працівник").ToArray());
        }

        public void LoadResources()
        {
            resources = unitOfWork.Resource.GetAll().ToList();
            stocks = unitOfWork.Stock.GetAll(includeProperties: "Resource").ToList();

            comboBox3.Items.AddRange(resources.ToArray());
            comboBox4.Items.AddRange(resources.ToArray());

            dataGridView4.DataSource = stocks;
            dataGridView4.Columns[0].Visible = false;
            dataGridView4.Columns[1].Visible = false;
            dataGridView4.Columns[2].HeaderText = "Ресурс";
            dataGridView4.Columns[3].HeaderText = "Кількість";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = unitOfWork.EmployeeTimeTableItem.GetAll().Count().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeTimeTableItem item = new EmployeeTimeTableItem();
            item.TimeStart = dateTimePicker1.Value;
            item.TimeEnd = dateTimePicker2.Value;
            item.EmployeeId = ((Employee)comboBox1.SelectedItem).Id;
            item.Id = 0;

            unitOfWork.EmployeeTimeTableItem.Add(item);
            unitOfWork.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = unitOfWork.EmployeeTimeTableItem.GetAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            material.Id = 0;
            material.Name = textBox1.Text;
            material.Description = textBox2.Text;
            material.Price = decimal.Parse(textBox3.Text);
            material.UnitOfMeasure = textBox5.Text;

            unitOfWork.Resource.Add(material);
            unitOfWork.Save();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = unitOfWork.Resource.GetAll().Count().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var resources = unitOfWork.Resource.GetAll();
            if (comboBox2.SelectedIndex == 0)
            {
                dataGridView2.DataSource = resources.OfType<Material>().ToList();
            }
            if (comboBox2.SelectedIndex == 1)
            {
                dataGridView2.DataSource = resources.OfType<Tool>().ToList();
            }
            if (comboBox2.SelectedIndex == 2)
            {
                dataGridView2.DataSource = resources.OfType<Transport>().ToList();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                pnlMaterial.Visible = true;
                pnlTools.Visible = false;
                pnlTransport.Visible = false;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                pnlMaterial.Visible = false;
                pnlTools.Visible = true;
                pnlTransport.Visible = false;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                pnlMaterial.Visible = false;
                pnlTools.Visible = false;
                pnlTransport.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tool tool = new Tool();
            tool.Id = 0;
            tool.Name = textBox10.Text;
            tool.Description = textBox9.Text;
            tool.Price = decimal.Parse(textBox8.Text);
            tool.Manufacturer = textBox6.Text;

            unitOfWork.Resource.Add(tool);
            unitOfWork.Save();

            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox6.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            transport.Id = 0;
            transport.Name = textBox15.Text;
            transport.Description = textBox14.Text;
            transport.Price = decimal.Parse(textBox13.Text);
            transport.LicensePlate = textBox11.Text;

            unitOfWork.Resource.Add(transport);
            unitOfWork.Save();

            textBox15.Clear();
            textBox14.Clear();
            textBox13.Clear();
            textBox11.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label28.Text = unitOfWork.ResourceTimeTableItem.GetAll().Count().ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ResourceTimeTableItem item = new ResourceTimeTableItem();
            item.TimeStart = dateTimePicker4.Value;
            item.TimeEnd = dateTimePicker3.Value;
            item.ResourceId = ((Resource)comboBox3.SelectedItem).Id;
            item.Id = 0;

            if (int.TryParse(textBox16.Text, out var num))
            {
                item.Count = num;
            }
            else
            {
                item.Count = 1;
            }

            unitOfWork.ResourceTimeTableItem.Add(item);
            unitOfWork.Save();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = unitOfWork.ResourceTimeTableItem.GetAll();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (int.TryParse(textBox4.Text, out num))
            {
                if (unitOfWork.Stock.GetAll().Select(u => u.ResourceId).Contains((comboBox4.SelectedItem as Resource).Id))
                {
                    Stock item = unitOfWork.Stock.GetAll().First(u => u.ResourceId == (comboBox4.SelectedItem as Resource).Id);
                    item.Count += num;
                    unitOfWork.Stock.Update(item);
                }
                else
                {
                    unitOfWork.Stock.Add(new Stock
                    {
                        Id = 0,
                        ResourceId = (comboBox4.SelectedItem as Resource).Id,
                        Resource = comboBox4.SelectedItem as Resource,
                        Count = num
                    });
                }
                unitOfWork.Save();
            }

            LoadResources();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (int.TryParse(textBox4.Text, out num))
            {
                if (unitOfWork.Stock.GetAll().Select(u => u.ResourceId).Contains((comboBox4.SelectedItem as Resource).Id))
                {
                    Stock item = unitOfWork.Stock.GetAll().First(u => u.ResourceId == (comboBox4.SelectedItem as Resource).Id);
                    item.Count -= num;
                    if (item.Count <= 0) 
                    {
                        MessageBox.Show("Кількість не може бути менше нуля");
                        return;
                    }
                    unitOfWork.Stock.Update(item);
                    unitOfWork.Save();
                }
                else
                {
                    MessageBox.Show("Даного ресурсу не знайдено");
                    return;
                }
                
            }

            LoadResources();
        }
    }
}
