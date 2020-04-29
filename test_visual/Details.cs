using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Details : Form
    {
        public Details(SzwalniaEntities db, ,String employeeLastName)
        {
            InitializeComponent();
            Pracownicy employee = db.Pracownicy
                .Where(pracownik => pracownik.Nazwisko == employeeLastName).First();

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        private void dgvRecordsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
