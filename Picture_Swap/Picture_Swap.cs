using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Picture_Swap
{
    public partial class Picture_Swap : Form
    {
        public Picture_Swap()
        {
            InitializeComponent();
        }

        private void Picture_Swap_Load(object sender, EventArgs e)
        {
            
          
        }
        int get = 0;
        public void confirm()
        {
            if (MessageBox.Show("Do you want to Play Again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               /// MessageBox.Show("User :" + num + "Get :=" + get + "\nCom:" + n + "     Got :" + got + "\nCommon:" + common + "\nb" + b);
                Application.Restart();                
                
            }
            else
            {
              ///  MessageBox.Show("User :" + num + "Get :=" + get + "\nCom:" + n + "     Got :" + got + "\nCommon:" + common + "\nb" + b);
                Application.Exit();
            }
        }
        public bool check(string get,string i, string ii, string iii)
        {
            bool flag = false;
           if(get.Contains(i))
           {
               if (get.Contains(ii))
               {
                   if (get.Contains(iii))
                   {
                       flag = true;

                   }
               }
           }
           return flag;
        }
        int got = 0; string num; int n; string common = "n"; bool b;
        private void pictureBoxClick(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image=Image.FromFile(Application.StartupPath+@"\user.png");
            ((PictureBox)sender).Enabled = false;
             num = ((PictureBox)sender).Tag.ToString();


             if (get > 0)
             {
                 common = common + num;
                 get = get * 10 + int.Parse(num);
             }
             else
             {
                 common = common + num;
                 get = int.Parse(num);
             }
       //    
            int mm = 1;
            Random r = new Random();
            if (!intelligency_check())
            {
                do
                {
                    mm++;
                    n = r.Next(1, 9);

                    if (mm > 20)
                    {
                        n = 0;
                        break;
                    }
                    b = common.Contains(n.ToString());
                } while (b);
            }
            if (got > 0)
            {
                common = common + n;
                got = got * 10 + n;
            }
            else
            {
                common += n;
                got = n;
            }

            chk = true;
            panel1.Enabled = false;
            timer1.Enabled = true;
          //  MessageBox.Show("User :" + num + "Get :=" + get + "\nCom:" + n + "     Got :" + got+"\nCommon:"+common+"\nb"+b);
        }
        bool chk = false;
        public void comturn()
        {

            foreach (PictureBox p in panel1.Controls)
            {
                try
                {
                    if (p.Name == "pictureBox" + n)
                    {

                        p.Image = Image.FromFile(Application.StartupPath + @"\com.png");
                        p.Enabled = false;
                    }
                }
                catch { }
            }



            if (check(get.ToString(), "1", "2", "3"))
            { MessageBox.Show("Congratulation !! \n You Won the game", "Final Score"); confirm(); }
            else
            {
                if (check(get.ToString(), "4", "5", "6"))
                { MessageBox.Show("Congratulation !! \n You Won the game", "Final Score"); confirm(); }
                else
                {
                    if (check(get.ToString(), "7", "8", "9"))
                    { MessageBox.Show("Congratulation !! \n You Won the game", "Final Score"); confirm(); }
                    else
                    {
                        if (check(get.ToString(), "1", "4", "7"))
                        { MessageBox.Show("Congratulation !! \n You Won the game", "Final Score"); confirm(); }
                        else
                        {
                            if (check(get.ToString(), "2", "5", "8"))
                            { MessageBox.Show("Congratulation !! \n You Won the game", "Final Score"); confirm(); }
                            else
                            {
                                if (check(get.ToString(), "3", "6", "9"))
                                { MessageBox.Show("Congratulation !! \n You Won the game", "Final Score"); confirm(); }
                                else
                                {
                                    if (check(get.ToString(), "1", "5", "9"))
                                    { MessageBox.Show("Congratulation !! \n You Won the game", "Final Score"); confirm(); }
                                    else
                                    {
                                        if (check(get.ToString(), "3", "5", "7"))
                                        { MessageBox.Show("Congratulation !! \n You Won the game", "Final Score"); confirm(); }
                                        else
                                        {

                                            if (check(got.ToString(), "1", "2", "3"))
                                            { MessageBox.Show("Computer Won the game", "Final Score"); confirm(); }
                                            else
                                            {
                                                if (check(got.ToString(), "4", "5", "6"))
                                                { MessageBox.Show("Computer Won the game", "Final Score"); confirm(); }
                                                else
                                                {
                                                    if (check(got.ToString(), "7", "8", "9"))
                                                    { MessageBox.Show("Computer Won the game", "Final Score"); confirm(); }
                                                    else
                                                    {
                                                        if (check(got.ToString(), "1", "4", "7"))
                                                        { MessageBox.Show("Computer Won the game", "Final Score"); confirm(); }
                                                        else
                                                        {
                                                            if (check(got.ToString(), "2", "5", "8"))
                                                            { MessageBox.Show("Computer Won the game", "Final Score"); confirm(); }
                                                            else
                                                            {
                                                                if (check(got.ToString(), "3", "6", "9"))
                                                                { MessageBox.Show("Computer Won the game", "Final Score"); confirm(); }
                                                                else
                                                                {
                                                                    if (check(got.ToString(), "1", "5", "9"))
                                                                    { MessageBox.Show("Computer Won the game", "Final Score"); confirm(); }
                                                                    else
                                                                    {
                                                                        if (check(got.ToString(), "3", "5", "7"))
                                                                        { MessageBox.Show("Computer Won the game", "Final Score"); confirm(); }
                                                                        else
                                                                        {
                                                                            if (get.ToString().Length >= 5)
                                                                            {
                                                                                MessageBox.Show("Game Draw !!!!!", "Final Score"); confirm();
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }


                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

           
        }
        int inc = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (inc > 10)
            {
                if (chk == true)
                {
                    chk = false;
                    timer1.Enabled = false;
                    inc = 0;
                    comturn();
                    panel1.Enabled = true;
                }
            }
            inc++;
        }

        private void Picture_Swap_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        public bool intelligency_check()
        {
            bool flag = false;

            if (intelligency("1", "2", "3", got, get))
                flag = true;
            else
            {
                if (intelligency("4", "5", "6", got, get))
                    flag = true;
                else
                {
                    if (intelligency("7", "8", "9", got, get))
                        flag = true;
                    else
                    {
                        if (intelligency("1", "4", "7", got, get))
                            flag = true;
                        else
                        {
                            if (intelligency("2", "5", "8", got, get))
                                flag = true;
                            else
                            {
                                if (intelligency("3", "6", "9", got, get))
                                    flag = true;
                                else
                                {
                                    if (intelligency("1", "5", "9", got, get))
                                        flag = true;
                                    else
                                    {
                                        if (intelligency("3", "5", "7",got,get))
                                            flag = true;
                                        else
                                        {
                                           // flag = false;
                                            if (intelligency("1", "2", "3", get, got))
                                                flag = true;
                                            else
                                            {
                                                if (intelligency("4", "5", "6", get, got))
                                                    flag = true;
                                                else
                                                {
                                                    if (intelligency("7", "8", "9", get, got))
                                                        flag = true;
                                                    else
                                                    {
                                                        if (intelligency("1", "4", "7", get, got))
                                                            flag = true;
                                                        else
                                                        {
                                                            if (intelligency("2", "5", "8", get, got))
                                                                flag = true;
                                                            else
                                                            {
                                                                if (intelligency("3", "6", "9", get, got))
                                                                    flag = true;
                                                                else
                                                                {
                                                                    if (intelligency("1", "5", "9", get, got))
                                                                        flag = true;
                                                                    else
                                                                    {
                                                                        if (intelligency("3", "5", "7", get, got))
                                                                            flag = true;
                                                                        else
                                                                        {
                                                                            flag = false;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return flag;
        }

        public bool intelligency(string i, string ii, string iii,int get,int got)
        {
            bool flag = false;


            if (get.ToString().Contains(i) && get.ToString().Contains(ii))
            {
                if (get.ToString().Contains(iii))
                    flag = false;
                else
                {
                    if (got.ToString().Contains(iii))
                        flag = false;
                    else
                    {
                        n = int.Parse(iii);
                        flag = true;
                    }
                }
            }
            else
            {
                if (get.ToString().Contains(ii) && get.ToString().Contains(iii))
                {
                    if (get.ToString().Contains(i))
                        flag = false;
                    else
                    {
                        if (got.ToString().Contains(i))
                            flag = false;
                        else
                        {
                            n = int.Parse(i);
                            flag = true;
                        }
                    }
                }
                else
                {
                    if (get.ToString().Contains(i) && get.ToString().Contains(iii))
                    {
                        if (get.ToString().Contains(ii))
                            flag = false;
                        else
                        {
                            if (got.ToString().Contains(ii))
                                flag = false;
                            else
                            {
                                n = int.Parse(ii);
                                flag = true;
                            }
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }
        

    }
}
