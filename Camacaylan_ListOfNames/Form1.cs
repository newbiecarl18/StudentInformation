using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camacaylan_ListOfNames
{

    public partial class frmNames : Form
    {
        public frmNames()
        {
            InitializeComponent();
        }

        private void frmNames_Load(object sender, EventArgs e)
        {
            InitializeListBox();
            LoadDefaultNames();
        }

        private void InitializeListBox()
        {
            lstListOfNames.SelectionMode = SelectionMode.MultiExtended;
            lstListOfNames.HorizontalScrollbar = true;
        }

        private void LoadDefaultNames()
        {
            lstListOfNames.Items.AddRange(new string[]
            {
                "Camacaylan",
                "Davine",
                "Carl",
                "Atig",
                "Mamamoblue"
            });
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            AddName();
        }

        private void AddName()
        {
            string name = txt_InputName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(
                    "Name cannot be empty.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (lstListOfNames.Items.Contains(name))
            {
                MessageBox.Show(
                    "This name already exists in the list.",
                    "Duplicate Entry",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            lstListOfNames.Items.Add(name);
            txt_InputName.Clear();
            txt_InputName.Focus();
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            DeleteSelectedNames();
        }

        private void DeleteSelectedNames()
        {
            if (lstListOfNames.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select at least one name to delete.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the selected name(s)?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            lstListOfNames.BeginUpdate();

            for (int i = lstListOfNames.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstListOfNames.Items.RemoveAt(lstListOfNames.SelectedIndices[i]);
            }

            lstListOfNames.EndUpdate();
        }

        private void btn_CLEAR_Click(object sender, EventArgs e)
        {
            if (lstListOfNames.Items.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "This will remove all names. Continue?",
                "Clear List",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                lstListOfNames.Items.Clear();
            }
        }

        // Keyboard Enhancements
        private void txt_InputName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddName();
                e.SuppressKeyPress = true;
            }
        }

        private void lstListOfNames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedNames();
            }
        }
    }
}