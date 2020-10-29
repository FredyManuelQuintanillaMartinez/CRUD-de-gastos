using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesVirtualesProgramacion.Dialogs;

namespace ClasesVirtualesProgramacion.Dialogs
{
    public partial class EstudianteDialog : baseDialog
    {
        public EstudianteDialog()
        {
            InitializeComponent();
        }
        protected override bool ValidarEntrada()
        {
            erp.Clear();
            if (identidadTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba el numero de identidad del estudiante",identidadTextBox);

            if (sexoComboBox.SelectedIndex < 0)
                return NotificacionDeValidacion("Por favor seleccione Femenino o Maxculino para el sexo del estudiante", sexoComboBox);

            if (nombresTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba los nombres completos del estudainte", nombresTextBox);

            if (apellidosTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba los apellidos completos del estudainte", apellidosTextBox);

            if (direccionTextBox.Text.Trim() == string.Empty)
                return NotificacionDeValidacion("Por favor escriba la dirección donde el estudainte vive", direccionTextBox);
            return true;
        }
    }
}
