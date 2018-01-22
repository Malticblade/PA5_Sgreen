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
        private void cbxWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void cbxHeight_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            p.Name = txtbxName.Text;
            p.Type = cbxType.Text;
            p.HP = int.Parse(txtbxHP.Text);
            p.Height = double.Parse(txtbxHeight.Text);
            p.Weight = double.Parse(txtbxWeight.Text);

            //validation
            checkName(p.Name);
            checkType(p.Type);
            checkHP(p.HP);
            p.Height = checkHeight(p.Height);
            p.Weight = checkWeight(p.Weight);


            DialogResult button =
                MessageBox.Show(
                    "Are you sure you want to save this data?",
                    "Payment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
            //switch (button)
            //{
            //    case DialogResult.OK:
            //        {
            //            this.DialogResult = DialogResult.OK;
            //            this.Tag = p;
            //            this.Close();
            //            break;
            //        }
            //    case DialogResult.Cancel:
            //        {
            //            this.DialogResult = DialogResult.Cancel;
            //            this.Close();
            //            break;
            //        }
            //    default:
            //        {
            //            this.DialogResult = DialogResult.Cancel;
            //            this.Close();
            //            break;
            //        }
            //}

            this.DialogResult = DialogResult.OK;
            this.Tag = p;
            this.Close();
        }



        private void checkName(string pokeName)
        {
            try
            {
                if ((pokeName == "") || (pokeName.Length < 3)) // you dont need a method for this
                {
                    MessageBox.Show("INVALID NAME");
                    txtbxName.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("INVALID NAME");
                this.Dispose(false);
            }
        }

        private void checkType(string type)
        {
            if (type == "") // you dont need a method for this
            {
                MessageBox.Show("INVALID TYPE");
                this.Dispose(false);
            }
        }

        private void checkHP(int HP)
        {
            try
            {
                while ((HP < 1) || (HP > 714))
                {
                    MessageBox.Show(
                        "Please enter a valid number for the HP field.\n(The highest HP currently is Blissey with 714 HP and 252 HP evs).");
                    this.Dispose(false);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number HP field.");
                this.Dispose(false);
            }
        }

        private double checkHeight(double Height)
        {
            try
            {
                if ((Height < 0.001) || (Height > 1000))
                {
                    MessageBox.Show(
                        "Please enter a valid number for the height field. (Between 0.01 kg and 9000 kg)");
                    this.Dispose(false);
                    return 0;
                }
                else
                {
                    if (cbxHeight.SelectedItem.ToString() == "in")
                    {
                        Height = Math.Round(Height, 2);
                        return Height;

                    }
                    else if(cbxHeight.SelectedItem.ToString() == "m")
                    {
                        Height *= 39.3701;
                        Height = Math.Round(Height, 2);
                        return Height;
                    }
                    else
                    {
                        MessageBox.Show("Please select a value from the height combo box");
                        this.Dispose(false);
                        return 0;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number for the height fields.");
                throw;
            }
        }

        private double checkWeight(double Weight)
        {
            try
            {
                if ((Weight < 0.01) || (Weight > 9000))
                {
                    MessageBox.Show("Please enter a valid number for the weight field. (Between 0.001 m and 1000 m)");
                    cbxWeight.Focus();
                    return 0;
                    
                }
                else
                {
                    if (cbxWeight.SelectedItem.ToString() == "kg")
                    {
                        Weight *= 35.274;
                        Weight = Math.Round(Weight, 2);
                        return Weight;
                        

                    }
                    else if (cbxWeight.SelectedItem.ToString() == "oz")
                    {
                        Weight = Math.Round(Weight, 2);
                        return Weight;
                        
                    }
                    else
                    {
                        MessageBox.Show("Please select a value from the weight combo box");
                        cbxWeight.Focus();
                        return 0;                        
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number for the height fields.");
                throw;
            }

        }

        private void frmPokemon_Load(object sender, EventArgs e)
        {
            this.cbxHeight.SelectedIndex = 0;
            this.cbxWeight.SelectedIndex = 0;
        }
    }
}

