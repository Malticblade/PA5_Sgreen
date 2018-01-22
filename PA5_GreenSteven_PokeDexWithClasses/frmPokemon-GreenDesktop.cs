using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA5_GreenSteven_PokeDexWithClasses
{
    public partial class frmPokemon : Form
    {
        //create a list
        private List<Pokemon> Pokedex = new List<Pokemon>();

        public frmPokemon()
        {
            InitializeComponent();
        }

        private void clearControls()
        {
            txtbxName.Clear();
            txtbxHP.Clear();
            txtbxHeight.Clear();
            txtbxWeight.Clear();
        }

        //public void AddPokemon(string name, string type, int hp, double height, double weight)
        //{
        //    var pkman = new Pokemon
        //    {
        //        Name = name,
        //        Type = type,
        //        HP = hp,
        //        Height = height,
        //        Weight = weight
        //    };
        //    Pokedex.Add(pkman);
        //    var x = Pokedex.Count();
        //}

        public void ClearPokedex()
        {
            Pokedex = new List<Pokemon>();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create a new pokemon
            Pokemon p = new Pokemon();
            p.pokeName = txtbxName.Text;
            p.pokeType = cbxType.Text;
            p.pokeHP = int.Parse(txtbxHP.Text);
            p.pokeHeight = double.Parse(txtbxHeight.Text);
            p.pokeWeight = double.Parse(txtbxWeight.Text);

            //validation
            checkName(p.pokeName);
            checkType(p.pokeType);
            checkHP(p.pokeHP);
            checkHeight(p.pokeHeight);
            checkWeight(p.pokeWeight);


            //DialogResult button =
            MessageBox.Show(
                "Are you sure you want to save this data?",
                "Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            this.Tag = p;

            this.DialogResult = DialogResult.OK;
            this.Close();

            //AddPokemon(pokeName, pokeType, pokeHP, pokeHeight, pokeWeight);
            //clearControls();
        }



        private void checkName(string Name)
        {
            string pokeName;
            pokeName = Name;
            if ((pokeName == "") || (pokeName.Length < 3)) // you dont need a method for this
            {
                MessageBox.Show("INVALID NAME");
                txtbxName.Focus();
            }
        }

        private void checkType(string type)
        {

        }

        private void checkHP(int HP)
        {
            int pokeHP;
            try
            {
                pokeHP = HP;
                while ((pokeHP < 1) || (pokeHP > 714))
                {
                    MessageBox.Show(
                        "Please enter a valid number for the HP field.\n(The highest HP currently is Blissey with 714 HP and 252 HP evs).");
                    txtbxHP.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number HP field.");
                return;
            }
        }

        private void checkHeight(double height)
        {
            double pokeHeight;
            try
            {
                pokeHeight = height;
                while ((pokeHeight < 0.001) || (pokeHeight > 1000))
                {
                    MessageBox.Show(
                        "Please enter a valid number for the height field. (Between 0.01 kg and 9000 kg)");
                    txtbxHeight.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number for the weight fields.");
                throw;
            }
        }

        private void checkWeight(double weight)
        {
            double pokeWeight;
            try
            {
                pokeWeight = weight;
                while ((pokeWeight < 0.01) || (pokeWeight > 9000))
                {
                    MessageBox.Show("Please enter a valid number for the weight field. (Between 0.001 m and 1000 m)");
                    txtbxWeight.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number for the height fields.");
                throw;
            }
        }

         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtbxWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

        }

    }

    }


