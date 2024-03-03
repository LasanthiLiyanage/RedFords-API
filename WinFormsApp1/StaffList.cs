using Microsoft.AspNetCore.Http.Extensions;
using Newtonsoft.Json;
using RadFordsApp.Shared;
using RedFords_API.Models.DTO;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class StaffList : Form
    {
        public Guid StaffId = Guid.Empty;
        public StaffList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private async void LoadGridData()
        {
            try
            {
                var response = await APIHelper.GetAll();
                var staffList = JsonConvert.DeserializeObject<List<StaffDto>>(response);
                grd_Staff.DataSource = staffList.Select(a => a.Status == "Active");

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

        private void grd_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Guid Id = Guid.Empty;
            if (grd_Staff.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in grd_Staff.SelectedRows)
                {
                    Id = Guid.Parse(row.Cells["Id"].ToString());
                    StaffDto staffDto = new StaffDto
                    {                        
                        Id = Guid.Parse(row.Cells["Id"].ToString()),
                        StaffType = Guid.Parse(row.Cells["StaffType"].ToString()),
                        Title = Guid.Parse(row.Cells["Title"].ToString()),
                        FirstName = row.Cells["FirstName"].ToString(),
                        LastName = row.Cells["LastName"].ToString(),
                        CellPhone = row.Cells["CellPhone"].ToString(),
                        MiddleInitial = row.Cells["MiddleInitial"].ToString(),
                        HomePhone = row.Cells["HomePhone"].ToString(),
                        IRDNumber = Convert.ToInt32(row.Cells["IRDNumber"]),
                        OfficeExtension = Convert.ToInt32(row.Cells["OfficeExtension"]),
                        ManagerId = Guid.Parse(row.Cells["ManagerId"].ToString()),
                    };
                    var response = APIHelper.Put(Id, staffDto);
                }               

            }
        }
        
    }
}
