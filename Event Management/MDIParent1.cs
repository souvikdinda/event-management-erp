using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();

        }
        private int ChildFormNumber = 0;
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            //coldplayToolStripMenuItem.Enabled = false;
            //linkinParkToolStripMenuItem.Enabled = false;
            adminToolStripMenuItem2.Enabled = true;
            userToolStripMenuItem.Enabled = true;
            
            Page5 objf1 = new Page5();
            objf1.Show();
            objf1.MdiParent = this;
            objf1.Dock = DockStyle.Fill;
            
           //loginToolStripMenuItem.Enabled = false;
            
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userToolStripMenuItem.Enabled = true;
            adminToolStripMenuItem2.Enabled = true;
            Page4 objf1 = new Page4();
            objf1.Show();
            objf1.MdiParent = this;
            objf1.Dock = DockStyle.Fill;
           
        }

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void coldplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userToolStripMenuItem.Enabled = false;
            adminToolStripMenuItem2.Enabled = false;
            registerToolStripMenuItem1.Enabled = false;
            Page6_1_ objf1 = new Page6_1_();
            objf1.Show();
            objf1.MdiParent = this;
            objf1.Dock = DockStyle.Fill;
            loginToolStripMenuItem.Enabled = false;
        }

        private void linkinParkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userToolStripMenuItem.Enabled = false;
            adminToolStripMenuItem2.Enabled = false;
            registerToolStripMenuItem1.Enabled = false;
            Page6_2_ objf1 = new Page6_2_();
            objf1.Show();
            objf1.MdiParent = this;
            objf1.Dock = DockStyle.Fill;
            loginToolStripMenuItem.Enabled = false;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objf1 = new Form1();
            objf1.Show();
            objf1.MdiParent = this;
            objf1.Dock = DockStyle.Fill;
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact objf1 = new Contact();
            objf1.Show();
            objf1.MdiParent = this;
            objf1.Dock = DockStyle.Fill;
            loginToolStripMenuItem.Enabled = false;
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminToolStripMenuItem2.Enabled = true;
            registerToolStripMenuItem1.Enabled = true;
            //coldplayToolStripMenuItem.Enabled = false;
            //linkinParkToolStripMenuItem.Enabled = false;
            Page2 objf1 = new Page2();
            objf1.Show();
            objf1.MdiParent = this;
            objf1.Dock = DockStyle.Fill;
            //loginToolStripMenuItem.Enabled = false;
        }

        private void adminToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            userToolStripMenuItem.Enabled = false;
            registerToolStripMenuItem1.Enabled = false;
            //coldplayToolStripMenuItem.Enabled = false;
           // linkinParkToolStripMenuItem.Enabled = false;
            Page7 objf1 = new Page7();
            objf1.Show();
            objf1.MdiParent = this;
            objf1.Dock = DockStyle.Fill;
            loginToolStripMenuItem.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIParent1 m = new MDIParent1();
            m.Close();
        }

        private void concertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
