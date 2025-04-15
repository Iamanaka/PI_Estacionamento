using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form menuCADASTRO = new menuCADASTRO();
            menuCADASTRO.MdiParent = this;
            menuCADASTRO.Show();

            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form menuCLIENTE = new menuCLIENTE();
            menuCLIENTE.MdiParent = this;
            menuCLIENTE.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form menuFUNCIONARIO = new menuFUNCIONARIO();
            menuFUNCIONARIO.MdiParent = this;
            menuFUNCIONARIO.Show();
        }

        private void avulsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form menuFINANCEIRO = new menuFINANCEIRO();
            menuFINANCEIRO.MdiParent = this;
            menuFINANCEIRO.Show();
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvedores:\nCamila Lourenço   (12) 98765-3214\nLauro Iamanaka    (12) 91234-5678");
        }
    }
}
