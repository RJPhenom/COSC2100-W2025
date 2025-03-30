using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace COSC2100_ICE8_RobertMacklem
{
    public partial class frmMain : Form
    {
        // CONSTS
        const string JSON_FILE = "Victims.json";

        // PROPS
        // Binding list is bound to the datagridview s the GUI updates automatically.
        public BindingList<Victim> Victims = new BindingList<Victim>()
        {
            new Victim("John Doe"),
            new Victim("Jane Doe")
        };

        /// <summary>
        /// Save the list into a JSON file.
        /// </summary>
        void SaveJSON()
        {
            string json = JsonSerializer.Serialize(Victims);
            File.WriteAllText(JSON_FILE, json);
        }

        /// <summary>
        /// Reads the JSON_FILE and deserializes it to populate the victims list.
        /// </summary>
        void LoadJSON()
        {
            string json = File.ReadAllText(JSON_FILE);
            Victims = JsonSerializer.Deserialize<BindingList<Victim>>(json);
        }

        public frmMain()
        {
            InitializeComponent();

            // If there is no extant file, create one via the SaveJSON method.
            if (!File.Exists(JSON_FILE))
            {
                SaveJSON();
            }

            // If there is an extant file, read it and deserialize it into the binding list var 'victims'.
            else
            {
                LoadJSON();
            }

            // Bind the datagridview data source to the binding list var 'victims'.
            dgvVictims.DataSource = Victims;
        }

        /// <summary>
        /// Opens the 'Add New Victim' modal form for add victim functionality.
        /// </summary>
        private void btnAddVictim_Click(object sender, EventArgs e)
        {
            AddVictim addVictimForm = new AddVictim(Victims);
            addVictimForm.ShowDialog();
            SaveJSON();
        }

        /// <summary>
        /// Removes all checked off Victims from the Vitcms list.
        /// </summary>
        private void btnClearJobs_Click(object sender, EventArgs e)
        {
            // Go through all victims
            for (int i = Victims.Count - 1; i >= 0; i--)
            {
                // If the victim is dead
                if (Victims[i].IsDead)
                {
                    Victims.RemoveAt(i);
                }
            }

            // Save changes
            SaveJSON();
        }

        /// <summary>
        /// Save updates in the table to the JSON file.
        /// </summary>
        private void dgvVictims_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SaveJSON();
        }
    }
}
