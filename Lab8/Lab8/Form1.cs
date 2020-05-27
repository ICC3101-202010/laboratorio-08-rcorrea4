using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void panelEntrada_Paint(object sender, PaintEventArgs e)
        {

        }



        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            panelEntrada.Visible = false;
            panelAgregar.Visible = true;
            buttonCrear.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cine")
            {
                panelAtributo.Visible = true;
                labelNSalas.Text = "N Salas";
                labelNSalas.Visible = true;
                textBoxNSalas.Visible = true;
                checkBoxEx.Visible = false;
            }
            if (comboBox1.Text == "Restaurant")
            {
                panelAtributo.Visible = true;
                labelNSalas.Visible = false;
                textBoxNSalas.Visible = false;
                checkBoxEx.Visible = true;
            }
            if (comboBox1.Text == "Tienda")
            {
                panelAtributo.Visible = true;
                labelNSalas.Text = "Categoria";
                labelNSalas.Visible = true;
                textBoxNSalas.Visible = true;
                checkBoxEx.Visible = false;

            }
            if (comboBox1.Text == "Recreacional")
            {
                panelAtributo.Visible = false;
                
            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string mensaje=" ";
            if (comboBox1.Text == "Cine")
            {
                Cine cine = new Cine(textBoxNd.Text, Int32.Parse(textBoxId.Text), textBoxH.Text, Int32.Parse(textBoxNSalas.Text));
                mensaje = "Cine "+ textBoxNd.Text+" creado con exito";
                Global.localesComerciales.Add(cine);
                comboBoxLocales.Items.Add(cine.OwnerName);

            }
            else if (comboBox1.Text == "Restaurant")
            { 
                Restaurante restaurante = new Restaurante(textBoxNd.Text, Int32.Parse(textBoxH.Text), textBoxH.Text, checkBoxEx.Checked );
                mensaje = "Restaurante " + restaurante.OwnerName + " creado con exito";
                Global.localesComerciales.Add(restaurante);
                comboBoxLocales.Items.Add(restaurante.OwnerName);
            }
            else if (comboBox1.Text == "Tienda")
            {
                Tienda tienda = new Tienda(textBoxNd.Text, Int32.Parse(textBoxH.Text), textBoxH.Text);
                tienda.categorias.Add(textBoxNSalas.Text);
                mensaje = "Tienda " + tienda.OwnerName + " creadoa con exito";
                Global.localesComerciales.Add(tienda);
                comboBoxLocales.Items.Add(tienda.OwnerName);

            }
            else if (comboBox1.Text == "Recreacional")
            {
                Recreacional recreacional = new Recreacional(textBoxNd.Text, Int32.Parse(textBoxH.Text), textBoxH.Text);
                mensaje = "Recreacional " + recreacional.OwnerName + " creadoa con exito";
                Global.localesComerciales.Add(recreacional);
                comboBoxLocales.Items.Add(recreacional.OwnerName);
            }
            MessageBox.Show(mensaje);
            
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
            panelEntrada.Visible = true;

        }

        private void comboBoxLocales_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            panelRevisar.Visible = true;
            panelEntrada.Visible = false;
        }

        private void buttonVerInfo_Click(object sender, EventArgs e)
        {
            LocalComercial seleccionado;
            foreach (LocalComercial local in Global.localesComerciales)
            {
                if (local.OwnerName == comboBoxLocales.Text)
                {
                    seleccionado = local;
                    
                    string informacion = "Owner Name: " + seleccionado.OwnerName +
                "\r Id: " + seleccionado.Id +
                "\r Horario: " + seleccionado.Horario;
                    if (seleccionado.GetType() == typeof(Cine))
                    {
                        informacion += "\r N de salas: " + (((Cine)seleccionado).numeroSalas).ToString();
                    }
                    else if(seleccionado.GetType() == typeof(Tienda))
                    {
                        informacion += "\r Categorias: " + (((Tienda)seleccionado).categorias[0]).ToString();
                    }
                    else if (seleccionado.GetType() == typeof(Restaurante))
                    {
                        informacion += "\r Mesa Exclusiva: " + (((Restaurante)seleccionado).exclusivo).ToString();
                    }


                    MessageBox.Show(informacion);
                    
                    
                }
            }
            


        }

        private void buttonAtras2_Click(object sender, EventArgs e)
        {
            panelRevisar.Visible = false;
            panelEntrada.Visible = true;
        }

        private void buttonVerTodos_Click(object sender, EventArgs e)
        {
            string infoTotal="";
            int i = 1;
            foreach (LocalComercial local in Global.localesComerciales)
            {
                
                
                    LocalComercial seleccionado = local;

                    string informacion ="\r Local"+ i.ToString()+
                    "\r Owner Name: " + seleccionado.OwnerName +
                "\r Id: " + seleccionado.Id +
                "\r Horario: " + seleccionado.Horario;
                    if (seleccionado.GetType() == typeof(Cine))
                    {
                        informacion += "\r N de salas: " + (((Cine)seleccionado).numeroSalas).ToString();
                    }
                    else if (seleccionado.GetType() == typeof(Tienda))
                    {
                        informacion += "\r Categorias: " + (((Tienda)seleccionado).categorias[0]).ToString();
                    }
                    else if (seleccionado.GetType() == typeof(Restaurante))
                    {
                        informacion += "\r Mesa Exclusiva: " + (((Restaurante)seleccionado).exclusivo).ToString();
                    }
                informacion += "\r";
                i++;
                infoTotal += informacion;

                


            }
            MessageBox.Show(infoTotal);
        }
    }
}
