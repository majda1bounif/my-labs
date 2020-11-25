using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         

    private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            ReceiptCarComponent car = new EconomyCar();
            CarAccessoriesDecorator acc = new BasicAccessories(car);
            CarAccessoriesDecorator acc1 = new AdvancedAccessories(car);
            CarAccessoriesDecorator acc2 = new SportsAccessories(car);


            if (checkBox1.Checked == true & checkBox4.Checked == false & checkBox5.Checked == false & checkBox6.Checked == false)
            {
                richTextBox1.AppendText("\n" + "Your Chosen Car is " + car.GetDescription() + "\n");
                if (checkBox7.Checked == true)
                {
                    richTextBox1.AppendText("The Totally Price is $" + car.GetCost());
                }
                if (checkBox8.Checked == true)
                {
                    richTextBox1.AppendText("The address is " + car.Address() + "\n");
                }
                if (checkBox9.Checked == true )
                {
                    richTextBox1.AppendText("*****************"+"Your Car Brand is : " + car.Compagny_Name() + "********\n");
                }

            }

            if (checkBox1.Checked == true & checkBox4.Checked == true)
            {
                richTextBox1.AppendText("\n" + "\n" + "\n" + "Your Chosen Car is " + acc.GetDescription() + "\n");
                if (checkBox7.Checked == true)
                {
                    richTextBox1.AppendText("The Totally Price is $" + acc.GetCost() + "\n");
                }
                if (checkBox8.Checked == true)
                {
                    richTextBox1.AppendText("The address is " + acc.Address() + "\n");
                }
                if (checkBox9.Checked == true)
                {
                    richTextBox1.AppendText("*****************" + "Your Car Brand is : " + acc.Compagny_Name() + "********\n");
                }



            }

            if (checkBox10.Checked == true)
            {
                richTextBox1.AppendText("//***///*** ///** BY THE END OF THIS MONTH VM OFFERS A DISCOUNT 15%  FOR ALL CARS TYPES//*****//*******" + "\n" + "---------VISIT US-------------" + "*******");
            }
            if (checkBox1.Checked = true & checkBox5.Checked == true)
            {
                richTextBox1.AppendText("\n" + "\n" + "\n" + "Your Chosen Car is " + acc1.GetDescription() + "\n");
                if (checkBox7.Checked == true)
                {
                    richTextBox1.AppendText("The Totally Price is $" + acc1.GetCost() + "\n");
                }
                if (checkBox8.Checked == true)
                {
                    richTextBox1.AppendText("The address is " + acc1.Address() + "\n");
                }
                if (checkBox9.Checked == true)
                {
                    richTextBox1.AppendText("*****************" + "Your Car Brand is : " + acc1.Compagny_Name() + "********\n");
                }

            }
            if (checkBox1.Checked = true & checkBox6.Checked == true)
            {
                richTextBox1.AppendText("\n" + "\n" + "\n" + "Your Chosen Car is " + acc2.GetDescription() + "\n");
                if (checkBox7.Checked == true)
                {
                    richTextBox1.AppendText("The Totally Price is $" + acc2.GetCost() + "\n");
                }
                if (checkBox8.Checked == true)
                {
                    richTextBox1.AppendText("The address is " + acc2.Address() + "\n");
                }
                if (checkBox9.Checked == true)
                {
                    richTextBox1.AppendText("*****************" + "Your Car Brand is : " + acc2.Compagny_Name() + "********\n");
                }

            }

            if (checkBox10.Checked == true)
            {
                richTextBox1.AppendText("//***///*** ///** BY THE END OF THIS MONTH VM OFFERS A DISCOUNT 15%  FOR ALL CARS TYPES//*****//*******" + "\n" + "---------VISIT US-------------" + "*******");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            ReceiptCarComponent car1 = new DeluxCar();
            CarAccessoriesDecorator acce = new BasicAccessories(car1);
            CarAccessoriesDecorator acce1 = new AdvancedAccessories(car1);
            CarAccessoriesDecorator acce2 = new SportsAccessories(car1);

            if (checkBox2.Checked == true & checkBox4.Checked == false & checkBox5.Checked == false & checkBox6.Checked == false)
            {
                richTextBox1.AppendText("\n" + "Your Chosen Car is " + car1.GetDescription() + "\n");
                if (checkBox7.Checked == true)
                {
                    richTextBox1.AppendText("The Totally Price is $" + car1.GetCost());
                }
                if (checkBox8.Checked == true)
                {
                    richTextBox1.AppendText("The address is " + car1.Address() + "\n");
                }
                if (checkBox9.Checked == true)
                {
                    richTextBox1.AppendText("*****************" + "Your Car Brand is : " + car1.Compagny_Name() + "********\n");
                }

            }
            if (checkBox2.Checked == true & checkBox4.Checked == true)
            {
                richTextBox1.AppendText("\n" + "\n" + "Your Chosen Car is " + acce.GetDescription() + "\n");
                if (checkBox7.Checked == true)
                {
                    richTextBox1.AppendText("The Totally Price is $" + acce.GetCost());
                }
                if (checkBox8.Checked == true)
                {
                    richTextBox1.AppendText("The address is " + acce.Address() + "\n");
                }
                if (checkBox9.Checked == true)
                {
                    richTextBox1.AppendText("*****************" + "Your Car Brand is : " + acce.Compagny_Name() + "********\n");
                }

            }
        






            if (checkBox2.Checked = true & checkBox5.Checked == true)
                {
                    richTextBox1.AppendText("\n" + "\n" + "Your Chosen Car is " + acce1.GetDescription() + "\n");
                    if (checkBox7.Checked == true)
                    {
                        richTextBox1.AppendText("The Totally Price is $" + acce1.GetCost());
                    }
                    if (checkBox8.Checked == true)
                    {
                        richTextBox1.AppendText("The address is " + acce1.Address() + "\n");
                    }
                    if (checkBox9.Checked == true)
                    {
                        richTextBox1.AppendText("*****************" + "Your Car Brand is : " + acce1.Compagny_Name() + "********\n");
                    }


                }
                if (checkBox2.Checked = true & checkBox6.Checked == true)
                {
                    richTextBox1.AppendText("\n" + "\n" + "Your Chosen Car is " + acce2.GetDescription());
                    if (checkBox7.Checked == true)
                    {
                        richTextBox1.AppendText("The Totally Price is $" + acce2.GetCost() + "\n");
                    }
                    if (checkBox8.Checked == true)
                    {
                        richTextBox1.AppendText("The address is " + acce2.Address() + "\n");
                    }
                    if (checkBox8.Checked == true)
                    {
                        richTextBox1.AppendText("The address is " + acce2.Address() + "\n");
                    }
                    if (checkBox9.Checked == true)
                    {
                        richTextBox1.AppendText("*****************" + "Your Car Brand is : " + acce2.Compagny_Name() + "********\n");
                    }


                }

            if (checkBox10.Checked == true)
            {
                richTextBox1.AppendText("//***///*** ///** BY THE END OF THIS MONTH VM OFFERS A DISCOUNT 15%  FOR ALL CARS TYPES//*****//*******" + "\n" + "---------VISIT US-------------" + "*******");
            }




        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            ReceiptCarComponent car2 = new LuxuryCar();
            CarAccessoriesDecorator acces = new BasicAccessories(car2);
            CarAccessoriesDecorator acces1 = new AdvancedAccessories(car2);
            CarAccessoriesDecorator acces2 = new SportsAccessories(car2);
            if (checkBox3.Checked == true & checkBox4.Checked == false & checkBox5.Checked == false & checkBox6.Checked == false)
            {
                richTextBox1.AppendText("\n" + "Your Chosen Car is " + car2.GetDescription() + "\n");
                if (checkBox7.Checked == true)
                {
                    richTextBox1.AppendText("The Totally Price is $" + car2.GetCost());
                }
                if (checkBox8.Checked == true)
                {
                    richTextBox1.AppendText("The address is " + car2.Address() + "\n");
                }
                if (checkBox9.Checked == true)
                {
                    richTextBox1.AppendText("*****************" + "Your Car Brand is : " + car2.Compagny_Name() + "********\n");
                }


            }

            if (checkBox3.Checked == true & checkBox4.Checked == true)
            {
                richTextBox1.AppendText("\n" + "\n" + "\n" + "Your Chosen Car is " + acces.GetDescription() + "\n");
                if (checkBox7.Checked == true)
                {
                    richTextBox1.AppendText("The Totally Price is $" + acces.GetCost());
                }
                if (checkBox8.Checked == true)
                {
                    richTextBox1.AppendText("The address is " + acces.Address() + "\n");
                }
                if (checkBox9.Checked == true)
                {
                    richTextBox1.AppendText("*****************" + "Your Car Brand is : " + acces.Compagny_Name() + "********\n");
                }


            }
            if (checkBox3.Checked = true & checkBox5.Checked == true)
            {
                richTextBox1.AppendText("\n" + "\n" + "\n" + "Your Chosen Car is " + acces1.GetDescription() + "\n");
                if (checkBox7.Checked == true)
                {
                    richTextBox1.AppendText("The Totally Price is $" + acces1.GetCost());
                }
                if (checkBox8.Checked == true)
                {
                    richTextBox1.AppendText("The address is " + acces1.Address() + "\n");
                }
                if (checkBox9.Checked == true)
                {
                    richTextBox1.AppendText("*****************" + "Your Car Brand is : " + acces1.Compagny_Name() + "********\n");
                }

            }
            if (checkBox3.Checked = true & checkBox6.Checked == true)
            {
                richTextBox1.AppendText("\n" + "\n" + "\n" + "Your Chosen Car is " + acces2.GetDescription() + "\n");
                if (checkBox7.Checked == true)
                {
                    richTextBox1.AppendText("The Totally Price is $" + acces2.GetCost());
                }
                if (checkBox8.Checked == true)
                {
                    richTextBox1.AppendText("The address is " + acces2.Address() + "\n");
                }
                if (checkBox9.Checked == true)
                {
                    richTextBox1.AppendText("*****************" + "Your Car Brand is : " + acces2.Compagny_Name() + "********\n");
                }


            }

            if (checkBox10.Checked == true)
            {
                richTextBox1.AppendText("//***///*** ///** BY THE END OF THIS MONTH VM OFFERS A DISCOUNT 15%  FOR ALL CARS TYPES//*****//*******" + "\n" + "---------VISIT US-------------" + "*******");
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else if (checkBox1.Checked == false)
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
   
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;

            }
            else if (checkBox2.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                button1.Enabled = true;
                button3.Enabled = true;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;

            }
            else if (checkBox3.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;

            }
        }

        /*private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                //checkBox5.Enabled = false;
                //checkBox6.Enabled = false;
            }
            else if (checkBox4.Checked == false)
            {
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox4.Enabled = false;
                checkBox6.Enabled = false;
            }
            else if (checkBox1.Checked == false)
            {
                checkBox4.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
            }
            else if (checkBox6.Checked == false)
            {
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
            }
        }*/

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void circleButton1_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void circleButton2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false; checkBox6.Checked = false;

        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

