﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alternativa_1
{
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void btnArticulosVolver_Click(object sender, EventArgs e)
        {
            Ventana2 ventana = new Ventana2();
            this.Hide();
        }
    }
}