using RoadService.Classes;
using RoadService.Repository;
using System.Data;
using Task = RoadService.Classes.Task;

namespace RoadService.Forms
{
    public partial class InsertData : Form
    {
        private UnitOfWork unitOfWork;
        private List<Employee> employees;
        private List<Resource> resources;
        private List<Stock> stocks;

        public InsertData()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork(new RoadServiceDBContext());

            DateManager.SetUpDateTimePicker(dtpETT);
            DateManager.SetUpDateTimePicker(dtp2ETT);
            DateManager.SetUpDateTimePicker(dtp2ResTT);
            DateManager.SetUpDateTimePicker(dtp1ResTT);

            cmbTypeRes.Items.Add("Матеріал");
            cmbTypeRes.Items.Add("Інструмент");
            cmbTypeRes.Items.Add("Транспорт");
            cmbTypeRes.SelectedIndex = 0;

            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage3);


            LoadEmployees();
            LoadResources();
        }

        public void LoadEmployees()
        {
            employees = unitOfWork.Employee.GetAll().ToList();

            cmbEmpTT.Items.AddRange(employees.Where(u => u.Position == "Дорожній працівник").ToArray());
        }

        public void LoadResources()
        {
            resources = unitOfWork.Resource.GetAll().ToList();
            stocks = unitOfWork.Stock.GetAll(includeProperties: "Resource").ToList();

            cmbResTT.Items.Clear();
            cmbRes.Items.Clear();

            cmbResTT.Items.AddRange(resources.ToArray());
            cmbRes.Items.AddRange(resources.ToArray());

            dgvStock.DataSource = stocks;
            dgvStock.Columns[0].Visible = false;
            dgvStock.Columns[1].Visible = false;
            dgvStock.Columns[2].HeaderText = "Ресурс";
            dgvStock.Columns[3].HeaderText = "Кількість";


        }

        private void ResfreshDgv2()
        {
            var resources = unitOfWork.Resource.GetAll();
            if (cmbTypeRes.SelectedIndex == 0)
            {
                dgvRes.DataSource = resources.OfType<Material>().ToList();
            }
            if (cmbTypeRes.SelectedIndex == 1)
            {
                dgvRes.DataSource = resources.OfType<Tool>().ToList();
            }
            if (cmbTypeRes.SelectedIndex == 2)
            {
                dgvRes.DataSource = resources.OfType<Transport>().ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = unitOfWork.EmployeeTimeTableItem.GetAll().Count().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeTimeTableItem item = new EmployeeTimeTableItem();
            item.TimeStart = dtpETT.Value;
            item.TimeEnd = dtp2ETT.Value;
            item.EmployeeId = ((Employee)cmbEmpTT.SelectedItem).Id;
            item.Id = 0;

            unitOfWork.EmployeeTimeTableItem.Add(item);
            unitOfWork.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvEmpTT.DataSource = unitOfWork.EmployeeTimeTableItem.GetAll();
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
            lblCountRes.Text = unitOfWork.Resource.GetAll().Count().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResfreshDgv2();
        }

        private void cmbTypeRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeRes.SelectedIndex == 0)
            {
                pnlMaterial.Visible = true;
                pnlTools.Visible = false;
                pnlTransport.Visible = false;
            }
            if (cmbTypeRes.SelectedIndex == 1)
            {
                pnlMaterial.Visible = false;
                pnlTools.Visible = true;
                pnlTransport.Visible = false;
            }
            if (cmbTypeRes.SelectedIndex == 2)
            {
                pnlMaterial.Visible = false;
                pnlTools.Visible = false;
                pnlTransport.Visible = true;
            }
            ResfreshDgv2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tool tool = new Tool();
            tool.Id = 0;
            tool.Name = txtBName.Text;
            tool.Description = txtBDesc.Text;
            tool.Price = decimal.Parse(txtBPrice.Text);
            tool.Manufacturer = txtBManuf.Text;

            unitOfWork.Resource.Add(tool);
            unitOfWork.Save();

            txtBName.Clear();
            txtBDesc.Clear();
            txtBPrice.Clear();
            txtBManuf.Clear();
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
            item.TimeStart = dtp1ResTT.Value;
            item.TimeEnd = dtp2ResTT.Value;
            item.ResourceId = ((Resource)cmbResTT.SelectedItem).Id;
            item.Id = 0;

            if (int.TryParse(txtBResTTCount.Text, out var num))
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
            dgvResTT.DataSource = unitOfWork.ResourceTimeTableItem.GetAll();
        }


        private void button13_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (int.TryParse(txtBCount.Text, out num))
            {
                if (unitOfWork.Stock.GetAll().Select(u => u.ResourceId).Contains((cmbRes.SelectedItem as Resource).Id))
                {
                    Stock item = unitOfWork.Stock.GetAll().First(u => u.ResourceId == (cmbRes.SelectedItem as Resource).Id);
                    item.Count += num;
                    unitOfWork.Stock.Update(item);
                }
                else
                {
                    unitOfWork.Stock.Add(new Stock
                    {
                        Id = 0,
                        ResourceId = (cmbRes.SelectedItem as Resource).Id,
                        Resource = cmbRes.SelectedItem as Resource,
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

            if (int.TryParse(txtBCount.Text, out num))
            {
                if (unitOfWork.Stock.GetAll().Select(u => u.ResourceId).Contains((cmbRes.SelectedItem as Resource).Id))
                {
                    Stock item = unitOfWork.Stock.GetAll().First(u => u.ResourceId == (cmbRes.SelectedItem as Resource).Id);
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

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbRes.SelectedItem is Material)
            {
                label11.Text = "Кількість ( " + (cmbRes.SelectedItem as Material).UnitOfMeasure + " )";
            }
            else
            {
                label11.Text = "Кількість";
            }
        }
    }
}
