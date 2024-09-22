using BibliotecaHerecia.Miembros;
using BibliotecaHerecia.Libros;
using BibliotecaHerecia.Prestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaHerecia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CustomizeDesing();
        }

        private void CustomizeDesing()
        {
            pnlsubmenu1.Visible = false;
            pnlsubmenu2.Visible = false;
            pnlsubmenu3.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlsubmenu1.Visible == true)
                pnlsubmenu1.Visible = false;
            if (pnlsubmenu2.Visible == true)
                pnlsubmenu2.Visible = false;
            if (pnlsubmenu3.Visible == true)
                pnlsubmenu3.Visible = false;
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlsubmenu1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoMiembro nuevoMiembro = new NuevoMiembro();
            nuevoMiembro.ShowDialog();
            hideSubMenu();
        }

        private void btnAdministrarLibros_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlsubmenu2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevoLibro nuevoLibro = new NuevoLibro();
            nuevoLibro.ShowDialog();
            hideSubMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form verMiembrosForm = new VerMiembros();
            verMiembrosForm.Show();
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form verLibrosForm = new VerLibros();
            verLibrosForm.Show();
            hideSubMenu();
        }

        private void btnprestamolibro_Click(object sender, EventArgs e)
        {
            Form realizarPrestamoForm = new RealizarPrestamo();
            realizarPrestamoForm.Show();
            hideSubMenu();
        }

        private void btnpresamo_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlsubmenu3);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
