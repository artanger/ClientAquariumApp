using System;
using System.Windows.Forms;

namespace ClientAquariumApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void getAquariumsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("DashboardAquariums"))
            {
                DashboardAquariums dashboardAquariums = new DashboardAquariums();
                dashboardAquariums.MdiParent = this;
                dashboardAquariums.Show();
            }
        }

        private void addNewAquariumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("NewAquariumForm"))
            {
                NewAquariumForm newAquariumForm = new NewAquariumForm();
                newAquariumForm.MdiParent = this;
                newAquariumForm.Show();
            }
        }

        private void addJournalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("NewJournalForm"))
            {
                NewJournalForm newJournalForm = new NewJournalForm();
                newJournalForm.MdiParent = this;
                newJournalForm.Show();
            }
        }
        private void editJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("EditJournalForm"))
            {
                EditJournalForm editJournalForm = new EditJournalForm();
                editJournalForm.MdiParent = this;
                editJournalForm.Show();
            }

        }

        private void addTypeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string formNameToOpen = "AddTypeForm";

            if (!IsFormAlreadyOpened(formNameToOpen))
            {
                AddTypeForm addTypeForm = new AddTypeForm();
                addTypeForm.Name = formNameToOpen;
                addTypeForm.MdiParent = this;
                addTypeForm.Show();
            }

        }

        private bool IsFormAlreadyOpened(string formName)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name.Equals(formName))
                {
                    return true;
                }
            }
            return false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void aquariumToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}



