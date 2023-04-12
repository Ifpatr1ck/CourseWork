using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        void MainMenu()
        {
            Balance.Visible = false;
            money = 1000;
            MoneyText.Text = Convert.ToString(money);
            OpenCellButtonGambilingMODE.Visible = false;
            BuyTicketButtonGambilingMode.Visible = false;
            MoneyText.Visible = false;
            ExitButton.Visible = true;
            OpenCellButton.Visible = false;
            AuthorButton.Visible = true;
            PlayGameButton.Visible = true;
            FAQButton.Visible = true;
            PickUpButton.Visible = false;
            AttensionText.Visible = false;
            AttensionText2.Visible = false;
            AttensionText3.Visible = false;
            AttensionText4.Visible = false;
            ButtonOfCancel.Visible = false;
            BuyTicketButton.Visible = false;
            checkBox1.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;

        }
        void result(bool total)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if ((int)dataGridView1[j, i].Value == 1)
                    {
                        if (total)
                        {
                            dataGridView2[j, i].Style.BackColor = Color.Green;
                            dataGridView2[j, i].Value = "$$$";
                        }
                        else
                        {
                            dataGridView2[j, i].Style.BackColor = Color.Red;
                            dataGridView2[j, i].Value = "$$$";
                        }
                    }
                    else dataGridView2[j, i].Style.BackColor = Color.Red;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        bool FIRSTcontrolgame = true, GambilingMODE = false, NonGambilingMODE = false, ActiveCredit = false;
        public int x, y, money = 1100, GambilingMODECount = 0,count = 0, count1 = 0, Debt, y1 = -1, x1 = -1;
        private void FAQButton_Click(object sender, EventArgs e)
        {
            ExitButton.Visible = false;
            Balance.Visible = false;
            AuthorButton.Visible = false;
            ButtonOfCancel.Visible = true;
            PlayGameButton.Visible = false;
            CommonGameButton.Visible = false;
            MultipleGameButton.Visible = false;
            FAQButton.Visible = false;
            FAQCommonGame.Visible = true;
            FAQControlGame.Visible = true;
            FAQMultipleGame.Visible = true;
            Text1.Visible = true;
            Text2.Visible = true;
            Text5.Visible = true;
            Text3.Visible = true;
            Text4.Visible = true;
            Text5.Visible = true;
            Text6.Visible = true;
            Text7.Visible = true;
            Text8.Visible = true;
        }
        private void ButtonOfCancel_Click(object sender, EventArgs e)
        {
            count1 = 0;
            count = 0;
            BuyTicketButtonGambilingMode.Visible = false;
            AttensionText.Visible = false;
            AttensionText2.Visible = false;
            AttensionText3.Visible = false;
            AttensionText4.Visible = false;
            checkBox1.Visible = false;
            NonGambilingModeButton.Visible = false;
            GambilingModeButton.Visible = false;
            OpenCellButtonGambilingMODE.Visible = false;
            MoneyText.Visible = false;
            CommonGameButton.Visible = false;
            MultipleGameButton.Visible = false;
            ExitButton.Visible = true;
            AuthorButton.Visible = true;
            OpenCellButton.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            FAQCommonGame.BackColor = Color.White;
            FAQControlGame.BackColor = Color.White;
            FAQMultipleGame.BackColor = Color.White;
            Text1.Text = "Игра подразумевает собой формат лотерейных билетов";
            Text2.Text = "В билете есть четыре поля, два из которых выигрышных";
            Text3.Text = "Выиграшное поле отмечается зеленым цветом и знаком \"@\"";
            Text4.Text = "Проигрошное поле отмечается пустым красным полем";
            Text5.Text = "Игра продолжается до тех пор, пока не выбрано пустое поле";
            Text6.Text = "Или пока игрок не заберет свой выигрыш";
            Text7.Text = "Игра подразумевает три режима игры: \"обычный режим\",";
            Text8.Text = "\"контрольный режим\" и \"залповый режим\", подробнее:";
            ButtonOfCancel.Visible = false;
            Text1.Visible = false;
            Text2.Visible = false;
            Text5.Visible = false;
            Text3.Visible = false;
            Text4.Visible = false;
            Text5.Visible = false;
            Text6.Visible = false;
            Text7.Visible = false;
            Text8.Visible = false;
            PlayGameButton.Visible = true;
            FAQButton.Visible = true;
            FAQCommonGame.Visible = false;
            FAQControlGame.Visible = false;
            FAQMultipleGame.Visible = false;
            Balance.Visible = false;
            BuyTicketButton.Visible = false;
        }
        private void FAQCommonGame_Click(object sender, EventArgs e)
        {
            Text1.Text = "В обычном режиме вам выдается виртульная валюта в размере";
            Text2.Text = "1000р. Для начала игры необходимо купить билет за 100 рублей";
            Text3.Text = "Одно победное поле дает возможность забрать 150р или играть";
            Text4.Text = "дальше. 2 победых поля возвращает автоматически 500 рублей";
            Text5.Text = "Пустое красное поле означает проигрыш. При нехватки денег";
            Text6.Text = "на новый билет есть возможность взять кредит на 500 рублей";
            Text7.Text = "При победе кредит забирает 25р. до погашения кредита";
            Text8.Text = "Нехватка билета при кредите означает полный проигрыш";
            FAQCommonGame.BackColor = Color.Green;
            FAQControlGame.BackColor = Color.White;
            FAQMultipleGame.BackColor = Color.White;
        }
        private void FAQControlGame_Click(object sender, EventArgs e)
        {
            Text2.Text = "  Контрольный режим включается выставлением флажка и ";
            Text3.Text = "  означает, Что результаты следующей игры будут записаны";
            Text4.Text = "  в статистику. Также, при запуске игры впервые автоматически";
            Text5.Text = "  включается контрольный режим. Просьба вести себя в этом ";
            Text6.Text = "  режиме Максимально правдоподобно для статистики игры";
            Text7.Text = "";
            Text1.Text = "";
            Text8.Text = "";
            FAQCommonGame.BackColor = Color.White;
            FAQControlGame.BackColor = Color.Green;
            FAQMultipleGame.BackColor = Color.White;
        }
        private void FAQMultipleGame_Click(object sender, EventArgs e)
        {

            Text2.Text = "Залповый режим подразумевает собой выбор одной из двух";
            Text3.Text = "стратегий: Неазартный - не продолжать играть после малого";
            Text4.Text = "выигрыша. Азартный - играть до большого выигрыша для";
            Text5.Text = "обработки 5 билетов. В результате показывается статистика";
            Text6.Text = "исходов и совокупный доход игрока";
            Text7.Text = "";
            Text8.Text = "";
            Text1.Text = "";
            FAQCommonGame.BackColor = Color.White;
            FAQControlGame.BackColor = Color.White;
            FAQMultipleGame.BackColor = Color.Green;
        }
        private void ControlGameButton_Click(object sender, EventArgs e)
        {
            if (FIRSTcontrolgame)
            {
                ExitButton.Visible = false;
                Balance.Visible = false;
                AuthorButton.Visible = false;
                PickUpButton.Visible = false;
                AttensionText.Visible = true;
                AttensionText2.Visible = true;
                AttensionText3.Visible = true;
                AttensionText4.Visible = true;
                ButtonOfCancel.Visible = true;
                BuyTicketButton.Visible = true;
                FAQButton.Visible = false;
                PlayGameButton.Visible = false;
                dataGridView2.Visible = false;
                OpenCellButton.Visible = false;
            }
            else
            {
                MoneyText.Text = "1000";
                money = 1000;
                CommonGameButton.Visible = true;
                MultipleGameButton.Visible = true;
                ExitButton.Visible = false;
                AuthorButton.Visible = false;
                AttensionText.Visible = false;
                AttensionText2.Visible = false;
                AttensionText3.Visible = false;
                AttensionText4.Visible = false;
                ButtonOfCancel.Visible = false;
                BuyTicketButton.Visible = false;
                ButtonOfCancel.Visible = true;
                FAQButton.Visible = false;
                PlayGameButton.Visible = false;
                dataGridView2.Visible = false;
                OpenCellButton.Visible = false;
            }
        }
        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            MoneyText.Text = Convert.ToString(money - 100);
            money -= 100;
            PickUpButton.Visible = false;
            ButtonOfCancel.Visible = false;
            BuyTicketButton.Visible = false;
            List<int> spisok = new List<int> { };
            OpenCellButton.Visible = true;
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 2;
            dataGridView2.ColumnCount = 2;
            dataGridView2.RowCount = 2;
            dataGridView2.Visible = true;
            OpenCellButton.Visible = true;
            //Clear the cells
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    dataGridView2[j, i].Value = null;
                    dataGridView2[j, i].Style.BackColor = Color.White;
                }
            }
            bool boolVar = true;
            //fill random 2 cells "1" and 2 cell "0"
            while (boolVar)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        dataGridView1[j, i].Value = rand.Next(0, 2);
                        spisok.Add((int)dataGridView1[j, i].Value);
                    }
                }
                foreach (int i in spisok) if (i == 1) count++;
                if (count == 2) boolVar = false;
                else spisok.Clear();
                count = 0;
            }
            y1 = -1;
            x1 = -1;
        }
        //Receiving coordinates of click's cell
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            x = e.RowIndex;
            y = e.ColumnIndex;
        }
        private void PickUpButton_Click(object sender, EventArgs e)
        {
            if (FIRSTcontrolgame) //If it's a first game of player and he decide to leave before the lose
            {
                Balance.Visible = false;
                result(true);
                MessageBox.Show("Теперь вам доступны новые режими, с ними можно ознамиться в разделе 'FAQ'");
                MainMenu();
                FIRSTcontrolgame = false;
                count = 0;
                PickUpButton.Visible = false;
                AttensionText.Visible = false;
                AttensionText2.Visible = false;
                AttensionText3.Visible = false;
                AttensionText4.Visible = false;
            }
            else
            {
                if (ActiveCredit) //If it's a first game of player and he decide to leave before the lose but he has a credit
                {
                    MoneyText.Text = Convert.ToString(money + 125);
                    money += 125;
                    Debt -= 25;
                }
                else //If it's a first game of player and he decide to leave before the lose and he has no a credit
                {
                    MoneyText.Text = Convert.ToString(money + 150);
                    money += 150;
                }
                OpenCellButton.Visible = false;
                if (Debt == 0) ActiveCredit = false;
                result(false);
                PickUpButton.Visible = false;
                CommonGameButton.Visible = false;
                MultipleGameButton.Visible = false;
                count = 0;
                CommonGameButton_Click(sender, e);
                ButtonOfCancel.Visible = true;
                PickUpButton.Visible = false;
                AttensionText.Visible = false;
                AttensionText2.Visible = false;
                AttensionText3.Visible = false;
                AttensionText4.Visible = false;
            }
        }
        //Just need more funtion of game, because else it looking like trash
        private void AuthorButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/ifpatrick");
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CreditButton_Click(object sender, EventArgs e)
        {
            BuyTicketButton.Visible = true;
            Debt = 500;
            ActiveCredit = true;
            CreditButton.Visible = false;
            MoneyText.Text = Convert.ToString(money + 500);
            money += 500;
        }
        private void CommonGameButton_Click(object sender, EventArgs e)
        {
            MoneyText.Visible = true;
            BuyTicketButton.Visible = true;
            MultipleGameButton.Visible = false;
            CommonGameButton.Visible = false;
            checkBox1.Visible = true;
            Balance.Visible = true;
            ButtonOfCancel.Visible = true;
        }
        private void MultipleGameButton_Click(object sender, EventArgs e)
        {
            CommonGameButton.Visible = false;
            MultipleGameButton.Visible = false;
            GambilingModeButton.Visible = true;
            NonGambilingModeButton.Visible = true;
        }
        private void NonGambilingModeButton_Click(object sender, EventArgs e)
        {
            NonGambilingMODE = true;
            GambilingModeButton.Visible = false;
            NonGambilingModeButton.Visible = false;
            BuyTicketButtonGambilingMode.Visible = true;
            ButtonOfCancel.Visible = true;
            OpenCellButtonGambilingMODE.Visible = false;
        }
        private void GambilingModeButton_Click(object sender, EventArgs e)
        {
            GambilingMODE = true;
            GambilingModeButton.Visible = false;
            NonGambilingModeButton.Visible = false;
            BuyTicketButtonGambilingMode.Visible = true;
            ButtonOfCancel.Visible = true;
            OpenCellButtonGambilingMODE.Visible = false;
        }
        private void OpenCellButtonGambilingMODE_Click(object sender, EventArgs e)
        {
            if (GambilingMODE)
            {
                if ((int)dataGridView1[y, x].Value == 0)
                {
                    GambilingMODECount = 0;
                    count1 +=2;
                    result(false); 
                    GambilingModeButton_Click(sender, e);
                }
                else
                {
                    if (y1 != y || x1 != x)
                    {
                        GambilingMODECount++;
                        if(GambilingMODECount == 1)
                        {
                            count1++;
                            dataGridView2[y, x].Value = "$$$";
                            dataGridView2[y, x].Style.BackColor = Color.Green;
                            y1 = y;
                            x1 = x;
                        }
                        else
                        {
                            count1++;
                            dataGridView2[y, x].Value = "$$$";
                            dataGridView2[y, x].Style.BackColor = Color.Green;
                            y1 = y;
                            x1 = x;
                            GambilingMODECount = 0;
                            result(true);
                            GambilingModeButton_Click(sender, e);
                        }
                    }
                }
                if (count1 >= 10) //exit to menu
                {
                    MessageBox.Show("Статистика");
                    MainMenu();
                    count1 = 0;
                    GambilingMODE = false;
                }

            }
            if (NonGambilingMODE)
            {
                if ((int)dataGridView1[y, x].Value == 0)
                {
                    count1++;
                    result(false);
                    NonGambilingModeButton_Click(sender, e);
                }
                else
                {
                    if (y1 != y || x1 != x)
                    {
                        count1++;
                        dataGridView2[y, x].Value = "$$$";
                        dataGridView2[y, x].Style.BackColor = Color.Green;
                        y1 = y;
                        x1 = x;
                        PickUpButton.Visible = false;
                        result(true);
                        NonGambilingModeButton_Click(sender, e);
                    }
                }
                if (count1 >= 5) //exit to menu
                {
                    MessageBox.Show("Статистика");
                    MainMenu();
                    count1 = 0;
                    NonGambilingMODE = false;
                }
            }
        }
        private void BuyTicketButtonGambilingMode_Click(object sender, EventArgs e)
        {
            ButtonOfCancel.Visible = false;
            BuyTicketButtonGambilingMode.Visible = false;
            List<int> spisok = new List<int> { };
            OpenCellButtonGambilingMODE.Visible = true;
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 2;
            dataGridView2.ColumnCount = 2;
            dataGridView2.RowCount = 2;
            dataGridView2.Visible = true;
            //Clear the cells
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    dataGridView2[j, i].Value = null;
                    dataGridView2[j, i].Style.BackColor = Color.White;
                }
            }
            bool boolVar = true;
            //fill random 2 cells "1" and 2 cell "0"
            while (boolVar)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        dataGridView1[j, i].Value = rand.Next(0, 2);
                        spisok.Add((int)dataGridView1[j, i].Value);
                    }
                }
                foreach (int i in spisok) if (i == 1) count++;
                if (count == 2) boolVar = false;
                else spisok.Clear();
                count = 0;
            }
            y1 = -1;
            x1 = -1;
        }
        private void OpenCellButton_Click(object sender, EventArgs e)
        {
            if ((int)dataGridView1[y, x].Value == 0) //If player lose
            {
                if (FIRSTcontrolgame) //If if it's a first game of player
                {
                    count = 0;
                    FIRSTcontrolgame = false;
                    result(false);
                    MessageBox.Show("Ты проиграл, но теперь тебе доступны новые режимы игры. Ознакомится с ними ты можешь в разделе 'FAQ'");
                    MainMenu();
                    AttensionText.Visible = false;
                    AttensionText2.Visible = false;
                    AttensionText3.Visible = false;
                    AttensionText4.Visible = false;
                }
                else //If it's not a first game of player
                {
                    count = 0;
                    if (money >= 100) //If player have money
                    {
                        result(false);
                        OpenCellButton.Visible = false;
                        PickUpButton.Visible = false;
                        CommonGameButton_Click(sender, e);
                        AttensionText.Visible = false;
                        AttensionText2.Visible = false;
                        AttensionText3.Visible = false;
                        AttensionText4.Visible = false;
                    }
                    else //If player has no money
                    {
                        if (!ActiveCredit) 
                        {
                            PickUpButton.Visible = false;
                            ButtonOfCancel.Visible = true;
                            OpenCellButton.Visible = false;
                            result(false);
                            CreditButton.Visible = true;
                        }//If player has no a credit
                        else //If player already have a credit
                        {
                            Balance.Visible = false;
                            count = 0;
                            result(false);
                            MessageBox.Show("Вы проиграли все свои деньги: c");
                            MainMenu();

                        }
                    }
                }

            }
            else //If player still no lose
            {
                if (y1 != y || x1 != x) //If is been opening cell was no already opened
                {
                    count++;
                    PickUpButton.Visible = true;
                    dataGridView2[y, x].Value = "$$$";
                    dataGridView2[y, x].Style.BackColor = Color.Green;
                    y1 = y;
                    x1 = x;
                    if (count == 1) PickUpButton.Visible = true; //Now player can leave before lose
                    else //If player decided to play continue
                    {
                        if (FIRSTcontrolgame) //If it's a first game of player and he win the best prize
                        {
                            result(true);
                            FIRSTcontrolgame = false;
                            count = 0;
                            PickUpButton.Visible = false;
                            MessageBox.Show("Ты победил! И теперь тебе доступны новые режимы игры. Ознакомится с ними ты можешь в разделе 'FAQ'");
                            MainMenu();
                        }
                        else //If it's no a first game of player and he win the best prize
                        {
                            OpenCellButton.Visible = false;
                            if (ActiveCredit) //If player have a credit
                            {
                                result(true);
                                MoneyText.Text = Convert.ToString(money + 475);
                                money += 475;
                                Debt -= 25;
                                CommonGameButton_Click(sender, e);
                                if (Debt == 0) ActiveCredit = false;
                            }
                            else //If player has no a credit
                            {
                                MoneyText.Text = Convert.ToString(money + 500);
                                money += 500;
                                result(true);
                                count = 0;
                                PickUpButton.Visible = false;
                                CommonGameButton_Click(sender, e);
                            }
                        }

                    }
                }
            }
        }
    }
}