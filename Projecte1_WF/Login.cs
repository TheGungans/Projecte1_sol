using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

namespace Projecte1_WF
{
    public partial class Login : Form
    {
        public Login()
        {
            Thread tardar = new Thread(new ThreadStart(pantalla));
            tardar.Start();
            Thread.Sleep(1000);

            InitializeComponent();

            tardar.Abort();
        }

        public void pantalla() { Application.Run(new Splash()); }

        
    }
}
