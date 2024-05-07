using SaveTheOcean2.DTO;

using static System.Windows.Forms.Design.AxImporter;
using System.Windows.Forms;
using AC4.Persistence.Mapping;
using AC4.Persistence.Utils;
using SaveTheOcean2.Persistence.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaveTheOcean2
{
    public partial class Form1 : Form
    {
        public static string action = "";
        public Form1()
        {
            InitializeComponent();
            DGRescue.Hide();
            DGRescueAnimal.Hide();
            lblAct.Hide();
            lblResult.Hide();
            Button1.Hide();
            Button2.Hide();
            CBOccupation.Hide();
            lblPlayer.Hide();
            lblOcupation.Hide();
            TBName.Hide();
            BRescue.Hide();
            CBOccupation.Items.Add("Veterinarian");
            CBOccupation.Items.Add("Technician");
            if(!File.Exists("Players.xml"))
            {
                Methods.XMLPlayers();
            }
           
            Rescue rescue = new Rescue();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BJugar_Click(object sender, EventArgs e)
        {
            lblPlayer.Show();
            lblOcupation.Show();
            TBName.Show();
            CBOccupation.Show();
            BRescue.Show();
            BPlay.Hide();


        }

        private void BSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbOfici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BRescue_Click(object sender, EventArgs e)
        {
            lblResult.Hide();
            Button1.Show();
            Button2.Show();

            if (TBName.Text == "" || TBName.Text.Length < 3)
            {
                errorName.SetError(TBName, "Enter a name with at least 3 characters");
            }
            else if (CBOccupation.SelectedIndex == -1)
            {
                errorOccupation.SetError(CBOccupation, "Please select an occupation");
            }
            else
            {
                errorName.Clear();
                errorOccupation.Clear();

                Rescue rescue = new Rescue();

                DGRescue.DataSource = new List<Rescue> { rescue };
                DGRescueAnimal.DataSource = new List<AAnimal> { rescue.Animal };
                DGRescue.Show();
                DGRescueAnimal.Show();
                lblAct.Show();
                Button1.Show();
                Button2.Show();

            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            List<Rescue> rescues = (List<Rescue>)DGRescue.DataSource;

            Rescue rescue = rescues[0];
            int x = 0;

            if (rescue.Animal.SuperFamily == "Cetacean")
            {
                x = 50;
            }
            else if (rescue.Animal.SuperFamily == "Sea Turtle")
            {
                x = 15;
            }
            else
            {
                x = 5;
            }

            Player player = new Player(TBName.Text, CBOccupation.Text);

            if (rescue.Animal.CalcGA(rescue.GA, x) < 30)
            {
                lblResult.Text = "THE ANIMAL IS HEALED, YOU GAIN 50XP";
                player.Xp += 50;
            }
            else
            {

                lblResult.Text = "THE ANIMAL IS NOT HEALED, YOU LOSE 20XP";
                player.Xp -= 20;
            }
            Methods.WriteXML(player);
            lblResult.Show();
            IRescueDAO recordDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            recordDAO.AddRescue(rescue);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<Rescue> rescues = (List<Rescue>)DGRescue.DataSource;

            Rescue rescue = rescues[0];
            int x = 0;

            if (rescue.Animal.SuperFamily == "Cetacean")
            {
                x = 0;
            }
            else if (rescue.Animal.SuperFamily == "Sea Turtle")
            {
                x = 15;
            }
            else
            {
                x = 0;
            }

            Player player = new Player(TBName.Text, CBOccupation.Text);
            if (rescue.Animal.CalcGA(rescue.GA, x) < 30)
            {
                lblResult.Text = "THE ANIMAL IS HEALED, YOU GAIN 50XP";
                player.Xp += 50;
            }
            else
            {
                lblResult.Text = "THE ANIMAL IS NOT HEALED, YOU LOSE 20XP";
                player.Xp -= 20;
            }
            Methods.WriteXML(player);
            lblResult.Show();
            IRescueDAO recordDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            recordDAO.AddRescue(rescue);

        }

        private void LabelResult_Click(object sender, EventArgs e)
        {

        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
