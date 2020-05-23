using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicegame
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        double[] possibilites = new double[6] {0.166666667, 0.166666667, 0.166666667, 0.166666667, 0.166666667, 0.166666667};
        int[] dice = new int[3];
        Boolean CheatsOn = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonForDicing_Click(object sender, EventArgs e)
        {
            for(int j = 0; j < 3; j++)
            {
                double a = rnd.NextDouble() % 1;
                for (int i = 1; i <= 6; i++)
                {
                    a -= possibilites[i - 1];
                    if (a <= 0)
                    {
                        dice[j] = i;
                        break;
                    }
                }
            }
            labelForResult.Text = "Вам выпадает " + dice[0] + "," + dice[1] + "," + dice[2] + ". " + "Их сумма:" + (dice[0] + dice[1] + dice[2]);
            if (CheatsOn)
            {
                for (int j = 0; j < 6; j++)
                {
                    possibilites[j] = 0.166666667;
                }
                CheatsOn = false;
            }
        }

        private void buttonForCheating_Click(object sender, EventArgs e)
        {
            CheatsOn = true;
            possibilites[0] = 0;
            possibilites[1] = 0;
            possibilites[2] = 0;
            possibilites[3] = 0.05;
            possibilites[4] = 0.25;
            possibilites[5] = 0.7;
        }
    }
}
