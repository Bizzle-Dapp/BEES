using System;
using System.ComponentModel;
using System.Windows.Forms;
using Hive;

namespace BEES
{
    public partial class BeehiveUI : Form
    {
        DataGridView dgv_Bees = new DataGridView();
        private BindingList<Bee> HiveContents = new BindingList<Bee>();
        public BeehiveUI()
        {
            InitializeComponent();
            GenerateHive(10, 10, 10); // Your application should create a single list containing 10 instances of each type of Bee.
            dgv_Bees.Dock = DockStyle.Fill;
            dgv_Bees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewPanel.Controls.Add(dgv_Bees);
            dgv_Bees.DataSource = HiveContents; // Databind the list of Bees to our DataGridView.
        }

        private void GenerateHive(int workers, int drones, int queens)
        {
            for (var i = 0; i < workers; i++)
            {
                HiveContents.Add(new Worker());
            }
            for (var i = 0; i < drones; i++)
            {
                HiveContents.Add(new Drone());
            }
            for (var i = 0; i < queens; i++)
            {
                HiveContents.Add(new Queen());
            }

        }

        private int RandomNumber(Random rand)
        {
            return rand.Next(0, 81);
        }

        private void Btn_InsectRepellent_Click(object sender, EventArgs e)
        {
            // I learned a very valuble lesson about Random() here, using this article as a conduit to a solution: https://stackoverflow.com/questions/767999/random-number-generator-only-generating-one-random-number
            // Random is used by the clock and thus I should use the same instantiation of Random(). Very interesting indeed!
            var rand = new Random();
            foreach (var bee in HiveContents)
            {
                bee.Damage(RandomNumber(rand));
            }
            dgv_Bees.Refresh();
        }
    }
}
