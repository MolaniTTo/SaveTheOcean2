using AC4.Persistence.Mapping;
using AC4.Persistence.Utils;
using SaveTheOcean2.DTO;
using SaveTheOcean2.Persistence.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheOcean2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            IRescueDAO recordDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            List<Rescue> rescues = recordDAO.GetRescues();
            dataGridSelectAll.DataSource = rescues;
        }

        private void buttonSearchId_Click(object sender, EventArgs e)
        {
            if (TBId.Text == "")
            {
                errorId.SetError(TBId, "Please enter a valid ID");
            }
            else
            {
                IRescueDAO recordDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
                List<Rescue> rescue = recordDAO.GetRescueById(TBId.Text);
                if (rescue[0].IdRescue == TBId.Text)
                {
                    dataGridSelectId.DataSource = rescue;
                }
                else
                {
                    MessageBox.Show("No rescue found with that ID");
                }

            }
        }

        private void dataGridSelectAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAllRescues_Click(object sender, EventArgs e)
        {

        }
    }
}
