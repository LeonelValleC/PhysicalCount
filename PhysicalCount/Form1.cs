using System;
using System.Windows.Forms;

namespace PhysicalCount
{
    public partial class Form1 : Form
    {
        PartN pn = new PartN();
        Locacion loc = new Locacion();
        Scan scan = new Scan();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_IdEmp.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //Validar que la cnatidad no sea igual a numero de empleado

            if (!string.IsNullOrEmpty(txt_PN.Text) && !string.IsNullOrEmpty(txt_Loc.Text) && !string.IsNullOrEmpty(txt_Qty.Text) && !string.IsNullOrEmpty(txt_Tagno.Text))
            {
                if (pn.Existe(txt_PN.Text.Trim()))
                {
                    if (txt_IdEmp.Text != txt_Qty.Text)
                    {
                    pn.Id_pn = pn.ReturnID("select id_pn from tb_PN where pn = '" + txt_PN.Text.Trim() + "'");
                    pn.Crud("insert into tb_Scan values('" + pn.Id_pn + "','" + txt_Qty.Text + "','" + txt_Loc.Text + "','" + txt_Tagno.Text + "')");
                    TextEmpty();

                    }
                    else
                    {
                        TextEmpty();
                        MessageBox.Show("Cantidad no valida!");
                    }


                }
                else
                {
                    TextEmpty();
                    MessageBox.Show("Item not exist!");
                }

            }
            else
            {
                MessageBox.Show("Empty Fields!");
                TextEmpty();
            }
            txt_PN.Focus();
        }

        private void TextEmpty()
        {
            txt_Tagno.Text = "";
            txt_Qty.Text = "";
            txt_Loc.Text = "";
            txt_PN.Text = "";
        }


        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_Tagno_Leave(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txt_PN.Text) && !string.IsNullOrEmpty(txt_Loc.Text) && !string.IsNullOrEmpty(txt_Qty.Text) && !string.IsNullOrEmpty(txt_Tagno.Text))
                {
                    if (pn.Existe(txt_PN.Text.Trim()+"|01"))
                    {
                        //if (int.Parse(txt_Tagno.Text) >= 0000 && int.Parse(txt_Tagno.Text) <= 0999)
                        if (scan.ExisteCon(txt_Tagno.Text))
                        {
                            if (!scan.ExisteTag(txt_Tagno.Text))
                            {
                                pn.Id_pn = pn.ReturnID("select id_pn from tb_PN where pn = '" + txt_PN.Text.Trim() + "|01'");
                                if (loc.ExisteLoc(txt_Loc.Text.Trim()))
                                {
                                    loc.Id_loc = loc.ReturnID("select id_loc from tb_Loc where loc = '" + txt_Loc.Text.Trim() + "'");

                                    pn.Crud("insert into tb_Scan (id_pn, qty, loc, tagno, emp, dateReg) values('" + pn.Id_pn + "','" + txt_Qty.Text + "','" + loc.Id_loc + "','" + txt_Tagno.Text + "','" + txt_IdEmp.Text + "','" + DateTime.Now + "')");
                                    MessageBox.Show("Item ingresado exitosamente!");
                                    TextEmpty();
                                }
                                else
                                {
                                    MessageBox.Show("La location no existe!");
                                    TextEmpty();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tag ya existe! \nFavor de contactar a Leonel Valle para borrar el registro! ");
                                TextEmpty();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Tags no coicide con el consecutivo");
                            TextEmpty();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Item no existe!");
                        TextEmpty();
                    }

                }
                else
                {
                    MessageBox.Show("Campos vacios!");
                    TextEmpty();
                }
            }
            catch (System.FormatException)
            {

                MessageBox.Show("Formato Incorrecto!"); ;
            }
        }

        private void txt_IdEmp_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_PN_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void txt_Qty_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_PN_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_Loc_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_Tagno_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
