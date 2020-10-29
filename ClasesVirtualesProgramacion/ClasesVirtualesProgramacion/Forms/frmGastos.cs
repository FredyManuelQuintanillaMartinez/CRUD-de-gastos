using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesVirtualesProgramacion.Forms
{
    public partial class frmGastos : Form
    {
        admConexion oConexion = new admConexion();
        public frmGastos()
        {
            InitializeComponent();
        }

        private void frmGastos_Load(object sender, EventArgs e)
        {
            dsClasesVirtuales.Gastos.Clear();
            string SelectSQL = "select * from gastos";
            if (oConexion.SelectData(SelectSQL, dsClasesVirtuales.Gastos) != true)
                MessageBox.Show("No se ha podido cargar ningun dato de gastos, contacte al departamento de desarrollo tecnico", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNuevog_Click(object sender, EventArgs e)
        {
            Dialogs.GastosDialog frmNuevo = new Dialogs.GastosDialog();
            frmNuevo.fechaDateTimePicker.Focus();
            frmNuevo.ShowDialog();
            if(frmNuevo.DialogResult == DialogResult.OK)
            {
                string sqlInsert = string.Format("insert into gastos (fecha,categoria,subcategoria,descripcion,valor,formapago) values ('{0}', '{1}','{2}','{3}',{4},'{5}')", frmNuevo.fechaDateTimePicker.Value.ToString("yy-MM-dd"), frmNuevo.categoriaComboBox.Text, frmNuevo.subcategoriaComboBox.Text, frmNuevo.descripcionTextBox.Text.Trim(), frmNuevo.nudValor.Value.ToString(), frmNuevo.formapagoComboBox.Text);
                if(oConexion.AccionSQL(sqlInsert)== true)
                {
                    this.frmGastos_Load(null, null);
                    MessageBox.Show("La información de los gastos ha sido almacenada correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gastosDataGridView.Focus();
                }
            }
        }

        private void btnCerrarg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditarg_Click(object sender, EventArgs e)
        { if(gastosBindingSource.Count > 0)
            {
                Dialogs.GastosDialog frmEditar = new Dialogs.GastosDialog();
                DataGridViewRow Fila = gastosDataGridView.CurrentRow;
                Int16 ID = Int16.Parse(Fila.Cells[0].Value.ToString());
                frmEditar.fechaDateTimePicker.Value = Convert.ToDateTime(Fila.Cells[1].Value);
                frmEditar.categoriaComboBox.Text = Fila.Cells[2].Value.ToString();
                frmEditar.subcategoriaComboBox.Text = Fila.Cells[3].Value.ToString();
                frmEditar.descripcionTextBox.Text = Fila.Cells[4].Value.ToString();
                frmEditar.nudValor.Value = Convert.ToDecimal(Fila.Cells[5].Value);
                frmEditar.formapagoComboBox.Text = Fila.Cells[6].Value.ToString();
                frmEditar.fechaDateTimePicker.Focus();
                frmEditar.ShowDialog();
                if(frmEditar.DialogResult == DialogResult.OK)
                {
                    string sqlUpdate = string.Format("update gastos set fecha = '{0}', categoria = '{1}', subcategoria = '{2}', descripcion = '{3}', valor = {4}, formapago = '{5}' where id = {6}", frmEditar.fechaDateTimePicker.Value.ToString("yy-MM-dd"), frmEditar.categoriaComboBox.Text, frmEditar.subcategoriaComboBox.Text, frmEditar.descripcionTextBox.Text.Trim(), frmEditar.nudValor.Value.ToString(), frmEditar.formapagoComboBox.Text, ID);
                    
                    if(oConexion.AccionSQL(sqlUpdate) == true)
                    {
                        this.frmGastos_Load(null, null);
                        MessageBox.Show("La información de los gastos ha sido actualizada correctamente.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gastosDataGridView.Focus();
                    }
                }
            }
            
        }
        private void btnEliminarg_Click(object sender, EventArgs e)
        {
            if(gastosBindingSource.Count > 0)
            
            {
                if (MessageBox.Show("Asegurese de eliminar la información de los gastos. ¿Está seguro de querer eliminar permanentemente el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DataGridViewRow Fila = gastosDataGridView.CurrentRow;
                    Int16 ID = Int16.Parse(Fila.Cells[0].Value.ToString());
                    string sqlDelete = string.Format("delete from gastos where id = {0}", ID);
                    if(oConexion.AccionSQL(sqlDelete) == true)
                    {
                        this.frmGastos_Load(null, null);
                        MessageBox.Show("La información de los gastos ha sido borrada permanentemente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gastosDataGridView.Focus();               
                    }

                }
            }
                else
                {
                MessageBox.Show("No hay información para eliminar un registro.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnBuscarg_Click(object sender, EventArgs e)
        {
            if (cmbBuscarporg.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una de las opciones para buscar los gastos ya sea por Categoria, Subcategoria o Descripción.", ("Buscar"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbBuscarporg.Focus();
                return;
            }
            else
            {
                if (txtCriteriog.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor seleccione un criterio para realizar la busqueda de los gastos.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCriteriog.Focus();
                    return;
                }
                else
                {
                    string sqlSelect = string.Empty;
                    switch (cmbBuscarporg.SelectedIndex)
                    {
                        case 0://Categoria
                            sqlSelect = string.Format("Select * from gastos where categoria = '{0}'", txtCriteriog.Text.Trim()); 
                            break;
                        case 1: // Subcategoria
                            sqlSelect = string.Format("Select * from gastos where subcategoria = '{0}'", txtCriteriog.Text.Trim());
                            break;
                        default:// Apellidos
                            sqlSelect = string.Format("Select * from gastos where descripcion like '{0}%'", txtCriteriog.Text.Trim());
                            break;
                    }
                    dsClasesVirtuales.Gastos.Clear();
                    if (oConexion.SelectData(sqlSelect, dsClasesVirtuales.Gastos) == true)
                        gastosDataGridView.Focus();
            }

            }
        }
    }
}
