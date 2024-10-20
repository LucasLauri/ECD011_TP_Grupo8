using ECD011_TP_Grupo8.src.math;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ECD011_TP_Grupo8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        #region Eventos PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        /// <summary>
        /// Atualiza campo gerando evento para GUI
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field">Campo a ser atualizado</param>
        /// <param name="value">Novo valor do campo</param>
        /// <param name="propertyName"></param>
        protected void SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            field = value;
            OnPropertyChanged(propertyName);
        }

    #endregion
				
        /// <summary>
        /// Lista de operações matemáticas suportadas pela aplicação
        /// </summary>
        public ObservableCollection<MathOperation> MathOperations { get; set; } = new ObservableCollection<MathOperation>();

        /// <summary>
        /// Lista de números que podem ser inseridos na calculadora
        /// </summary>
        public ObservableCollection<double> PossibleNumbers { get; set; } = new ObservableCollection<double>();

        private double _currentResult = 0;
        /// <summary>
        /// Número atual da calculadora
        /// </summary>
        public double CurrentResult
        {
            get => _currentResult;
            set => SetField(ref _currentResult, value);
        }

        public MainWindow()
        {
            InitializeOperationsAndNumbers();

            InitializeComponent();
        }

        /// <summary>
        /// Inicializa o <see cref="MathOperations"/> com as operações matemáticas suportadas pelas aplicação e o <see cref="PossibleNumbers"/> com os números suportados pela aplicação
        /// </summary>
        private void InitializeOperationsAndNumbers()
        {

            MathOperations.Add(new Add());
            MathOperations.Add(new Subtract());
            MathOperations.Add(new Multiply());
            MathOperations.Add(new Divide());

            for(int i = 0; i <= 9; i++)
                PossibleNumbers.Add(i);
        }
    }
}