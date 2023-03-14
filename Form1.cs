using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubNetMask_calculator
{
    public partial class Form1 : Form
    {
        Ip indirizzo;
        Ip subMask;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            string[] ip = txtIndirizzo.Text.Split('.');

            indirizzo = new Ip(
                (byte)Convert.ToInt32(ip[0]),
                (byte)Convert.ToInt32(ip[1]),
                (byte)Convert.ToInt32(ip[2]),
                (byte)Convert.ToInt32(ip[3]));

            ip = txtMask.Text.Split('.');

            subMask = new Ip(
                (byte)Convert.ToInt32(ip[0]),
                (byte)Convert.ToInt32(ip[1]),
                (byte)Convert.ToInt32(ip[2]),
                (byte)Convert.ToInt32(ip[3]));

            lblIndBinario.Text = $"Indirizzo di rete in binario: {indirizzo.ToBinaryString()}";
            lblSubBinario.Text = $"Sub net mask in binario: {subMask.ToBinaryString()}";
            lblWildCardDec.Text = $"WildCard mask decimale: {subMask.getWildCard()}";
            lblWildCardBin.Text = $"WildCard mask binaria: {subMask.getWildCard().ToBinaryString()}";
            lblClasse.Text = $"Classe: {Ip.getClass(indirizzo)}";
            lblNetFormato.Text = $"Net mask in formato /x: {subMask.ToXFormat()}";
            lblBrDec.Text = $"Broadcast di rete decimale: {indirizzo | subMask.getWildCard()}";
            lblBrBin.Text = $"Broadcast di rete binario: {(indirizzo | subMask.getWildCard()).ToBinaryString()}";
            lblReteDec.Text = $"Indirizzo rete decimale: {indirizzo & subMask}";
            lblReteBin.Text = $"Indirizzo rete binario: {(indirizzo & subMask).ToBinaryString()}";
            lblNHost.Text = $"Numero host rappresentabili: {Ip.getAvailableHosts(subMask)}";
            lblNReti.Text = $"Numero reti reppresentabili: {Ip.getAvailableSubNets(indirizzo | subMask.getWildCard(), indirizzo & subMask)}";
        }
    }
}
