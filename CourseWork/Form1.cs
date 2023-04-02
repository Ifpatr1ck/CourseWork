﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        public int x, y;
        private void FAQButton_Click(object sender, EventArgs e)
        {
            ButtonOfCancel.Visible = true;
            ControlGameButton.Visible = false;
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
            ControlGameButton.Visible = true;
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
            ButtonOfCancel.Visible = true;
            BuyTicketButton.Visible = true;
            Balance.Visible = true;
            FAQButton.Visible = false;
            ControlGameButton.Visible = false;
        }
        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            BuyTicketButton.Visible = false;
            List<int> spisok = new List<int> { };
            OpenCellButton.Visible = true;
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 2;
            dataGridView2.ColumnCount = 2;
            dataGridView2.RowCount = 2;
            dataGridView2.Visible = true;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    dataGridView2[j, i].Value = null;
                }
            }
            bool giga = true;
            while(giga)
            {
                int z, count = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        z = rand.Next(0, 2);
                        dataGridView1[j, i].Value = z;
                        spisok.Add(z);
                    }
                }
                foreach (int i in spisok) if (i == 1) count++;
                if (count == 2) giga = false;
                else spisok.Clear();
                count = 0;
            }

        }
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            x = e.RowIndex;
            y = e.ColumnIndex;
        }
        private void OpenCellButton_Click(object sender, EventArgs e)
        {

            int z = (int)dataGridView1[y, x].Value;
            if (z == 1)
            {
                dataGridView2[y, x].Value = 1;
                dataGridView1[y, x].Style.BackColor = Color.Green;
            }
            else
            {
                dataGridView2[y, x].Value = 0;
                dataGridView1[y, x].Style.BackColor = Color.Red;
            }
        }
    }
}
