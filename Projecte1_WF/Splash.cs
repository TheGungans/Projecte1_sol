using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte1_WF
{
    
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void time_carga_Tick(object sender, EventArgs e)
        {
            /*this.barra_carga.Increment(1);

            if (barra_carga.Value == 100)
            {
                this.time_carga.Stop();
                this.Hide();

                Login login = new Login();
                login.Show();
            }*/

            panel2.Width += 5;
            if(panel2.Width>= 766)
            {
                time_carga.Stop();
                this.Hide();

                Login login = new Login();
                login.Show();
            }
        }

        
    }
}
