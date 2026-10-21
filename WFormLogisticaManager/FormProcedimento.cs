using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WFormLogisticaManager
{
    internal class FormProcedimento : Form
    {
        private static readonly Color Blu = Color.FromArgb(2, 62, 138);
        private static readonly Color BluChiaro = Color.FromArgb(30, 64, 175);
        private static readonly Color Verde = Color.FromArgb(22, 163, 74);
        private static readonly Color VerdeScuro = Color.FromArgb(21, 128, 61);
        private static readonly Color Sfondo = Color.FromArgb(241, 245, 249);

        private readonly Label lblTitolo;
        private readonly Label lblStato;
        private readonly TextBox txtLog;
        private readonly FlowLayoutPanel pannelloPulsanti;
        private readonly Button btnChiudi;
        private readonly Button btnSalva;

        private bool terminato;

        public FormProcedimento()
        {
            Text = "ELABORAZIONE";
            Font = new Font("Segoe UI", 9F);
            Size = new Size(580, 660);
            MinimumSize = new Size(420, 400);
            StartPosition = FormStartPosition.Manual;
            ShowInTaskbar = false;
            BackColor = Sfondo;

            Panel testo = new Panel();
            testo.Dock = DockStyle.Fill;
            testo.BackColor = Color.White;
            testo.Padding = new Padding(16);

            txtLog = new TextBox();
            txtLog.Multiline = true;
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.WordWrap = true;
            txtLog.BorderStyle = BorderStyle.None;
            txtLog.BackColor = Color.White;
            txtLog.ForeColor = Color.FromArgb(35, 42, 52);
            txtLog.Font = new Font("Consolas", 10F);
            txtLog.Dock = DockStyle.Fill;
            testo.Controls.Add(txtLog);

            btnChiudi = CreaPulsante("CHIUDI", Blu, BluChiaro);
            btnChiudi.Click += (sender, e) => Close();

            btnSalva = CreaPulsante("SALVA", Verde, VerdeScuro);
            btnSalva.Click += btnSalva_Click;

            pannelloPulsanti = new FlowLayoutPanel();
            pannelloPulsanti.Dock = DockStyle.Bottom;
            pannelloPulsanti.Height = 66;
            pannelloPulsanti.BackColor = Sfondo;
            pannelloPulsanti.FlowDirection = FlowDirection.RightToLeft;
            pannelloPulsanti.Padding = new Padding(14, 12, 14, 12);
            pannelloPulsanti.Visible = false;
            pannelloPulsanti.Controls.Add(btnChiudi);
            pannelloPulsanti.Controls.Add(btnSalva);

            Panel intestazione = new Panel();
            intestazione.Dock = DockStyle.Top;
            intestazione.Height = 64;
            intestazione.BackColor = Blu;

            lblTitolo = new Label();
            lblTitolo.AutoSize = true;
            lblTitolo.Text = "ELABORAZIONE";
            lblTitolo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitolo.ForeColor = Color.White;
            lblTitolo.BackColor = Color.Transparent;
            lblTitolo.Location = new Point(16, 8);

            lblStato = new Label();
            lblStato.AutoSize = true;
            lblStato.Text = "ESECUZIONE IN CORSO...";
            lblStato.Font = new Font("Segoe UI", 9F);
            lblStato.ForeColor = Color.FromArgb(186, 213, 255);
            lblStato.BackColor = Color.Transparent;
            lblStato.Location = new Point(18, 38);

            intestazione.Controls.Add(lblTitolo);
            intestazione.Controls.Add(lblStato);

            Controls.Add(testo);
            Controls.Add(pannelloPulsanti);
            Controls.Add(intestazione);

            FormClosing += FormProcedimento_FormClosing;
        }

        private static Button CreaPulsante(string testo, Color colore, Color coloreHover)
        {
            Button b = new Button();
            b.Text = testo;
            b.Size = new Size(130, 40);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = coloreHover;
            b.BackColor = colore;
            b.ForeColor = Color.White;
            b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            b.Cursor = Cursors.Hand;
            b.UseVisualStyleBackColor = false;
            b.Margin = new Padding(6, 0, 6, 0);
            return b;
        }

        public void Scrivi(string riga)
        {
            txtLog.AppendText(riga + Environment.NewLine);
        }

        public void Termina(bool successo)
        {
            terminato = true;

            lblTitolo.Text = successo ? "ELABORAZIONE COMPLETATE" : "ELABORAZIONE INTERROTTA";
            lblStato.Text = successo
                ? "PUOI SALVARE IL PROCEDIMENTO O CHIUDERE LA FINESTRA."
                : "SI E' VERIFICATO UN ERRORE. PUOI COMUNQUE SALVARE IL LOG.";

            pannelloPulsanti.Visible = true;
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.ScrollToCaret();
        }

        private void FormProcedimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!terminato && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "SALVA IL PROCEDIMENTO";
                dialog.Filter = "FILE DI TESTO (*.txt)|*.txt|TUTTI I FILE (*.*)|*.*";
                dialog.DefaultExt = "txt";
                dialog.AddExtension = true;
                dialog.FileName = "METODO_NO_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    File.WriteAllText(dialog.FileName, txtLog.Text, Encoding.UTF8);

                    MessageBox.Show(
                        "FILE SALVATO CORRETTAMENTE.",
                        "SALVATAGGIO COMPLETATO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
                {
                    MessageBox.Show(
                        "IMPOSSIBILE SALVARE IL FILE:\n\n" + ex.Message.ToUpper(),
                        "ERRORE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}