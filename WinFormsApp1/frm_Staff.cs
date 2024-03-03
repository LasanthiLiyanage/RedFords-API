using Microsoft.VisualBasic;
using Newtonsoft.Json;
using RadFordsApp.Shared;
using RedFords_API.Models;
using RedFords_API.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadFordsApp
{
    public partial class frm_Staff : Form
    {
        public Guid StaffId = Guid.Empty;
        public frm_Staff()
        {
            InitializeComponent();
        }

        private void frm_Staff_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private async void LoadGridData()
        {
            try
            {
                var response = await APIHelper.GetAll();
                var staffList = JsonConvert.DeserializeObject<List<StaffDto>>(response);
                grd_Staff.DataSource = staffList.Where(a => a.Status == "Active").ToList();

                GridPropeties();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GridPropeties()
        {
            try
            {
                grd_Staff.Columns["Id"].Visible = false;
                grd_Staff.Columns["StaffType"].Visible = false;
                grd_Staff.Columns["Title"].Visible = false;
                grd_Staff.Columns["MiddleInitial"].Visible = false;
                grd_Staff.Columns["ManagerId"].Visible = false;
                grd_Staff.Columns["FirstName"].HeaderText = "First Name";
                grd_Staff.Columns["LastName"].HeaderText = "Last Name";
                grd_Staff.Columns["HomePhone"].HeaderText = "Home Phone";
                grd_Staff.Columns["CellPhone"].HeaderText = "Cell Phone";
                grd_Staff.Columns["IRDNumber"].HeaderText = "IRD Number";
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var staffDto = new StaffDto
            {
                Id = Guid.NewGuid(),
                StaffType = Guid.Empty,
                CellPhone = txt_CellPone.Text,
                FirstName = txt_firstName.Text,
                LastName = txt_LastName.Text,
                HomePhone = txt_HomePhone.Text,
                MiddleInitial = txt_Middle_Initial.Text,
                ManagerId = Guid.Empty,
                IRDNumber = Convert.ToInt32(txt_IrdNo.Text),
                OfficeExtension = Convert.ToInt32(txt_Extension.Text),
                Status = cmbStatus.Text,
                Title = Guid.Empty
            };

            var response = APIHelper.Post(staffDto);

            LoadGridData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var staffDto = new StaffDto
            {
                Id = StaffId,
                StaffType = Guid.Empty,
                CellPhone = txt_CellPone.Text,
                FirstName = txt_firstName.Text,
                LastName = txt_LastName.Text,
                HomePhone = txt_HomePhone.Text,
                MiddleInitial = txt_Middle_Initial.Text,
                ManagerId = Guid.Empty,
                IRDNumber = Convert.ToInt32(txt_IrdNo.Text),
                OfficeExtension = Convert.ToInt32(txt_Extension.Text),
                Title = Guid.Empty
            };

            var response = APIHelper.Put(StaffId, staffDto);

            LoadGridData();
        }

        private void grd_Staff_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {

                if (grd_Staff.SelectedRows.Count != 0)
                {
                    foreach (DataGridViewRow row in grd_Staff.SelectedRows)
                    {
                        StaffId = Guid.Parse(row.Cells["Id"].Value.ToString());

                        cmbStaffType.ValueMember = row.Cells["StaffType"].Value.ToString();
                        cmbTitle.ValueMember = row.Cells["Title"].Value.ToString();
                        txt_firstName.Text = row.Cells["FirstName"].Value.ToString();
                        txt_LastName.Text = row.Cells["LastName"].Value.ToString();
                        txt_CellPone.Text = row.Cells["CellPhone"].Value.ToString();
                        txt_Middle_Initial.Text = row.Cells["MiddleInitial"].Value.ToString();
                        txt_HomePhone.Text = row.Cells["HomePhone"].Value.ToString();
                        txt_IrdNo.Text = row.Cells["IRDNumber"].Value.ToString();
                        txt_Extension.Text = row.Cells["OfficeExtension"].Value.ToString();
                        cmbManger.ValueMember = row.Cells["ManagerId"].Value.ToString();
                    }
                }
                else
                {
                    //MessageBox.Show("Please select the row in grid.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grd_Staff.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = grd_Staff.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[grd_Staff.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += grd_Staff.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < grd_Staff.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += grd_Staff.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var response = APIHelper.Delete(StaffId);
            LoadGridData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbStaffType.ValueMember = "";
            cmbTitle.ValueMember = "";
            txt_firstName.Text = "";
            txt_LastName.Text = "";
            txt_CellPone.Text = "";
            txt_Middle_Initial.Text = "";
            txt_HomePhone.Text = "";
            txt_IrdNo.Text = "";
            txt_Extension.Text = "";
            cmbManger.ValueMember = "";
        }
    }
}
