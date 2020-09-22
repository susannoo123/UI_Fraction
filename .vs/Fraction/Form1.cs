using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction {
    public partial class Form1 : Form {
        class Fraction {
            private int _numerator;
            public int numerator {
                get {
                    return _numerator;
                }
                set {
                    this._numerator = value;
                }
            }

            private int _denominator;
            public int denominator {
                get {
                    return _denominator;
                }
                set {
                    this._denominator = value;
                }
            }

            public Fraction(int _numerator, int _denominator) {
                this._numerator = _numerator;
                this._denominator = _denominator;
            }

            public Fraction() {
                this._numerator = 0;
                this._denominator = 1;
            }

            public Fraction(Fraction f) {
                this._numerator = f._numerator;
                this._denominator = f._denominator;
            }

            private int __gcd__(int a, int b) {
                while (a != 0 && b != 0) {
                    if (a > b)
                        a %= b;
                    else
                        b %= a;
                }

                return a | b;
            }

            public Fraction reducing() {
                Fraction rs = new Fraction(this);
                int gcd = __gcd__(this._numerator, this._denominator);
                rs._numerator /= gcd;
                rs._denominator /= gcd;
                //MessageBox.Show(rs._numerator.ToString() + " " + rs._denominator.ToString());
                return rs;
            }

            public string toString() {
                return this._numerator.ToString() + "/" + this._denominator.ToString();
            }

            public Fraction add(Fraction f) {
                Fraction rs = new Fraction();
                rs._numerator = this._numerator * f._denominator + f._numerator * this._denominator;
                rs._denominator = this._denominator * f._denominator;
                return rs;
            }

            public Fraction sub(Fraction f) {
                Fraction rs = new Fraction();
                rs._numerator = this._numerator * f._denominator - f._numerator * this._denominator;
                rs._denominator = this._denominator * f._denominator;
                return rs;
            }

            public Fraction mul(Fraction f) {
                Fraction rs = new Fraction(1, 1);
                rs._numerator = this._numerator * f._numerator;
                rs._denominator = this._denominator * f._denominator;
                return rs;
            }

            public Fraction div(Fraction f) {
                Fraction rs = new Fraction(1, 1);
                rs._numerator = this._numerator * f._denominator;
                rs._denominator = this._denominator * f._numerator;
                return rs;
            }
        }

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction();
        Fraction rs = new Fraction(1, 1);
        public Form1() {
            InitializeComponent();
            txB_num1.Text = f1.numerator.ToString();
            txB_deno1.Text = f1.denominator.ToString();
            txB_num2.Text = f2.numerator.ToString();
            txB_deno2.Text = f2.denominator.ToString();
            txB_f1.Text = txB_num1.Text + "/" + txB_deno1.Text;
            txB_f2.Text = txB_num2.Text + "/" + txB_deno2.Text;
        }

        private void plus_btn_Click(object sender, EventArgs e) {
            f1.numerator = Convert.ToInt32(txB_num1.Text);
            f1.denominator = Convert.ToInt32(txB_deno1.Text);
            f2.numerator = Convert.ToInt32(txB_num2.Text);
            f2.denominator = Convert.ToInt32(txB_deno2.Text);
            txB_f1.Text = txB_num1.Text + "/" + txB_deno1.Text;
            txB_f2.Text = txB_num2.Text + "/" + txB_deno2.Text;
            rs = f1.add(f2);
        }

        private void minus_btn_Click(object sender, EventArgs e) {
            f1.numerator = Convert.ToInt32(txB_num1.Text);
            f1.denominator = Convert.ToInt32(txB_deno1.Text);
            f2.numerator = Convert.ToInt32(txB_num2.Text);
            f2.denominator = Convert.ToInt32(txB_deno2.Text);
            txB_f1.Text = txB_num1.Text + "/" + txB_deno1.Text;
            txB_f2.Text = txB_num2.Text + "/" + txB_deno2.Text;
            rs = f1.sub(f2);
        }

        private void mul_btn_Click(object sender, EventArgs e) {
            f1.numerator = Convert.ToInt32(txB_num1.Text);
            f1.denominator = Convert.ToInt32(txB_deno1.Text);
            f2.numerator = Convert.ToInt32(txB_num2.Text);
            f2.denominator = Convert.ToInt32(txB_deno2.Text);
            txB_f1.Text = txB_num1.Text + "/" + txB_deno1.Text;
            txB_f2.Text = txB_num2.Text + "/" + txB_deno2.Text;
            rs = f1.mul(f2);
        }

        private void div_btn_Click(object sender, EventArgs e) {
            f1.numerator = Convert.ToInt32(txB_num1.Text);
            f1.denominator = Convert.ToInt32(txB_deno1.Text);
            f2.numerator = Convert.ToInt32(txB_num2.Text);
            f2.denominator = Convert.ToInt32(txB_deno2.Text);
            txB_f1.Text = txB_num1.Text + "/" + txB_deno1.Text;
            txB_f2.Text = txB_num2.Text + "/" + txB_deno2.Text;
            rs = f1.div(f2);
        }

        private void equal_btn_Click(object sender, EventArgs e) {
            string title = "Result";
            rs = rs.reducing();
            string ms = rs.toString();
            MessageBox.Show(ms, title);
        }

        private void clr_btn_Click(object sender, EventArgs e) {
            txB_num1.ResetText();
            txB_deno1.ResetText();
            txB_num2.ResetText();
            txB_deno2.ResetText();
            txB_f1.ResetText();
            txB_f2.ResetText();
        }

        private void quit_btn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
