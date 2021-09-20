using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;     // <-- Adicionado para Usar o SoundPlayer

namespace JogoDaVelha_Jesher
{
    public partial class Frm01 : Form
    {      

        string xo = "X";

        private SoundPlayer Tocador;

        public Frm01()
        {
            InitializeComponent();

            Tocador = new SoundPlayer();   // o audio foi adicionado na pasta do projeto em /bin/debug
        }

        private void fimdejogo()
        {
            btn_11.Enabled = false; btn_12.Enabled = false; btn_13.Enabled = false;
            btn_21.Enabled = false; btn_22.Enabled = false; btn_23.Enabled = false;
            btn_31.Enabled = false; btn_32.Enabled = false; btn_33.Enabled = false;
        }

        public void limpar()
        {
            xo = "X";
            btn_11.Text = ""; btn_12.Text = ""; btn_13.Text = "";
            btn_21.Text = ""; btn_22.Text = ""; btn_23.Text = "";
            btn_31.Text = ""; btn_32.Text = ""; btn_33.Text = "";

            btn_11.Enabled = true; btn_12.Enabled = true; btn_13.Enabled = true;
            btn_21.Enabled = true; btn_22.Enabled = true; btn_23.Enabled = true;
            btn_31.Enabled = true; btn_32.Enabled = true; btn_33.Enabled = true;

        }

        // Método que Verifica se alguém venceu ou s eo jogo terminou Empatado
        private void VerificandoStatus()
        {
            // Verificando se X Ganhou

            if (btn_11.Text == "X" && btn_12.Text == "X" && btn_13.Text == "X"
             || btn_21.Text == "X" && btn_22.Text == "X" && btn_23.Text == "X"
             || btn_31.Text == "X" && btn_32.Text == "X" && btn_33.Text == "X")
            {
                Tocador.SoundLocation = "Video_Game_Win.WAV";
                Tocador.Play();
                MessageBox.Show("O Jogador X Venceu", "Ganhou!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                fimdejogo();
                return;
            }

            if (btn_11.Text == "X" && btn_21.Text == "X" && btn_31.Text == "X"
             || btn_12.Text == "X" && btn_22.Text == "X" && btn_32.Text == "X"
             || btn_13.Text == "X" && btn_23.Text == "X" && btn_33.Text == "X")
            {
                Tocador.SoundLocation = "Video_Game_Win.WAV";
                Tocador.Play();
                MessageBox.Show("O Jogador X Venceu", "Ganhou!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                fimdejogo();
                return;
            }

            if (btn_11.Text == "X" && btn_22.Text == "X" && btn_33.Text == "X"
              || btn_13.Text == "X" && btn_22.Text == "X" && btn_31.Text == "X")
            {
                Tocador.SoundLocation = "Video_Game_Win.WAV";
                Tocador.Play();
                MessageBox.Show("O Jogador X Venceu", "Ganhou!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                fimdejogo();
                return;
            }

            // Verificando se O Ganhou

            if (btn_11.Text == "O" && btn_12.Text == "O" && btn_13.Text == "O"
             || btn_21.Text == "O" && btn_22.Text == "O" && btn_23.Text == "O"
             || btn_31.Text == "O" && btn_32.Text == "O" && btn_33.Text == "O")
            {
                Tocador.SoundLocation = "Error-Eletric.WAV";
                Tocador.Play();
                MessageBox.Show("O Jogador O Venceu", "Ganhou!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                fimdejogo();
                return;
            }

            if (btn_11.Text == "O" && btn_21.Text == "O" && btn_31.Text == "O"
             || btn_12.Text == "O" && btn_22.Text == "O" && btn_32.Text == "O"
             || btn_13.Text == "O" && btn_23.Text == "O" && btn_33.Text == "O")
            {
                Tocador.SoundLocation = "Error-Eletric.WAV";
                Tocador.Play();
                MessageBox.Show("O Jogador O Venceu", "Ganhou!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                fimdejogo();
                return;
            }

            if (btn_11.Text == "O" && btn_22.Text == "O" && btn_33.Text == "O"
             || btn_13.Text == "O" && btn_22.Text == "O" && btn_31.Text == "O")
            {
                Tocador.SoundLocation = "Error-Eletric.WAV";
                Tocador.Play();
                MessageBox.Show("O Jogador O Venceu", "Ganhou!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                fimdejogo();
                return;
            }

            //Verificando se deu Velha

            if (btn_11.Text != "" && btn_21.Text != "" && btn_31.Text != ""
              && btn_12.Text != "" && btn_22.Text != "" && btn_32.Text != ""
              && btn_13.Text != "" && btn_23.Text != "" && btn_33.Text != "")
            {
                Tocador.SoundLocation = "Error-Eletric.WAV";
                Tocador.Play();
                MessageBox.Show("Nenhum Jogador Venceu, deu Velha", "Empate",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                fimdejogo();
            }
        }
        
        private void jogar(System.Windows.Forms.Button jogarXO)
        {
            jogarXO.Text = xo;

            VerificandoStatus();

            if (xo == "X") xo = "O";
            else xo = "X";
        }
        
        private void btn_11_Click(object sender, EventArgs e)
        {
            if (btn_11.Text == "") jogar(btn_11);
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            if (btn_12.Text == "") jogar(btn_12);
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            if (btn_13.Text == "") jogar(btn_13);
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            if (btn_21.Text == "") jogar(btn_21);
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            if (btn_22.Text == "") jogar(btn_22);
        }

        private void btn_23_Click(object sender, EventArgs e)
        {
            if (btn_23.Text == "") jogar(btn_23);
        }

        private void btn_31_Click(object sender, EventArgs e)
        {
            if (btn_31.Text == "") jogar(btn_31);
        }

        private void btn_32_Click(object sender, EventArgs e)
        {
            if (btn_32.Text == "") jogar(btn_32);
        }

        private void btn_33_Click(object sender, EventArgs e)
        {
            if (btn_33.Text == "") jogar(btn_33);
        }

        private void btn_NnovoJogo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void Frm01_Load(object sender, EventArgs e)
        {
            Tocador.SoundLocation = "Error.WAV";
            Tocador.Play();

            //Tocador.SoundLocation = "Error.WAV";
            //Tocador.PlayLooping();                      <-- Com playlooping toca o tempo com programa startado
        }
    }
}
