using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;

namespace PrimerasHU_GES
{
    public partial class PrimeraPantalla : Form
    {
        public PrimeraPantalla()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btn_CPlan_Click(object sender, EventArgs e)
        {
            if (lbl_TipoUsu.Text == "Encargado DE&MS" || lbl_TipoUsu.Text == "Administrador")
            {
                if (panelCplan.Visible == true)
                {
                    panelCplan.Visible = false;
                }
                else
                {
                    panelAnalisis.Visible = false;
                    panelDmo.Visible = false;
                    p_Administrador.Visible = false;
                    panelCplan.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Este menú se encuentra deshabilitado porque no cuenta con los permisos necesarios. Para más información consulte con el Administrador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Dmo_Click(object sender, EventArgs e)
        {
            if (lbl_TipoUsu.Text == "Administrador" || lbl_TipoUsu.Text == "Encargado DE&MS" || lbl_TipoUsu.Text == "Responsable Analista")
            {
                if (panelDmo.Visible == true)
                {
                    panelDmo.Visible = false;
                }
                else
                {
                    panelAnalisis.Visible = false;
                    panelDmo.Visible = true;
                    p_Administrador.Visible = false;
                    panelCplan.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Este menú se encuentra deshabilitado porque no cuenta con los permisos necesarios. Para más información consulte con el Administrador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Img_Click(object sender, EventArgs e)
        {
            Imagenes f = new Imagenes();
            f.Show();
        }

        private void PrimeraPantalla_Load(object sender, EventArgs e)
        {
            sidebar1.Visible = false;
            panelCplan.Hide();
            panelDmo.Hide();
            panelAnalisis.Hide();
            p_Administrador.Hide();
        }

        private void btn_ControlPlan_Click(object sender, EventArgs e)
        {
            RegControlPlan f = new RegControlPlan();
            f.Show();
        }

        private void btn_DocumentoDmo_Click(object sender, EventArgs e)
        {
            MarcosDmo f = new MarcosDmo();
            f.Show();
        }

        private void btn_Analisis_Click(object sender, EventArgs e)
        {
            if (lbl_TipoUsu.Text == "Administrador" || lbl_TipoUsu.Text == "Encargado DE&MS" || lbl_TipoUsu.Text == "Responsable Analista")
            {
                if (panelAnalisis.Visible == true)
                {
                    panelAnalisis.Visible = false;
                }
                else
                {
                    panelAnalisis.Visible = true;
                    panelDmo.Visible = false;
                    p_Administrador.Visible = false;
                    panelCplan.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Este menú se encuentra deshabilitado porque no cuenta con los permisos necesarios. Para más información consulte con el Administrador.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Soporte_Click(object sender, EventArgs e)
        {
            if (lbl_TipoUsu.Text == "Administrador")
            {
                if (p_Administrador.Visible == true)
                {
                    p_Administrador.Visible = false;
                }
                else
                {
                    panelAnalisis.Visible = false;
                    panelDmo.Visible = false;
                    p_Administrador.Visible = true;
                    panelCplan.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Este menú se encuentra deshabilitado porque no cuenta con los permisos necesarios. Para más información consulte con el Administrador.","Atención!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Btn_TipoVehiculo_Click(object sender, EventArgs e)
        {
            Modelos f = new Modelos();
            f.Show();
        }

        private void Btn_Secciones_Click(object sender, EventArgs e)
        {
            SeccionesVehiculo f = new SeccionesVehiculo();
            f.Show();
        }

        private void Btn_ClasifPto_Click(object sender, EventArgs e)
        {
            tipoPuntoClasificacion f = new tipoPuntoClasificacion();
            f.Show();
        }

        private void Btn_TipoPto_Click(object sender, EventArgs e)
        {
            tipoPuntoClasificacion f = new tipoPuntoClasificacion();
            f.Show();
        }
        //emision de alerta de cambios en directorio especificado
        private void FileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            playSimpleSound();
            MessageBox.Show(string.Format("Alerta!!!!!! archivo cambiado {0} {1}", e.FullPath, e.Name));
        }

        private void FileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            playSimpleSound();
            MessageBox.Show(string.Format("Alerta!!!!!! archivo creado {0} {1}", e.FullPath, e.Name));
           
        }

        private void FileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            playSimpleSound();
            MessageBox.Show(string.Format("Alerta!!!!!! archivo Borrado {0} {1}", e.FullPath, e.Name));
            
        }

        private void FileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            playSimpleSound();
            MessageBox.Show(string.Format("Alerta!!!!!! archivo renombrado {0} {1}", e.FullPath, e.Name));
        }
        private void playSimpleSound()
        {
            string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string sonido = Path.Combine(mdoc, @"GitHub\GES_FINAL\PrimerasHU-GES\PrimerasHU-GES\Resources\sonidos\buzzer3_x.wav");
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Roqué\Documents\GitHub\Tesis\PrimerasHU-GES\PrimerasHU-GES\Resources\sonidos\buzzer3_x.wav");
            SoundPlayer simpleSound = new SoundPlayer(@""+sonido);
            simpleSound.Play();
        }

        private void Pb_menu_Click(object sender, EventArgs e)
        {
            if (sidebar1.Visible == false)
            {
                sidebar1.Visible = true;
            }
            else
            {
                panelAnalisis.Visible = false;
                panelDmo.Visible = false;
                p_Administrador.Visible = false;
                panelCplan.Visible = false;
                sidebar1.Visible = false;
            }
        }

        private void Btn_Muestras_Click(object sender, EventArgs e)
        {
            MuestraMarcos m = new MuestraMarcos();
            m.Show();
        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Show();
        }

        private void Btn_Aprobadores_Click(object sender, EventArgs e)
        {
            AprobadoresCompiladores ac = new AprobadoresCompiladores();
            ac.Show();
        }

        private void Btn_Compiladores_Click(object sender, EventArgs e)
        {
            AprobadoresCompiladores ac = new AprobadoresCompiladores();
            ac.Show();
        }

        private void Btn_Operarios_Click(object sender, EventArgs e)
        {
            OperariosMaquinaMedicion opmm = new OperariosMaquinaMedicion();
            opmm.Show();
        }
        
        private void Btn_Graficos_Click (object sender, EventArgs e)
        {
            GraficoMarcos gm = new GraficoMarcos();
            gm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //cargar lo siguiente para el movimiento del panel 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PrimeraPantalla_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Calculos_Click(object sender, EventArgs e)
        {
            CalculoMarcos cm = new CalculoMarcos();
            cm.Show();
        }

        private void btn_Indicadores_Click(object sender, EventArgs e)
        {
            IndicadoresCalidad ic = new IndicadoresCalidad();
            ic.Show();
        }

        private void btn_Maquinas_Click(object sender, EventArgs e)
        {
            MaquinaMedicion mmd = new MaquinaMedicion();
            mmd.Show();
        }

        private void btn_Establecimientos_Click(object sender, EventArgs e)
        {
            Establecimientos es = new Establecimientos();
            es.Show();
        }

        private void btn_Unidades_Click(object sender, EventArgs e)
        {
            UnidadesMedicion udm = new UnidadesMedicion();
            udm.Show();
        }

        private void btn_Entidades_Click(object sender, EventArgs e)
        {
            Entidades ent = new Entidades();
            ent.Show();
        }

        private void btn_TipoControl_Click(object sender, EventArgs e)
        {
            TiposDeControl tdc = new TiposDeControl();
            tdc.Show();
        }

        private void btn_Programas_Click(object sender, EventArgs e)
        {
            Programas prg = new Programas();
            prg.Show();
        }

        private void btn_Reglas_Click(object sender, EventArgs e)
        {
            ReglasMedicion rdm = new ReglasMedicion();
            rdm.Show();
        }

        private void btn_TipoCalculo_Click(object sender, EventArgs e)
        {
            TiposCalculo tdc = new TiposCalculo();
            tdc.Show();
        }

        private void btn_Formulas_Click(object sender, EventArgs e)
        {

        }

        private void btn_TipoGrafico_Click(object sender, EventArgs e)
        {
            TiposGrafico tdg = new TiposGrafico();
            tdg.Show();
        }

        private void btn_Estados_Click(object sender, EventArgs e)
        {
            Estados ests = new Estados();
            ests.Show();
        }

        private void btn_TipoUsuario_Click(object sender, EventArgs e)
        {
            TiposUsuario tus = new TiposUsuario();
            tus.Show();
        }
    }
}
