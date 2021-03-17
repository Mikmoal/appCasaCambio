using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCasaCambio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxCantidadD.Clear();
            tbxCantidadD.Focus();
            tbxResultado.Text = "";
            tbxResultado.Visible = false;
            
            rbEUA.Checked = false;
            rbEUA.Visible = false;

            rbJapon.Checked = false;
            rbJapon.Visible = false;

            rbAlemania.Checked = false;
            rbAlemania.Visible = false;

            rbBrasil.Checked = false;
            rbBrasil.Visible = false;

            label2.Visible = false;
            label3.Visible = false;

            pbxAlemania.Visible = false;
            pbxBrasil.Visible = false;
            pbxJapon.Visible = false;
            pbxEUA.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxCantidadD_TextChanged(object sender, EventArgs e)
        {
            tbxResultado.Visible = true;
            rbEUA.Visible = true;
            rbJapon.Visible = true;
            rbAlemania.Visible = true;
            rbBrasil.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void rbEUA_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Cantidad en";
            if (tbxCantidadD.Text != "")
            {
                pbxAlemania.Visible = false;
                pbxBrasil.Visible = false;
                pbxJapon.Visible = false;
                tbxResultado.Text = Math.Round((Convert.ToDouble(tbxCantidadD.Text) * .047550), 2).ToString();
                pbxEUA.Visible = true;
                label2.Text += " USD";
            }
            
        }

        private void rbJapon_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Cantidad en";
            if (tbxCantidadD.Text != "")
            {
                pbxAlemania.Visible = false;
                pbxBrasil.Visible = false;
                pbxEUA.Visible = false;
                tbxResultado.Text = Math.Round((Convert.ToDouble(tbxCantidadD.Text) * 5.1585), 2).ToString();
                pbxJapon.Visible = true;
                label2.Text += " YNJ";
            }
        }

        private void rbAlemania_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Cantidad en";
            if (tbxCantidadD.Text != "")
            {
                pbxBrasil.Visible = false;
                pbxEUA.Visible = false;
                pbxJapon.Visible = false;
                tbxResultado.Text = Math.Round((Convert.ToDouble(tbxCantidadD.Text) * .039930), 2).ToString();
                pbxAlemania.Visible = true;
                label2.Text += " EUR";
            }
        }

        private void rbBrasil_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Cantidad en";
            if (tbxCantidadD.Text != "")
            {
                pbxEUA.Visible = false;
                pbxJapon.Visible = false;
                pbxAlemania.Visible = false;
                tbxResultado.Text = Math.Round((Convert.ToDouble(tbxCantidadD.Text) * .27256), 2).ToString();
                pbxBrasil.Visible = true;
                label2.Text += " BSD";
            }
        }
    }
}
