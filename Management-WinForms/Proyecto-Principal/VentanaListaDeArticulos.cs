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
    public partial class VentanaListaDeArticulos : Form
    {
        public VentanaListaDeArticulos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaListaDeArticulos ventana = new VentanaListaDeArticulos();
            this.Hide();
        }
    }
}