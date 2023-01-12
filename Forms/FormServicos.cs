using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace ProjetoRH_GerenciadorDeServiços.Forms {
    public partial class FormServicos : Form {

        private ServiceController serviceController;
        private string CurrentService;

        public FormServicos() {
            InitializeComponent();
        }

        private void MontaColunasListView() {
            listaServicos.Columns.Add("Nome", 250, HorizontalAlignment.Left);
            listaServicos.Columns.Add("Status", 100, HorizontalAlignment.Left);
        }

        private void CaminhoDoServico(string ServiceName){
            using (ManagementObject wmiService = new ManagementObject("Win32_Service.Name='" + ServiceName + "'")) {
                wmiService.Get();
                string currentserviceExePath = wmiService["PathName"].ToString();
                string[] currentserviceExePathSplitted = currentserviceExePath.Split('\\');
                Array.Resize(ref currentserviceExePathSplitted, currentserviceExePathSplitted.Length - 1);
                

                string currentServiceFolder = String.Join("/", currentserviceExePathSplitted);

                textBoxCaminho.Text = currentServiceFolder;
            }
        }

        private void ListarServicos() {
            listaServicos.Columns.Clear();
            listaServicos.Items.Clear();
            ServiceController[] services = ServiceController.GetServices();
            MontaColunasListView();

            foreach (ServiceController service in services) {
                try {
                    ListViewItem linhaListView = new ListViewItem();

                    linhaListView.Text = service.ServiceName.ToString();
                    linhaListView.SubItems.Add(service.Status.ToString());

                    listaServicos.Items.Add(linhaListView);
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            };
        }

        private void btnListarServicos_Click(object sender, EventArgs e) {
            ListarServicos();
        }

        private void listaServicos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            CurrentService = e.Item.Text;
            CaminhoDoServico(CurrentService);
        }

        private void btnPararServico_Click(object sender, EventArgs e) {
            serviceController = new ServiceController(CurrentService);
            //Task.Factory.StartNew(() => stopService());
            stopService();
            ListarServicos();
        }

        private void btnReiniciarServico_Click(object sender, EventArgs e) {
            serviceController = new ServiceController(CurrentService);
            //Task.Factory.StartNew(() => restartService());
            restartService();
            ListarServicos();
        }
        public void stopService() {
            try {

                serviceController.Refresh();
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(3000);

                if (serviceController.Status == ServiceControllerStatus.Running) {
                    serviceController.Stop();
                    serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                    
                } else {
                    MessageBox.Show("O Serviço já esta parado");
                }
            } catch (Exception e) {
                MessageBox.Show(string.Format("Erro ao parar o serviço {0} {1}", e.Message, e.InnerException.Message));
            }
        }

        public void restartService() {
            try {
                serviceController.Refresh();
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(3000);

                if (serviceController.Status == ServiceControllerStatus.Running) {
                    serviceController.Stop();
                    serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                }
                serviceController.Start();
                serviceController.WaitForStatus(ServiceControllerStatus.Running, timeout);
            } catch (Exception e) {
                MessageBox.Show(string.Format("Erro ao reiniciar serviço {0} {1}", e.Message, e.InnerException.Message));
            }
        }

    }
}
