using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormLogisticaManager
{
    public partial class Form1 : Form
    {
        private const int RitardoSalto = 500;
        private const int RitardoEvidenziazione = 700;
        private const int RitardoTrasferimento = 1000;
        private const int MargineInferiore = 12;

        private static readonly string[] NomiUnitaPlurali =
        {
            "UNITA'", "MIGLIAIA DI UNITA'", "MILIONI DI UNITA'", "MILIARDI DI UNITA'"
        };

        private static readonly string[] NomiUnitaSingolari =
        {
            "UNITA'", "MIGLIAIO DI UNITA'", "MILIONE DI UNITA'", "MILIARDO DI UNITA'"
        };

        private static readonly long[] Moltiplicatori = { 1L, 1000L, 1000000L, 1000000000L };

        private static readonly Color ColoreIntestazione = Color.FromArgb(30, 64, 175);
        private static readonly Color ColoreIntestazioneTotali = Color.FromArgb(2, 62, 138);
        private static readonly Color ColoreTesto = Color.FromArgb(35, 42, 52);
        private static readonly Color ColoreCosto = Color.White;
        private static readonly Color ColoreTotaliRiga = Color.FromArgb(220, 252, 231);
        private static readonly Color ColoreTotale = Color.FromArgb(22, 163, 74);
        private static readonly Color ColoreSelezione = Color.FromArgb(187, 247, 208);
        private static readonly Color ColoreEvidenziazione = Color.FromArgb(254, 240, 138);
        private static readonly Color ColoreCellaCorrente = Color.FromArgb(250, 204, 21);
        private static readonly Color ColoreHover = Color.FromArgb(249, 115, 22);

        private static readonly Font FontCella = new Font("Segoe UI", 10.5F, FontStyle.Regular);
        private static readonly Font FontCellaTotali = new Font("Segoe UI", 10.5F, FontStyle.Bold);

        private static readonly CultureInfo CulturaItaliana = CultureInfo.GetCultureInfo("it-IT");

        private Griglia griglia;
        private readonly Random random = new Random();

        private bool risoluzioneInCorso;
        private int rigaHover = -1;
        private int colonnaHover = -1;

        private string unitaPlurale = NomiUnitaPlurali[0];
        private string unitaSingolare = NomiUnitaSingolari[0];
        private long moltiplicatore = 1;

        public Form1()
        {
            InitializeComponent();

            try
            {
                Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            }
            catch (ArgumentException)
            {
            }

            pannelloLaterale.Resize += (sender, e) => PosizionaControlliInBasso();
            PosizionaControlliInBasso();

            FormClosing += Form1_FormClosing;

            AbilitaAutoSelezioneNumericUpDown(this);
            ConfiguraDataGridView();
            AggiornaTitoloTab();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (risoluzioneInCorso && e.CloseReason == CloseReason.UserClosing)
            {
                MostraAvviso("ATTENDI LA FINE DELLA RISOLUZIONE PRIMA DI CHIUDERE IL PROGRAMMA.");
                e.Cancel = true;
            }
        }

        private void PosizionaControlliInBasso()
        {
            int yRisolvi = pannelloLaterale.ClientSize.Height - btnRisolvi.Height - MargineInferiore;
            int yMinimo = groupBoxValoriCasuali.Bottom + 14;

            if (yRisolvi < yMinimo)
            {
                yRisolvi = yMinimo;
            }

            btnRisolvi.Location = new Point(10, yRisolvi);
        }

        private void ConfiguraDataGridView()
        {
            dataGridViewMatrice.AllowUserToAddRows = false;
            dataGridViewMatrice.AllowUserToDeleteRows = false;
            dataGridViewMatrice.AllowUserToResizeRows = false;
            dataGridViewMatrice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrice.RowHeadersVisible = true;
            dataGridViewMatrice.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewMatrice.MultiSelect = false;
            dataGridViewMatrice.RowHeadersWidth = 150;
        }

        private void comboUnitaMisura_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaTitoloTab();
        }

        private int IndiceUnita()
        {
            int indice = comboUnitaMisura.SelectedIndex;
            return indice < 0 ? 0 : indice;
        }

        private void AggiornaTitoloTab()
        {
            if (tabMatriceIniziale == null)
            {
                return;
            }

            tabMatriceIniziale.Text = "MATRICE (" + NomiUnitaPlurali[IndiceUnita()] + ")";
        }

        private string NomeUnita(long quantita)
        {
            return quantita == 1 ? unitaSingolare : unitaPlurale;
        }

        private void btnCreaMatrice_Click(object sender, EventArgs e)
        {
            if (risoluzioneInCorso)
            {
                return;
            }

            int numeroProduttori = (int)numericNumeroProduttori.Value;
            int numeroConsumatori = (int)numericNumeroConsumatori.Value;

            griglia = new Griglia(numeroConsumatori, numeroProduttori);

            MostraGriglia();
        }

        private void MostraGriglia()
        {
            if (griglia == null)
            {
                return;
            }

            int n = griglia.Rows;
            int m = griglia.Columns;

            dataGridViewMatrice.Columns.Clear();
            dataGridViewMatrice.Rows.Clear();

            for (int j = 0; j <= m; j++)
            {
                DataGridViewTextBoxColumn colonna = new DataGridViewTextBoxColumn();

                colonna.Name = j < m ? "CONSUMATORE" + (j + 1) : "PRODUZIONE";
                colonna.HeaderText = j < m ? "CONSUMATORE " + (j + 1) : "PRODUZIONE";
                colonna.SortMode = DataGridViewColumnSortMode.NotSortable;
                colonna.MinimumWidth = 135;

                dataGridViewMatrice.Columns.Add(colonna);
            }

            for (int i = 0; i <= n; i++)
            {
                int indiceRiga = dataGridViewMatrice.Rows.Add();

                dataGridViewMatrice.Rows[indiceRiga].HeaderCell.Value =
                    i < n ? "PRODUTTORE " + (i + 1) : "FABBISOGNO";
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridViewMatrice.Rows[i].Cells[j].Value = griglia.Grid[i][j];
                }
            }

            dataGridViewMatrice.Rows[n].Cells[m].ReadOnly = true;

            AggiornaTitoloTab();
            RipristinaColoriGriglia();
        }

        private void btnIncolla_Click(object sender, EventArgs e)
        {
            if (risoluzioneInCorso)
            {
                return;
            }

            if (griglia == null)
            {
                MostraAvviso("PRIMA DEVI CREARE LA MATRICE.");
                return;
            }

            if (!Clipboard.ContainsText())
            {
                MostraAvviso("NEGLI APPUNTI NON C'E' NESSUN TESTO. COPIA PRIMA UN INTERVALLO DA EXCEL.");
                return;
            }

            int n = griglia.Rows;
            int m = griglia.Columns;

            int rigaInizio = 0;
            int colonnaInizio = 0;

            if (dataGridViewMatrice.CurrentCell != null)
            {
                rigaInizio = dataGridViewMatrice.CurrentCell.RowIndex;
                colonnaInizio = dataGridViewMatrice.CurrentCell.ColumnIndex;
            }

            string testo = Clipboard.GetText().Replace("\r\n", "\n").Replace("\r", "\n");
            string[] righe = testo.Split('\n');

            int numeroRighe = righe.Length;

            while (numeroRighe > 0 && string.IsNullOrWhiteSpace(righe[numeroRighe - 1]))
            {
                numeroRighe--;
            }

            if (numeroRighe == 0)
            {
                MostraAvviso("GLI APPUNTI SONO VUOTI.");
                return;
            }

            List<int[]> valori = new List<int[]>();
            int larghezzaMax = 0;

            for (int r = 0; r < numeroRighe; r++)
            {
                string[] celle = righe[r].Split('\t');
                int[] riga = new int[celle.Length];

                for (int c = 0; c < celle.Length; c++)
                {
                    string cella = celle[c].Trim().Replace(" ", "");

                    if (cella == "")
                    {
                        riga[c] = 0;
                    }
                    else if (!int.TryParse(cella, out riga[c]) || riga[c] < 0)
                    {
                        MostraErrore(
                            "VALORE NON VALIDO \"" + cella.ToUpper() + "\" ALLA RIGA " + (r + 1) +
                            ", COLONNA " + (c + 1) + " DEI DATI COPIATI.\n\n" +
                            "SONO AMMESSI SOLO NUMERI INTERI MAGGIORI O UGUALI A ZERO.");
                        return;
                    }
                }

                valori.Add(riga);
                larghezzaMax = Math.Max(larghezzaMax, celle.Length);
            }

            if (rigaInizio + numeroRighe > n + 1 || colonnaInizio + larghezzaMax > m + 1)
            {
                MostraErrore(
                    "I DATI COPIATI (" + numeroRighe + " RIGHE X " + larghezzaMax + " COLONNE) " +
                    "NON ENTRANO NELLA TABELLA A PARTIRE DALLA CELLA SELEZIONATA.\n\n" +
                    "LA TABELLA HA " + n + " PRODUTTORI E " + m + " CONSUMATORI: " +
                    "SELEZIONA LA CELLA IN ALTO A SINISTRA E RICONTROLLA LE DIMENSIONI.");
                return;
            }

            for (int r = 0; r < valori.Count; r++)
            {
                for (int c = 0; c < valori[r].Length; c++)
                {
                    int riga = rigaInizio + r;
                    int colonna = colonnaInizio + c;

                    if (riga == n && colonna == m)
                    {
                        continue;
                    }

                    dataGridViewMatrice.Rows[riga].Cells[colonna].Value = valori[r][c];
                }
            }

            SalvaDatiMatrice();

            long sommaProduzioni = LeggiProduzioni().Sum(x => (long)x);
            long sommaFabbisogni = LeggiFabbisogni().Sum(x => (long)x);

            dataGridViewMatrice.Rows[n].Cells[m].Value = sommaProduzioni;

            string avviso = "";

            if (sommaProduzioni != sommaFabbisogni)
            {
                avviso = "\n\nATTENZIONE: LA PRODUZIONE TOTALE (" + sommaProduzioni +
                         ") E' DIVERSA DAL FABBISOGNO TOTALE (" + sommaFabbisogni +
                         "). IL PROBLEMA NON E' BILANCIATO.";
            }

            MessageBox.Show(
                "DATI INCOLLATI CORRETTAMENTE." + avviso,
                "OPERAZIONE COMPLETATA",
                MessageBoxButtons.OK,
                avviso == "" ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        public static bool RangeFattibile(int n, int m, int min, int max)
        {
            return (long)Math.Max(n, m) * min <= (long)Math.Min(n, m) * max;
        }

        private static int MaxMinimoNecessario(int n, int m, int min)
        {
            int a = Math.Max(n, m);
            int b = Math.Min(n, m);
            return (int)Math.Ceiling((double)a * min / b);
        }

        private int[] Distribuisci(int count, int totale, int min, int max)
        {
            int[] valori = Enumerable.Repeat(min, count).ToArray();
            int resto = totale - count * min;
            List<int> liberi = Enumerable.Range(0, count).ToList();

            while (resto > 0)
            {
                int k = liberi[random.Next(liberi.Count)];
                int capacita = max - valori[k];
                int aggiunta = random.Next(1, Math.Min(capacita, resto) + 1);
                valori[k] += aggiunta;
                resto -= aggiunta;

                if (valori[k] == max)
                {
                    liberi.Remove(k);
                }
            }

            return valori;
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            if (risoluzioneInCorso)
            {
                return;
            }

            if (griglia == null)
            {
                MostraAvviso("PRIMA DEVI CREARE LA MATRICE.");
                return;
            }

            int costoMin = (int)numericRangeCostiMin.Value;
            int costoMax = (int)numericRangeCostiMax.Value;

            if (costoMin > costoMax)
            {
                MostraErrore("IL COSTO MINIMO NON PUO' ESSERE MAGGIORE DEL COSTO MASSIMO.");
                return;
            }

            int unitaMin = (int)numericRangeProdMin.Value;
            int unitaMax = (int)numericRangeProdMax.Value;

            if (unitaMin > unitaMax)
            {
                MostraErrore("IL NUMERO DI UNITA' MINIMO NON PUO' ESSERE MAGGIORE DEL NUMERO DI UNITA' MASSIMO.");
                return;
            }

            if (unitaMin <= 0)
            {
                MostraErrore("IL NUMERO DI UNITA' MINIMO DEVE ESSERE MAGGIORE DI ZERO.");
                return;
            }

            int n = griglia.Rows;
            int m = griglia.Columns;

            if (!RangeFattibile(n, m, unitaMin, unitaMax))
            {
                MessageBox.Show(
                    "IL RANGE " + unitaMin + "-" + unitaMax +
                    " NON E' COMPATIBILE CON " + n + " PRODUTTORI E " + m + " CONSUMATORI: " +
                    "LE SOMME DI PRODUZIONE E FABBISOGNO NON POSSONO COINCIDERE.\n\n" +
                    "CON MINIMO " + unitaMin + " IL MASSIMO DEVE ESSERE ALMENO " +
                    MaxMinimoNecessario(n, m, unitaMin) + ".",
                    "RANGE NON VALIDO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int valore = random.Next(costoMin, costoMax + 1);

                    griglia.ImpostaValore(i, j, valore);
                    dataGridViewMatrice.Rows[i].Cells[j].Value = valore;
                }
            }

            int totMin = Math.Max(n, m) * unitaMin;
            int totMax = Math.Min(n, m) * unitaMax;
            int totale = random.Next(totMin, totMax + 1);

            int[] produzioni = Distribuisci(n, totale, unitaMin, unitaMax);
            int[] fabbisogni = Distribuisci(m, totale, unitaMin, unitaMax);

            for (int i = 0; i < n; i++)
            {
                dataGridViewMatrice.Rows[i].Cells[m].Value = produzioni[i];
            }

            for (int j = 0; j < m; j++)
            {
                dataGridViewMatrice.Rows[n].Cells[j].Value = fabbisogni[j];
            }

            dataGridViewMatrice.Rows[n].Cells[m].Value = totale;
        }

        private int LeggiValoreCella(int riga, int colonna)
        {
            object valore = dataGridViewMatrice.Rows[riga].Cells[colonna].Value;
            int numero;

            if (valore != null && int.TryParse(valore.ToString(), out numero) && numero >= 0)
            {
                return numero;
            }

            return 0;
        }

        private int[] LeggiProduzioni()
        {
            int[] produzioni = new int[griglia.Rows];

            for (int i = 0; i < griglia.Rows; i++)
            {
                produzioni[i] = LeggiValoreCella(i, griglia.Columns);
            }

            return produzioni;
        }

        private int[] LeggiFabbisogni()
        {
            int[] fabbisogni = new int[griglia.Columns];

            for (int j = 0; j < griglia.Columns; j++)
            {
                fabbisogni[j] = LeggiValoreCella(griglia.Rows, j);
            }

            return fabbisogni;
        }

        private void SalvaDatiMatrice()
        {
            if (griglia == null)
            {
                return;
            }

            for (int i = 0; i < griglia.Rows; i++)
            {
                for (int j = 0; j < griglia.Columns; j++)
                {
                    griglia.ImpostaValore(i, j, LeggiValoreCella(i, j));
                }
            }
        }

        private async void btnRisolvi_Click(object sender, EventArgs e)
        {
            if (risoluzioneInCorso)
            {
                return;
            }

            if (griglia == null)
            {
                MostraAvviso("E' NECESSARIO CREARE LA MATRICE.");
                return;
            }

            dataGridViewMatrice.EndEdit();
            SalvaDatiMatrice();

            int n = griglia.Rows;
            int m = griglia.Columns;

            int[] produzioni = LeggiProduzioni();
            int[] fabbisogni = LeggiFabbisogni();

            long totaleProduzione = produzioni.Sum(x => (long)x);
            long totaleFabbisogno = fabbisogni.Sum(x => (long)x);

            if (totaleProduzione != totaleFabbisogno)
            {
                MostraErrore(
                    "IL TOTALE NON E' BILANCIATO.\n\n" +
                    "PRODUZIONE: " + totaleProduzione + "\n" +
                    "FABBISOGNO: " + totaleFabbisogno);
                return;
            }

            if (totaleProduzione == 0)
            {
                MostraErrore("PRODUZIONI E FABBISOGNI SONO TUTTI A ZERO.");
                return;
            }

            int indiceUnita = IndiceUnita();
            unitaPlurale = NomiUnitaPlurali[indiceUnita];
            unitaSingolare = NomiUnitaSingolari[indiceUnita];
            moltiplicatore = Moltiplicatori[indiceUnita];

            FormProcedimento finestra = new FormProcedimento();
            PosizionaFinestra(finestra);
            finestra.Show(this);

            Action<string> scrivi = testo =>
            {
                finestra.Scrivi(testo);
                System.Diagnostics.Debug.WriteLine(testo);
            };

            ImpostaRisoluzioneInCorso(true);

            try
            {
                int[,] allocazioni = new int[n, m];
                int[] produzioneResidua = (int[])produzioni.Clone();
                int[] fabbisognoResiduo = (int[])fabbisogni.Clone();

                scrivi("METODO DEL NORD-OVEST, " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                scrivi("UNITA' DI MISURA: " + unitaPlurale);
                scrivi("");

                long costoTotale = await NordOvest(
                    0,
                    0,
                    produzioneResidua,
                    fabbisognoResiduo,
                    allocazioni,
                    1,
                    scrivi);

                scrivi("COSTO TOTALE: " + FormattaEuro(costoTotale));

                RipristinaGriglia(produzioni, fabbisogni);
                finestra.Termina(true);
            }
            catch (Exception ex)
            {
                RipristinaGriglia(produzioni, fabbisogni);

                scrivi("");
                scrivi("ERRORE: " + ex.Message.ToUpper());
                finestra.Termina(false);
            }
            finally
            {
                ImpostaRisoluzioneInCorso(false);
            }
        }

        private void PosizionaFinestra(FormProcedimento finestra)
        {
            Rectangle area = Screen.FromControl(this).WorkingArea;

            finestra.Location = new Point(
                Math.Max(area.Left, area.Right - finestra.Width - 24),
                area.Top + 90);
        }

        private async Task<long> NordOvest(
            int riga,
            int colonna,
            int[] produzioneResidua,
            int[] fabbisognoResiduo,
            int[,] allocazioni,
            int numeroPassaggio,
            Action<string> scrivi)
        {
            if (riga >= griglia.Rows || colonna >= griglia.Columns)
            {
                return 0;
            }

            if (produzioneResidua[riga] == 0)
            {
                await Task.Delay(RitardoSalto);

                return await NordOvest(
                    riga + 1, colonna,
                    produzioneResidua, fabbisognoResiduo, allocazioni,
                    numeroPassaggio, scrivi);
            }

            if (fabbisognoResiduo[colonna] == 0)
            {
                await Task.Delay(RitardoSalto);

                return await NordOvest(
                    riga, colonna + 1,
                    produzioneResidua, fabbisognoResiduo, allocazioni,
                    numeroPassaggio, scrivi);
            }

            EvidenziaRigaColonna(riga, colonna);

            await Task.Delay(RitardoEvidenziazione);

            int unitaTrasferite = Math.Min(produzioneResidua[riga], fabbisognoResiduo[colonna]);
            int prezzo = griglia.Grid[riga][colonna];
            long costoTrasferimento = (long)prezzo * unitaTrasferite * moltiplicatore;

            allocazioni[riga, colonna] = unitaTrasferite;
            produzioneResidua[riga] -= unitaTrasferite;
            fabbisognoResiduo[colonna] -= unitaTrasferite;

            string equivalente = moltiplicatore > 1
                ? " (= " + FormattaNumero((long)unitaTrasferite * moltiplicatore) + " UNITA')"
                : "";

            scrivi("PASSAGGIO " + numeroPassaggio + ":");
            scrivi("  QUANTITA': " + FormattaNumero(unitaTrasferite) + " " +
                   NomeUnita(unitaTrasferite) + equivalente);
            scrivi("  PREZZO: " + FormattaEuro(prezzo) + " EUR UNITA'");
            scrivi("  TRASPORTO: DA PRODUTTORE N. " + (riga + 1) +
                   " A CONSUMATORE N. " + (colonna + 1));
            scrivi("  COSTO: " +
                   FormattaNumero((long)unitaTrasferite * moltiplicatore) + " X " +
                   FormattaEuro(prezzo) + " = " +
                   FormattaEuro(costoTrasferimento));
            scrivi("");

            dataGridViewMatrice.Rows[riga].Cells[griglia.Columns].Value = produzioneResidua[riga];
            dataGridViewMatrice.Rows[griglia.Rows].Cells[colonna].Value = fabbisognoResiduo[colonna];
            dataGridViewMatrice.Rows[griglia.Rows].Cells[griglia.Columns].Value = produzioneResidua.Sum(x => (long)x);
            dataGridViewMatrice.Refresh();

            await Task.Delay(RitardoTrasferimento);

            RipristinaColoriGriglia();

            bool produzioneFinita = produzioneResidua[riga] == 0;
            bool fabbisognoFinito = fabbisognoResiduo[colonna] == 0;

            if (produzioneFinita)
            {
                dataGridViewMatrice.Rows[riga].Visible = false;
            }

            if (fabbisognoFinito)
            {
                dataGridViewMatrice.Columns[colonna].Visible = false;
            }

            int rigaSuccessiva = produzioneFinita ? riga + 1 : riga;
            int colonnaSuccessiva = fabbisognoFinito ? colonna + 1 : colonna;

            long costoSuccessivo = await NordOvest(
                rigaSuccessiva, colonnaSuccessiva,
                produzioneResidua, fabbisognoResiduo, allocazioni,
                numeroPassaggio + 1, scrivi);

            return costoTrasferimento + costoSuccessivo;
        }

        private void RipristinaGriglia(int[] produzioni, int[] fabbisogni)
        {
            int n = griglia.Rows;
            int m = griglia.Columns;

            foreach (DataGridViewRow riga in dataGridViewMatrice.Rows)
            {
                riga.Visible = true;
            }

            foreach (DataGridViewColumn colonna in dataGridViewMatrice.Columns)
            {
                colonna.Visible = true;
            }

            for (int i = 0; i < n; i++)
            {
                dataGridViewMatrice.Rows[i].Cells[m].Value = produzioni[i];
            }

            for (int j = 0; j < m; j++)
            {
                dataGridViewMatrice.Rows[n].Cells[j].Value = fabbisogni[j];
            }

            dataGridViewMatrice.Rows[n].Cells[m].Value = produzioni.Sum(x => (long)x);

            RipristinaColoriGriglia();
        }

        private void ImpostaRisoluzioneInCorso(bool inCorso)
        {
            risoluzioneInCorso = inCorso;

            btnCreaMatrice.Enabled = !inCorso;
            btnIncolla.Enabled = !inCorso;
            btnGenera.Enabled = !inCorso;
            btnRisolvi.Enabled = !inCorso;
            comboUnitaMisura.Enabled = !inCorso;
            numericNumeroProduttori.Enabled = !inCorso;
            numericNumeroConsumatori.Enabled = !inCorso;

            dataGridViewMatrice.ReadOnly = inCorso;

            if (!inCorso && griglia != null)
            {
                dataGridViewMatrice.Rows[griglia.Rows].Cells[griglia.Columns].ReadOnly = true;
            }
        }

        private static string FormattaEuro(long valore)
        {
            return valore.ToString("N2", CulturaItaliana) + " EUR";
        }

        private static string FormattaNumero(long valore)
        {
            return valore.ToString("N0", CulturaItaliana);
        }

        private void RipristinaColoriGriglia()
        {
            if (griglia == null)
            {
                return;
            }

            for (int i = 0; i < dataGridViewMatrice.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewMatrice.Columns.Count; j++)
                {
                    DataGridViewCellStyle stile = dataGridViewMatrice.Rows[i].Cells[j].Style;

                    bool rigaFabbisogno = i == griglia.Rows;
                    bool colonnaProduzione = j == griglia.Columns;

                    if (rigaFabbisogno && colonnaProduzione)
                    {
                        stile.BackColor = ColoreTotale;
                        stile.ForeColor = Color.White;
                        stile.SelectionBackColor = ColoreTotale;
                        stile.SelectionForeColor = Color.White;
                        stile.Font = FontCellaTotali;
                    }
                    else if (rigaFabbisogno || colonnaProduzione)
                    {
                        stile.BackColor = ColoreTotaliRiga;
                        stile.ForeColor = ColoreTesto;
                        stile.SelectionBackColor = ColoreSelezione;
                        stile.SelectionForeColor = ColoreTesto;
                        stile.Font = FontCellaTotali;
                    }
                    else
                    {
                        stile.BackColor = ColoreCosto;
                        stile.ForeColor = ColoreTesto;
                        stile.SelectionBackColor = ColoreSelezione;
                        stile.SelectionForeColor = ColoreTesto;
                        stile.Font = FontCella;
                    }
                }
            }

            for (int i = 0; i < dataGridViewMatrice.Rows.Count; i++)
            {
                ImpostaStileIntestazione(
                    dataGridViewMatrice.Rows[i].HeaderCell.Style,
                    i == griglia.Rows);
            }

            for (int j = 0; j < dataGridViewMatrice.Columns.Count; j++)
            {
                ImpostaStileIntestazione(
                    dataGridViewMatrice.Columns[j].HeaderCell.Style,
                    j == griglia.Columns);
            }

            dataGridViewMatrice.Refresh();
        }

        private static void ImpostaStileIntestazione(DataGridViewCellStyle stile, bool totali)
        {
            stile.BackColor = totali ? ColoreIntestazioneTotali : ColoreIntestazione;
            stile.SelectionBackColor = stile.BackColor;
            stile.ForeColor = Color.White;
            stile.SelectionForeColor = Color.White;
        }

        private void EvidenziaRigaColonna(int riga, int colonna)
        {
            for (int j = 0; j < dataGridViewMatrice.Columns.Count; j++)
            {
                dataGridViewMatrice.Rows[riga].Cells[j].Style.BackColor = ColoreEvidenziazione;
                dataGridViewMatrice.Rows[riga].Cells[j].Style.ForeColor = ColoreTesto;
            }

            for (int i = 0; i < dataGridViewMatrice.Rows.Count; i++)
            {
                dataGridViewMatrice.Rows[i].Cells[colonna].Style.BackColor = ColoreEvidenziazione;
                dataGridViewMatrice.Rows[i].Cells[colonna].Style.ForeColor = ColoreTesto;
            }

            DataGridViewCell cellaCorrente = dataGridViewMatrice.Rows[riga].Cells[colonna];

            cellaCorrente.Style.BackColor = ColoreCellaCorrente;
            cellaCorrente.Style.SelectionBackColor = ColoreCellaCorrente;
            cellaCorrente.Style.ForeColor = ColoreTesto;
            cellaCorrente.Style.SelectionForeColor = ColoreTesto;

            dataGridViewMatrice.CurrentCell = cellaCorrente;
            dataGridViewMatrice.Refresh();
        }

        private void dataGridViewMatrice_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            rigaHover = e.RowIndex;
            colonnaHover = e.ColumnIndex;

            dataGridViewMatrice.InvalidateCell(e.ColumnIndex, e.RowIndex);
        }

        private void dataGridViewMatrice_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            TogliHover();
        }

        private void dataGridViewMatrice_MouseLeave(object sender, EventArgs e)
        {
            TogliHover();
        }

        private void TogliHover()
        {
            int riga = rigaHover;
            int colonna = colonnaHover;

            rigaHover = -1;
            colonnaHover = -1;

            if (riga >= 0 && riga < dataGridViewMatrice.Rows.Count &&
                colonna >= 0 && colonna < dataGridViewMatrice.Columns.Count)
            {
                dataGridViewMatrice.InvalidateCell(colonna, riga);
            }
        }

        private void dataGridViewMatrice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == rigaHover && e.ColumnIndex == colonnaHover)
            {
                e.CellStyle.BackColor = ColoreHover;
                e.CellStyle.SelectionBackColor = ColoreHover;
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }

        private static void MostraAvviso(string messaggio)
        {
            MessageBox.Show(messaggio, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void MostraErrore(string messaggio)
        {
            MessageBox.Show(messaggio, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AbilitaAutoSelezioneNumericUpDown(Control contenitore)
        {
            foreach (Control c in contenitore.Controls)
            {
                NumericUpDown nud = c as NumericUpDown;

                if (nud != null)
                {
                    nud.Enter += (sender, e) => nud.Select(0, nud.Text.Length);
                    nud.Click += (sender, e) => nud.Select(0, nud.Text.Length);
                }
                else if (c.HasChildren)
                {
                    AbilitaAutoSelezioneNumericUpDown(c);
                }
            }
        }
    }
}