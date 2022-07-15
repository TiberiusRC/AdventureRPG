using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureRPG
{
    public partial class AdventureRPG : Form
    {
        private Player _player;
        public AdventureRPG()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house.");
            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house.";
            //Creating a new player with start values
            _player = new Player(10, 10, 20, 0, 1);          
            
            //Player properties to label
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        //UI Controls
        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
