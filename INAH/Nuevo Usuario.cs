using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace INAH
{
    public partial class Nuevo_Usuario : Form
    {
        public Nuevo_Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios login = new Usuarios();
            login.Show();
        }
    }
}
