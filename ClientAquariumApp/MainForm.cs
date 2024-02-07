using System;
using System.Windows.Forms;
using System.Configuration;

namespace ClientAquariumApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void listAquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("DashboardAquariums"))
            {
                DashboardAquariums dashboardAquariums = new DashboardAquariums();
                dashboardAquariums.MdiParent = this;
                dashboardAquariums.Show();
            }
        }

        private void addAquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("NewAquariumForm"))
            {
                NewAquariumForm newAquariumForm = new NewAquariumForm();
                newAquariumForm.MdiParent = this;
                newAquariumForm.Show();
            }
        }

        private void addJlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("NewJournalForm"))
            {
                NewJournalForm newJournalForm = new NewJournalForm();
                newJournalForm.MdiParent = this;
                newJournalForm.Show();
            }
        }

        private void editJlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("EditJournalForm"))
            {
                EditJournalForm editJournalForm = new EditJournalForm();
                editJournalForm.MdiParent = this;
                editJournalForm.Show();
            }
        }

        private void listJlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("JournalListsForm"))
            {
                JournalListsForm journalListsForm = new JournalListsForm();
                journalListsForm.MdiParent = this;
                journalListsForm.Show();
            }
        }


        private void addMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string formNameToOpen = "AddMaintenanceTypeForm";

            if (!IsFormAlreadyOpened(formNameToOpen))
            {
                AddMaintenanceTypeForm addTypeForm = new AddMaintenanceTypeForm();
                addTypeForm.Name = formNameToOpen;
                addTypeForm.MdiParent = this;
                addTypeForm.Show();
            }
        }
    }
}



