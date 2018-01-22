using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace PA5_GreenSteven_PokeDexWithClasses
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private List<Pokemon> _Pokedex = new List<Pokemon>();

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmPokemon f1 = new frmPokemon();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                Pokemon p = (Pokemon)f1.Tag;
                _Pokedex.Add(p);
            }
            else { }
            pokeGrid();
            label1Refresh();
        }
        private void label1Refresh()
        {
            int x = _Pokedex.Count();
            label1.Text = (x + " Pokemon added");
        }
        private void pokeGrid()
        {//tie the grid to tthe list
            dgvPokemon.DataSource = typeof(Pokemon);
            dgvPokemon.DataSource = _Pokedex;
        }
        private void btnDataFill_Click(object sender, EventArgs e)
        {//data fill button
            btnDataFill.Enabled = false;
            _Pokedex.Add(new Pokemon("Bulbasaur", "Grass", 20, 0.71, 6.9));
            _Pokedex.Add(new Pokemon("Charmander", "Fire", 18, 0.61, 8.5));
            _Pokedex.Add(new Pokemon("Squirtle", "Water", 22, 0.51, 9.0));
            _Pokedex.Add(new Pokemon("Pikachu", "Electric", 18, 0.41, 6.0));
            _Pokedex.Add(new Pokemon("Pidgey", "Flying", 16, 0.30, 1.8));
            _Pokedex.Add(new Pokemon("Nidoran♀", "Poison", 18, 0.41, 7.0));
            pokeGrid();
            label1Refresh();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemon.SelectedRows.Count > 0)
            {
                //reload the pokemans
                PokeReload();
                
            }
        }

        private void PokeReload()
        {//load the selection into the text box
            txtbxName.Text = dgvPokemon.SelectedRows[0].Cells["Name"].Value.ToString();
            txtbxType.Text = dgvPokemon.SelectedRows[0].Cells["Type"].Value.ToString();
            txtbxHP.Text = dgvPokemon.SelectedRows[0].Cells["HP"].Value.ToString();
            txtbxHeight.Text = dgvPokemon.SelectedRows[0].Cells["Height"].Value.ToString();
            txtbxWeight.Text = dgvPokemon.SelectedRows[0].Cells["Weight"].Value.ToString();

        }


        private void btnName_Click(object sender, EventArgs e)
        {
            rbName.Checked = true;
            _Pokedex.Sort(delegate(Pokemon x, Pokemon y) 
            { return x.Name.CompareTo(y.Name); });
            pokeGrid();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            rbType.Checked = true;
            _Pokedex.Sort(delegate(Pokemon x, Pokemon y) 
            { return x.Type.CompareTo(y.Type); });
            pokeGrid();
        }

        private void btnHP_Click(object sender, EventArgs e)
        {
            rbHP.Checked = true;
            _Pokedex.Sort(delegate(Pokemon x, Pokemon y)
            { return x.HP.CompareTo(y.HP); });
            pokeGrid();
        }


        private void btnWeight_Click(object sender, EventArgs e)
        {
            rbWeight.Checked = true;
            _Pokedex.Sort(delegate(Pokemon x, Pokemon y) 
            { return x.Weight.CompareTo(y.Weight); });
            pokeGrid();
        }

        private void btnHeight_Click(object sender, EventArgs e)
        {
            rbHeight.Checked = true;
            _Pokedex.Sort(delegate(Pokemon x, Pokemon y) 
            { return x.Height.CompareTo(y.Height); });
            pokeGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void txtbxName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}