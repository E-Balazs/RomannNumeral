using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rómaiváltó
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool oda = true;

        private void BT_Merre_Click(object sender, EventArgs e)
        {
            oda = !oda;
            if (oda)
            {
                BT_Merre.Text = "→";
            }
            else
            {
                BT_Merre.Text = "←";
            }
        }

        private void BT_Vált_Click(object sender, EventArgs e)
        {
            Váltó izé = new Rómaiváltó.Váltó();
            if (oda)
            {
                int a;
                int.TryParse(TB_A.Text,out a);
                TB_R.Text = izé.Rómaira(a);
            }
            else
            {
                int lel = 0;
                lel = izé.Arabra(TB_R.Text,ref lel);
                TB_A.Text = lel.ToString();
            }
        }

        private void TB_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_R_KeyPress(object sender, KeyPressEventArgs e)
        {
           char[] római = { 'I', 'V', 'X', 'L', 'C', 'D', 'M', 'ↁ', 'ↂ'};
            e.Handled = !római.Contains(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }

    class Váltó
    {
        public string Rómaira(int mit)
        {
            if (mit >= 10000)
            {
                return "ↂ" + Rómaira(mit - 10000);
            }
            if (mit >= 9000)
            {
                return "Mↂ" + Rómaira(mit - 9000);
            }
            if (mit >= 5000)
            {
                return "ↁ" + Rómaira(mit - 5000);
            }
            if (mit >= 4000)
            {
                return "Mↁ" + Rómaira(mit - 4000);
            }
            if (mit >= 1000)
            {
                return "M" + Rómaira(mit - 1000);
            }
            if (mit >= 900)
            {
                return "CM" + Rómaira(mit - 900);
            }
            if (mit >= 500)
            {
                return "D" + Rómaira(mit - 500);
            }
            if (mit >= 400)
            {
                return "CD" + Rómaira(mit - 400);
            }
            if (mit >= 100)
            {
                return "C" + Rómaira(mit - 100);
            }
            if (mit >= 90)
            {
                return "XC" + Rómaira(mit - 90);
            }
            if (mit >= 50)
            {
                return "L" + Rómaira(mit - 50);
            }
            if (mit >= 40)
            {
                return "XL" + Rómaira(mit - 40);
            }
            if (mit >= 10)
            {
                return "X" + Rómaira(mit - 10);
            }
            if (mit >= 9)
            {
                return "IX" + Rómaira(mit - 9);
            }
            if (mit >= 5)
            {
                return "V" + Rómaira(mit - 5);
            }
            if (mit >= 4)
            {
                return "IV" + Rómaira(mit - 4);
            }
            if (mit >= 1)
            {
                return "I" + Rómaira(mit - 1);
            }
            else
            {
                return "";
            }
        }
        public int Arabra(string mit, ref int mire)
        {
            if (mit.Length > 0)
            {
                switch (mit[0])
                {
                    case 'ↂ':
                        mire += 10000;
                        return Arabra(mit.Remove(0, 1), ref mire);
                    case 'ↁ':
                        mire += 5000;
                        return Arabra(mit.Remove(0, 1), ref mire);
                    case 'M':
                        if (mit.Length > 1)
                        {
                            switch (mit[1])
                            {
                                case 'ↂ':
                                    mire += 9000;
                                    return Arabra(mit.Remove(0, 2), ref mire);
                                case 'ↁ':
                                    mire += 4000;
                                    return Arabra(mit.Remove(0, 2), ref mire);
                                default:
                                    mire += 1000;
                                    return Arabra(mit.Remove(0, 1), ref mire);
                            }
                        }
                        mire += 1000;
                        return Arabra(mit.Remove(0, 1), ref mire);
                    case 'D':
                        mire += 500;
                        return Arabra(mit.Remove(0, 1), ref mire);
                    case 'C':
                        if (mit.Length > 1)
                        {
                            switch (mit[1])
                            {
                                case 'M':
                                    mire += 900;
                                    return Arabra(mit.Remove(0, 2), ref mire);
                                case 'D':
                                    mire += 400;
                                    return Arabra(mit.Remove(0, 2), ref mire);
                                default:
                                    mire += 100;
                                    return Arabra(mit.Remove(0, 1), ref mire);
                            }
                        }
                        mire += 100;
                        return Arabra(mit.Remove(0, 1), ref mire);
                    case 'L':
                        mire += 50;
                        return Arabra(mit.Remove(0, 1), ref mire);
                    case 'X':
                        if (mit.Length > 1)
                        {
                            switch (mit[1])
                            {
                                case 'C':
                                    mire += 90;
                                    return Arabra(mit.Remove(0, 2), ref mire);
                                case 'L':
                                    mire += 40;
                                    return Arabra(mit.Remove(0, 2), ref mire);
                                default:
                                    mire += 10;
                                    return Arabra(mit.Remove(0, 1), ref mire);
                            }
                        }
                        mire += 10;
                        return Arabra(mit.Remove(0, 1), ref mire);
                    case 'V':
                        mire += 5;
                        return Arabra(mit.Remove(0, 1), ref mire);
                    case 'I':
                        if (mit.Length > 1)
                        {
                            switch (mit[1])
                            {
                                case 'X':
                                    mire += 9;
                                    return Arabra(mit.Remove(0, 2), ref mire);
                                case 'V':
                                    mire += 4;
                                    return Arabra(mit.Remove(0, 2), ref mire);
                                default:
                                    mire += 1;
                                    return Arabra(mit.Remove(0, 1), ref mire);
                            }
                        }
                        mire += 1;
                        return Arabra(mit.Remove(0, 1), ref mire);
                }
            }
            return mire;
        }
    }
}
