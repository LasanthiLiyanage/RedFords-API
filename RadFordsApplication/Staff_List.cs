using Newtonsoft.Json;
using RadFordsApplication.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadFordsApplication
{
    public partial class Staff_List : Form
    {
        public Staff_List()
        {
            InitializeComponent();
        }

        private void Staff_List_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private async void LoadGridData()
        {
            try
            {
               var response = await APIHelper.GetAll();
                var personList = JsonConvert.DeserializeObject<List<StaffDto>>(response);
                dataGridView1.DataSource = response;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
