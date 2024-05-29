namespace Hänga_gubbe_slutarbete_projekt
{
    public partial class Hangman_form : Form
    {

        private Spel spelande_spel = null;

        private OrdLista A = new OrdLista();

        public Hangman_form()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            spelande_spel = new Spel(A.getOrd());
            uppdatera_skärmen();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            gissa_bokstav('A');
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            gissa_bokstav('B');
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            gissa_bokstav('C');
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            gissa_bokstav('D');
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            gissa_bokstav('E');
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            gissa_bokstav('F');
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            gissa_bokstav('G');
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            gissa_bokstav('H');
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            gissa_bokstav('I');
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            gissa_bokstav('J');
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            gissa_bokstav('K');
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            gissa_bokstav('L');
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            gissa_bokstav('M');
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            gissa_bokstav('N');
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            gissa_bokstav('O');
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            gissa_bokstav('P');
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            gissa_bokstav('Q');
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            gissa_bokstav('R');
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            gissa_bokstav('S');
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            gissa_bokstav('T');
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            gissa_bokstav('U');
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            gissa_bokstav('V');
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            gissa_bokstav('W');
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            gissa_bokstav('X');
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            gissa_bokstav('Y');
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            gissa_bokstav('Z');
        }

        private void buttonÅ_Click(object sender, EventArgs e)
        {
            gissa_bokstav('Å');
        }

        private void buttonÄ_Click(object sender, EventArgs e)
        {
            gissa_bokstav('Ä');
        }

        private void buttonÖ_Click(object sender, EventArgs e)
        {
            gissa_bokstav('Ö');
        }

        // ---------------------------------------------------------------

        private void gissa_bokstav(char bokstav)
        {
            if (spelande_spel == null)
            {
                MessageBox.Show("Du måste starta spelet först", "Spelet är inte startat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            spelande_spel.gissa(bokstav);

            uppdatera_skärmen();

            if (spelande_spel.getOrdetLöst())
            {
                MessageBox.Show("Du har vunnit wohooo", "Grattis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                spelande_spel = null;
                return;
            }

            if (spelande_spel.getgissnigarkvar() <= 0)
            {
                MessageBox.Show("Du förlorade", "Grattis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                spelande_spel = null;
                return;
            }
        }

        private void buttonHängProgrammet_Click(object sender, EventArgs e)
        {
            while (0 == 0)
            {

            }
        }

        private void uppdatera_skärmen()
        {
            SpelOrd.Text = spelande_spel.getSpelOrdet();
            gissningarKvar.Text = spelande_spel.getgissnigarkvar().ToString();
            Använda_Bokstäver.Text = spelande_spel.getgissade_bokstäver();

            switch (spelande_spel.getgissnigarkvar())
            {
                case 10:
                    pictureBox1.Image = Properties.Resources.Bitmap0;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.Bitmap1;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.Bitmap2;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.Bitmap3;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Bitmap4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Bitmap5;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Bitmap6;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Bitmap7;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Bitmap8;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.Bitmap9;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.Bitmap10;
                    break;
            }
        }

        private void buttonNyttOrd_Click(object sender, EventArgs e)
        {
            LäggTillOrd Nyttord = new LäggTillOrd();
            Nyttord.ShowDialog();
            A.nyttORd(Nyttord.getNyttOrd().ToUpper());
        }
    }
}