﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula63_Componentes
{
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transportes = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            transportes.Add(cb_carro);
            transportes.Add(cb_aviao);
            transportes.Add(cb_navio);
            transportes.Add(cb_onibus);
        }

        private void btn_transportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (CheckBox t in transportes)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }
            /*if (cb_carro.Checked)
            {
                txt += cb_carro.Text + ", ";
            }
            if (cb_aviao.Checked)
            {
                txt += cb_aviao.Text + ", ";
            }
            if (cb_navio.Checked)
            {
                txt += cb_navio.Text + ", ";
            }
            if (cb_onibus.Checked)
            {
                txt += cb_onibus.Text + ", ";
            }*/
            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show("Patinete marcado");
            }
            else
                MessageBox.Show("Patinete desmarcado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_filhoCheckBox f_filho = new F_filhoCheckBox();
            f_filho.ShowDialog();
        }
    }
}
