using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladiMusic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DesingPanel();
        }

        private void DesingPanel()
        {
            panelMediaSubmenu.Visible = false;
            panelPlayList.Visible = false;
            panelTools.Visible = false;
            
        }



        private void EsconderSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if(panelPlayList.Visible == true)
                panelPlayList.Visible = false;
            if(panelTools.Visible == true)
                panelTools.Visible = false;
        }

        private void MostrarMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }





        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelMediaSubmenu);
        }

        private void btnAbrirArchivos_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Form2());
            EsconderSubMenu();
        }

        private void btnAbrirCarpetas_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnDiscoAbierto_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnAbrirMedia_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelPlayList);
        }

        private void btnNuevaLista_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnAdminLista_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnImportarLista_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnExportarLista_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelTools);
        }

        private void btnMediaConvert_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnEfectosFiltros_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnPreferencias_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }


        // Mostrar un unico formulario
        private Form formActivo = null;
        private void abrirChildForm(Form childform)
        {
            if (formActivo != null) formActivo.Close();
            formActivo = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childform);
            panelChildForm.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Form3());
            EsconderSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir de la aplicación?", "VLADI MUSIC | SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}