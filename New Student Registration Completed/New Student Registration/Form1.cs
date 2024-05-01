using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Student_Registration
{
    public partial class NewStudentForm : Form
    {
        public NewStudentForm()
        {
            InitializeComponent();
        }
        String radio, name, faname, activities, splayer, flancer,province,district,Collect;

              //City of punjab ...............
        private void districtsofPunjab_TextChanged(object sender, EventArgs e)
        {
            if (districtsofPunjab.SelectedItem.ToString() == "Lahore")
            {
                combcityoflahore.Enabled = true;
                combcityoflahore.Visible = true;
                district = districtsofPunjab.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
            }
            if (districtsofPunjab.SelectedItem.ToString() == "Kasur")
            {
                combcityoflahore.Enabled = true;
                combcityoflahore.Visible = true;
                district = districtsofPunjab.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
            }
            if (districtsofPunjab.SelectedItem.ToString() == "Nankana Sahib")
            {
                combcityoflahore.Enabled = true;
                combcityoflahore.Visible = true;
                district = districtsofPunjab.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
            }

            if (districtsofPunjab.SelectedItem.ToString() == "Sheikhupura")
            {
                combcityoflahore.Enabled = true;
                combcityoflahore.Visible = true;
                district = districtsofPunjab.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
            }
        }
     
        //  city of sindh
        private void districtsofsindh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Sukkur    Ghotki         Khairpur           Larkana
            if (districtsofsindh.SelectedItem.ToString() == "Sukkur")
            {
                combcitysidh.Enabled = true;
                combcitysidh.Visible = true;
                district = districtsofsindh.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcityoflahore.Visible = false;
            }
            if (districtsofsindh.SelectedItem.ToString() == "Ghotki	")
            {
                combcitysidh.Enabled = true;
                combcitysidh.Visible = true;
                district = districtsofsindh.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcityoflahore.Visible = false;
            }
            if (districtsofsindh.SelectedItem.ToString() == "Khairpur	")
            {
                combcitysidh.Enabled = true;
                combcitysidh.Visible = true;
                district = districtsofsindh.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcityoflahore.Visible = false;
            }

            if (districtsofsindh.SelectedItem.ToString() == "Larkana")
            {
                combcitysidh.Enabled = true;
                combcitysidh.Visible = true;
                district = districtsofsindh.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcityoflahore.Visible = false;
            }


        }
        //districtsofbaluchistan
        private void districtsofbaluchistan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   Chagai       Sibi       Loralai       Zhob 

            if (districtsofbaluchistan.SelectedItem.ToString() == "Chagai District.")
            {
                combcitybalo.Enabled = true;
                combcitybalo.Visible = true;
                district = districtsofbaluchistan.SelectedItem.ToString();
                combcityoflahore.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
            }
            if (districtsofbaluchistan.SelectedItem.ToString() == " Loralai District.")
            {
                combcitybalo.Enabled = true;
                combcitybalo.Visible = true;
                district = districtsofbaluchistan.SelectedItem.ToString();
                combcityoflahore.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
            }
            if (districtsofbaluchistan.SelectedItem.ToString() == " Sibi District. ")
            {
                combcitybalo.Enabled = true;
                combcitybalo.Visible = true;
                district = districtsofbaluchistan.SelectedItem.ToString();
                combcityoflahore.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
            }

            if (districtsofbaluchistan.SelectedItem.ToString() == "Zhob District.")
            {
                combcitybalo.Enabled = true;
                combcitybalo.Visible = true;
                district = districtsofbaluchistan.SelectedItem.ToString();
                combcityoflahore.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
            }


        }
        // city of kpk
        private void districtsofkpk_SelectedIndexChanged(object sender, EventArgs e)
        {   // Chitral District.  Swat District. Malakand District. Shangla District.

            if (districtsofkpk.SelectedItem.ToString() == "Chitral District.")
            {
                combcitykpk.Enabled = true;
                combcitykpk.Visible = true;
                district = districtsofkpk.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }
            if (districtsofkpk.SelectedItem.ToString() == "Malakand District.")
            {
                combcitykpk.Enabled = true;
                combcitykpk.Visible = true;
                district = districtsofkpk.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }
            if (districtsofkpk.SelectedItem.ToString() == "Shangla District.")
            {
                combcitykpk.Enabled = true;
                combcitykpk.Visible = true;
                district = districtsofkpk.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }

            if (districtsofkpk.SelectedItem.ToString() == "Swat District.")
            {
                combcitykpk.Enabled = true;
                combcitykpk.Visible = true;
                district = districtsofkpk.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combCityislama.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }





        }
        // city of Gilgit Baltistan
        private void districtsofgilgit_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Baltistan's Skardu,   Hunza           Roundu,           Kharmang,
            if (districtsofgilgit.SelectedItem.ToString() == " Baltistan's Skardu,")
            {
                combcitygilgit.Enabled = true;
                combcitygilgit.Visible = true;
                district = districtsofgilgit.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitykpk.Visible = false;
                combCityislama.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }
            if (districtsofgilgit.SelectedItem.ToString() == " Roundu, ")
            {
                combcitygilgit.Enabled = true;
                combcitygilgit.Visible = true;
                district = districtsofgilgit.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitykpk.Visible = false;
                combCityislama.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }
            if (districtsofgilgit.SelectedItem.ToString() == " Kharmang,")
            {
                combcitygilgit.Enabled = true;
                combcitygilgit.Visible = true;
                district = districtsofgilgit.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitykpk.Visible = false;
                combCityislama.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }

            if (districtsofgilgit.SelectedItem.ToString() == " Hunza")
            {
                combcitygilgit.Enabled = true;
                combcitygilgit.Visible = true;
                district = districtsofgilgit.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitykpk.Visible = false;
                combCityislama.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }
        }

        private void districtsofislamabad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    Pind Begwal ·       Jandala          Bainala,            Maira Biguwal

            if (districtsofislamabad.SelectedItem.ToString() == "Pind Begwal ·")
            {
                combCityislama.Enabled = true;
                combCityislama.Visible = true;
                district = districtsofislamabad.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }
            if (districtsofislamabad.SelectedItem.ToString() == "Jandala")
            {
                combCityislama.Enabled = true;
                combCityislama.Visible = true;
                district = districtsofislamabad.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }
            if (districtsofislamabad.SelectedItem.ToString() == "Bainala,")
            {
                combCityislama.Enabled = true;
                combCityislama.Visible = true;
                district = districtsofislamabad.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }

            if (districtsofislamabad.SelectedItem.ToString() == "Maira Biguwal")
            {
                combCityislama.Enabled = true;
                combCityislama.Visible = true;
                district = districtsofislamabad.SelectedItem.ToString();
                combcitybalo.Visible = false;
                combcitygilgit.Visible = false;
                combcitykpk.Visible = false;
                combcitysidh.Visible = false;
                combcityoflahore.Visible = false;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            textDetails.Text="" ;
            sttudentName.Text = "";
            fName.Text = "";
            radioButtonmale.Checked = false;
            radioButtonfemale.Checked = false;
            numericinterobtained.Value=450;
            numericintermaximum.Value=450;
            numericmatricobtained.Value=450;
            numericmatricmaximum.Value=450;
            net.Text = "Net Percentage";
            //reseting province 
            comoboxProvinces.ResetText();
            //reseting disricts
            districtsofbaluchistan.ResetText();
            districtsofgilgit.ResetText();
            districtsofislamabad.ResetText();
            districtsofkpk.ResetText();
            districtsofPunjab.ResetText();
            districtsofsindh.ResetText();
            // reseting city
            combCityislama.ResetText();
            combcitybalo.ResetText();
            combcitygilgit.ResetText();
            combcitykpk.ResetText();
            combcityoflahore.ResetText();
            combcitysidh.ResetText();
            //reseting activities
            chbartist.Checked = false;
            chbfreeLancer.Checked = false;
            chbhafizequran.Checked = false;
            chbsportsPlayer.Checked = false;














        }

       
        private void chbfreeLancer_CheckedChanged(object sender, EventArgs e)
        {
            if (chbfreeLancer.Checked == true)
            {
                groupBoxfreelancer.Enabled = true;
                groupBoxfreelancer.BackColor = Color.Yellow;
            }
            else
            {
                groupBoxfreelancer.Enabled = false;
                groupBoxfreelancer.BackColor = Color.SlateGray;
            }
        }

        private void sppalyer(object sender, EventArgs e)
        {
            if (chbsportsPlayer.Checked == true)
            {
                groupBox3.Enabled = true;
                groupBox3.BackColor = Color.Yellow;
            }
            else
            {
                groupBox3.Enabled = false;
                groupBox3.BackColor = Color.SlateGray;
            }
        }
        // Provinces data
        private void comoboxProvinces_TextChanged(object sender, EventArgs e)
        {
            
            if (comoboxProvinces.SelectedItem.ToString() == "Punjab")
            {
                districtsofPunjab.Enabled = true;
                districtsofPunjab.Visible = true;
                province = comoboxProvinces.SelectedItem.ToString();
                districtsofsindh.Visible = false;
                districtsofkpk.Visible = false;
                districtsofislamabad.Visible = false;
                districtsofbaluchistan.Visible = false;
                districtsofgilgit.Visible = false;
            }
           else if (comoboxProvinces.SelectedItem.ToString() == "Sindh")
            {
                districtsofsindh.Enabled = true;
                districtsofsindh.Visible = true;
                province = comoboxProvinces.SelectedItem.ToString();
                districtsofPunjab.Visible = false;
                districtsofkpk.Visible = false;
                districtsofislamabad.Visible = false;
                districtsofbaluchistan.Visible = false;
                districtsofgilgit.Visible = false;
            }
            else if (comoboxProvinces.SelectedItem.ToString() == "KPK")
            {
                districtsofkpk.Enabled = true;
                districtsofkpk.Visible = true;
                province = comoboxProvinces.SelectedItem.ToString();
                districtsofsindh.Visible = false;
                districtsofPunjab.Visible = false;
                districtsofislamabad.Visible = false;
                districtsofbaluchistan.Visible = false;
                districtsofgilgit.Visible = false;
            }
            else if (comoboxProvinces.SelectedItem.ToString() == "Islamabad")
            {
               districtsofislamabad.Enabled = true;
                districtsofislamabad.Visible = true;
                province = comoboxProvinces.SelectedItem.ToString();
                districtsofsindh.Visible = false;
                districtsofkpk.Visible = false;
                districtsofPunjab.Visible = false;
                districtsofbaluchistan.Visible = false;
                districtsofgilgit.Visible = false;
            }
            else if (comoboxProvinces.SelectedItem.ToString() == "Baluchistan")
            {
                districtsofbaluchistan.Enabled = true;
                districtsofbaluchistan.Visible = true;
                province = comoboxProvinces.SelectedItem.ToString();
                districtsofsindh.Visible = false;
                districtsofkpk.Visible = false;
                districtsofislamabad.Visible = false;
                districtsofPunjab.Visible = false;
                districtsofgilgit.Visible = false;

            }
            else if (comoboxProvinces.SelectedItem.ToString() == "Gilgit Baltistan")
            {
                districtsofgilgit.Enabled = true;
                districtsofgilgit.Visible = true;
                province = comoboxProvinces.SelectedItem.ToString();
                districtsofsindh.Visible = false;
                districtsofkpk.Visible = false;
                districtsofislamabad.Visible = false;
                districtsofbaluchistan.Visible = false;
                districtsofPunjab.Visible = false;
            }
            else
            {
                MessageBox.Show("Province not selected");

                districtsofPunjab.Visible = false;
                districtsofsindh.Visible = false;
                province = "Province not selected";
                districtsofkpk.Visible = false;
                districtsofislamabad.Visible = false;
                districtsofbaluchistan.Visible = false;
                districtsofgilgit.Visible = false;


            }
           

        }

        double matricobtauned, matricmaximym, interobtained, intermaximum, matricaverage, interaverage,netpercentage;

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void NewStudentForm_Load(object sender, EventArgs e)
        {
            if (chbfreeLancer.Checked == true)
            {
                groupBoxfreelancer.Enabled = true;
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            name = sttudentName.Text;
            faname = fName.Text;
            //Gender radaiobuttons
            if (radioButtonmale.Checked == true)
            {
                radio= radioButtonmale.Text;
            }
            else if(radioButtonfemale.Checked==true)
            {
               radio=radioButtonfemale.Text;
            }
           
            else
            {
                MessageBox.Show("Gender not selected");
            }
            //sports player
            if (chbsportsPlayer.Checked == true)
            {
                groupBox3.Enabled = true;
            }
            //freelancer
            if (chbfreeLancer.Checked == true)
            {
                groupBoxfreelancer.Enabled = true;
            }
            //Sports player radiobuttons
            if (radioButtoncrik.Checked == true)
            {
                splayer = radioButtoncrik.Text;
            }
           else if (radioButtonfball.Checked == true)
            {
                splayer =radioButtonfball.Text;
            }
          else  if (radioButtonbadmn.Checked == true)
            {
                splayer = radioButtonbadmn.Text;
            }
           else if (radioButtontblt.Checked == true)
            {
                splayer = radioButtontblt.Text;
            }
            else
            {
                splayer="Sports Player not selected";

            }


            //Freelancerbox
            // radiobuttons


            if (radioButtongd.Checked == true)
            {
                flancer = radioButtongd.Text;
            }
           else if (radioButtonve.Checked == true)
            {
                flancer = radioButtonve.Text;
            }
          else  if (radioButtonvoa.Checked == true)
            {
                flancer = radioButtonvoa.Text;
            }
           else if (radioButtonsd.Checked == true)
            {
                flancer = radioButtonsd.Text;
            }
            else
            {
                flancer="Freelancer not selected";

            }


            //Marks
            matricobtauned =Convert.ToDouble( numericmatricobtained.Value);
            matricmaximym = Convert.ToDouble(numericmatricmaximum.Value);
            matricaverage = (matricobtauned / matricmaximym)*50;
            interobtained= Convert.ToDouble(numericinterobtained.Value);
            intermaximum = Convert.ToDouble(numericintermaximum.Value);
            interaverage = (interobtained / intermaximum)*50;
            netpercentage = matricaverage + interaverage;
           net.Text= netpercentage.ToString();


            //Curicular Activties

            if (chbhafizequran.Checked == true)
            {
              activities+= chbhafizequran.Text;
            }
            if (chbsportsPlayer.Checked == true)
            {
                activities += chbsportsPlayer.Text;

            }
            if (chbfreeLancer.Checked == true)
            {
                activities+= chbfreeLancer.Text;
            }

            if (chbartist.Checked == true)
            {
                activities+= chbartist.Text;
            }

          

            // Displating Results

Collect = $"Name={name}" + Environment.NewLine + $"Father Name={faname}" + Environment.NewLine +$"Gender ={radio}"+Environment.NewLine+ 
$"Province={province}"+Environment.NewLine+$"District = {district}"+Environment.NewLine+$"Activities = {activities}"+Environment.NewLine+
$"Sports Player = {splayer}"+Environment.NewLine+$"FreeLancer = {flancer}"+Environment.NewLine;





            textDetails.Text = "Quotation"+Environment.NewLine+Collect;

        }



    }

       
    
       
}
