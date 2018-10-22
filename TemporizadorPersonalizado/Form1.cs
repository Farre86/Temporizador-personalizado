using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class frmTemporizador : Form
    {
        ProcessStartInfo psiInfoProceso = new ProcessStartInfo("gom.exe");
        int ultimoTiempoSeleccionado = 3;
                
        public frmTemporizador()
        {
            InitializeComponent();

            //psiInfoProceso.Arguments = "\"D:\\MUSICA\\ROCK\\Rise Against\\(2004) Siren Song of the Counter Culture\\05 - Blood to bleed.mp3\"";
            psiInfoProceso.Arguments = "\"" + System.IO.Directory.GetCurrentDirectory() + "\\Alarma.mp3\"";
            ultimoTiempoSeleccionado = Convert.ToInt32(nudTemps.Value);
        }

        /// <summary>
        /// Evento que simplemente para y arranca el temporizador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "STOP")
            {
                PararCrono();
            }
            else
            {
                IniciarCrono();
            }
        }

        /// <summary>
        /// Comprueba que el temporitzador no haya llegado a cero, en caso afirmativo
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudTemps_ValueChanged(object sender, EventArgs e)
        {
            if(nudTemps.Value==0)
            {
                Process p = Process.Start(psiInfoProceso);

                //HacerPing();

                //Refrescar algo o hacer que GOM establezca el FOCUS
            }
        }

        /// <summary>
        /// Hacer sonar un Ping a través de los sonidos del systema.
        /// </summary>
        public void HacerPing()
        {
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void timerTemps_Tick(object sender, EventArgs e)
        {
            if (nudTemps.Value>0)
            {
                nudTemps.Value--;
            }
            else
            {
                PararCrono();
                nudTemps.Value = ultimoTiempoSeleccionado;
            }
        }

        private void tsmiMinutosPredeterminados(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi_sender = (ToolStripMenuItem)sender;
            nudTemps.Value = Convert.ToInt32(tsmi_sender.Tag);//como el valor de tiempo pred. contenido en el tag esta expresado en minutos aún hay q pasarlo a segundos (x60)

            ultimoTiempoSeleccionado = Convert.ToInt32(nudTemps.Value);
        }

        private void PararCrono()
        {
            timerTemps.Enabled = false;
            menuTiemposPredeterminados.Enabled = true;
            btnStart.Text = "START";
        }


        private void IniciarCrono()
        {
            timerTemps.Enabled = true;
            menuTiemposPredeterminados.Enabled = false;
            btnStart.Text = "STOP";
        }
    }
}
