﻿using SistemaDeVentas.Entidades;
using SistemaDeVentas.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaDeVentas.VentanasReportes
{
    public partial class FacturasReportes : Form
    {
        List<Facturas> datos = null;

        public FacturasReportes(List<Facturas> facturas)
        {
            InitializeComponent();
            datos = facturas;
        }

        private void FacturasViewer_Load(object sender, EventArgs e)
        {
            ReportesDeFacturas reportesDeFacturas = new ReportesDeFacturas();
            reportesDeFacturas.SetDataSource(datos);

            FacturasViewer.ReportSource = reportesDeFacturas;
            FacturasViewer.Refresh();
        }
    }
}
