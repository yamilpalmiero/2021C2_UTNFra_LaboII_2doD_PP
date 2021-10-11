using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Biblioteca;

namespace Vista
{
    public partial class FormCiber : Form
    {
        Ciber ciber = new Ciber();

        Telefono t1 = new Telefono("T01", "Siemens", Telefono.TipoTelefono.Teclado);
        Telefono t2 = new Telefono("T02", "Panasonic", Telefono.TipoTelefono.Teclado);
        Telefono t3 = new Telefono("T03", "Motorola", Telefono.TipoTelefono.Teclado);
        Telefono t4 = new Telefono("T04", "General Electric", Telefono.TipoTelefono.Disco);
        Telefono t5 = new Telefono("T05", "Philips", Telefono.TipoTelefono.Disco);

        Computadora c1 = new Computadora("C01", "AMD Ryzen 3", 4, "Radeon RX 550");
        Computadora c2 = new Computadora("C02", "AMD Ryzen 5", 4, "Radeon RX 5500");
        Computadora c3 = new Computadora("C03", "AMD Ryzen 5", 8, "Radeon RX 5600");
        Computadora c4 = new Computadora("C04", "AMD Ryzen 7", 8, "Radeon RX 6000");
        Computadora c5 = new Computadora("C05", "AMD Ryzen 7", 16, "Radeon RX 6600");
        Computadora c6 = new Computadora("C06", "AMD Ryzen 9", 16, "Radeon RX 6800");
        Computadora c7 = new Computadora("C07", "Intel Core i3", 4, "Nvidia Geforce RTX 2060");
        Computadora c8 = new Computadora("C08", "Intel Core i5", 8, "Nvidia Geforce RTX 3060");
        Computadora c9 = new Computadora("C09", "Intel Core i7", 8, "Nvidia Geforce RTX 3070");
        Computadora c10 = new Computadora("C10", "Intel Core i9", 16, "Nvidia Geforce RTX 3080");

        public FormCiber()
        {
            InitializeComponent();
        }

        private void FormCiber_Load(object sender, EventArgs e)
        {
            ciber.Telefonos.Add(t1);
            ciber.Telefonos.Add(t2);
            ciber.Telefonos.Add(t3);
            ciber.Telefonos.Add(t4);
            ciber.Telefonos.Add(t5);

            ciber.Computadoras.Add(c1);
            ciber.Computadoras.Add(c2);
            ciber.Computadoras.Add(c3);
            ciber.Computadoras.Add(c4);
            ciber.Computadoras.Add(c5);
            ciber.Computadoras.Add(c6);
            ciber.Computadoras.Add(c7);
            ciber.Computadoras.Add(c8);
            ciber.Computadoras.Add(c9);
            ciber.Computadoras.Add(c10);
        }
    }
}
