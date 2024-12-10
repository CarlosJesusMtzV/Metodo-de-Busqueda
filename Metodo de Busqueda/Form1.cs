namespace Metodo_de_Busqueda
{
    public partial class Form1 : Form
    {
        private int[] randomNumbers;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Generar una lista aleatoria de números
            Random rand = new Random();
            randomNumbers = Enumerable.Range(1, 100).OrderBy(x => rand.Next()).ToArray();

            // Mostrar la lista en un TextBox
            txtNumbers.Text = string.Join(", ", randomNumbers);
        }

        private void btnSequentialSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int target))
            {
                // Búsqueda Secuencial
                bool found = randomNumbers.Contains(target);
                lblResult.Text = found ? "Número encontrado (Búsqueda Secuencial)" : "Número no encontrado";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            if (randomNumbers == null || randomNumbers.Length == 0)
            {
                MessageBox.Show("Genera la lista antes de realizar la búsqueda.");
                return;
            }

            if (int.TryParse(txtSearch.Text, out int target))
            {
                // Ordenar la lista (requisito para búsqueda binaria)
                Array.Sort(randomNumbers);

                // Búsqueda Binaria
                int index = Array.BinarySearch(randomNumbers, target);
                lblResult.Text = index >= 0 ? "Número encontrado (Búsqueda Binaria)" : "Número no encontrado";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }
    }
}
