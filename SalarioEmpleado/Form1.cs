﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double horasTrabajadas, valorHora, salarioBase, 
                salud, incremento, salarioNeto;

            horasTrabajadas = double.Parse(txtHoras.Text);
            valorHora = double.Parse(txtValor.Text);

            salarioBase = horasTrabajadas * valorHora;

            switch (cbxEmpleadoAdm.SelectedItem)
            {
                case "No":

                    if (salarioBase > 1000000)
                    {
                        salud = salarioBase * 0.04;
                        salarioNeto = salarioBase - salud;
                        incremento = 0;

                        salarioNeto = salarioBase - salud + incremento;
                    }
                    else
                    {
                        salud = 0;
                        salarioNeto = salarioBase - salud;
                        incremento = salarioBase * 0.02;

                        salarioNeto = salarioBase - salud + incremento;
                    }

                    lblSalarioBase.Text = Convert.ToString("$" + String.Format("{0:n0}", salarioBase));
                    lblPagoSalud.Text = Convert.ToString("$" + String.Format("{0:n0}", salud));
                    lblIncremento.Text = Convert.ToString("$" + String.Format("{0:n0}", incremento));
                    lblSalarioNeto.Text = Convert.ToString("$" + String.Format("{0:n0}", salarioNeto));

                    gbxResumen.Visible = true;

                    break;

                case "Si":

                    if (salarioBase > 1000000)
                    {
                        salud = salarioBase * 0.04;
                        salarioNeto = salarioBase - salud;
                        incremento = 0;

                        salarioNeto = salarioBase - salud + incremento;
                    }
                    else
                    {
                        salud = 0;
                        salarioNeto = salarioBase - salud;
                        incremento = salarioBase * 0.01;

                        salarioNeto = salarioBase - salud + incremento;
                    }

                    lblSalarioBase.Text = Convert.ToString("$" + String.Format("{0:n0}", salarioBase));
                    lblPagoSalud.Text = Convert.ToString("$" + String.Format("{0:n0}", salud));
                    lblIncremento.Text = Convert.ToString("$" + String.Format("{0:n0}", incremento));
                    lblSalarioNeto.Text = Convert.ToString("$" + String.Format("{0:n0}", salarioNeto));

                    gbxResumen.Visible = true;

                    break;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHoras.Text = String.Empty;
            txtValor.Text = String.Empty;
            gbxResumen.Visible = false;
            txtHoras.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxEmpleadoAdm.SelectedIndex = 0; 
        }
    }
}
