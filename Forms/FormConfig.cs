using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace ProjetoRH_GerenciadorDeServiços.Forms {
    public partial class FormConfig : Form {

        TxtManager configFile;
        public FormConfig() {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            try {
                configFile = new TxtManager($@"{textBoxBuscar.Text}");
                string configJson = configFile.ReadFile();
                textBoxConfig.Text = configJson;
             
            } catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("O serviço está parado?", "Salvar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                try {
                    configFile.OverwriteFile(textBoxConfig.Text);
                    MessageBox.Show("Alteração salva!");
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            } else if (dialogResult == DialogResult.No) {
                MessageBox.Show("Alterações só podem ser efetuadas com o serviço parado.");
            }
        }
    }
}
