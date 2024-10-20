using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ECD011_TP_Grupo8.src.math
{
    /// <summary>
    /// Classe abstrata de uma operação matemática qualquer. 
    /// </summary>
    [DebuggerDisplay("{Symbol}")]
    public abstract class MathOperation : INotifyPropertyChanged
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
        /// Lista de números nos quais o método <see cref="Run"/> será executado. O tipo "List<double>" foi escolhido pela flexibilidade da implementação 
        /// </summary>
        public List<double> Numbers { get; set; } = new List<double>();

        private string _symbol;
        /// <summary>
        /// Simbolo da operação matemática
        /// </summary>
        public string Symbol
        {
            get => _symbol;
            set => SetField(ref _symbol, value);
        }

        public MathOperation(string symbol)
        {
            Symbol = symbol;
        }

        /// <summary>
        /// Executa a operação matemática
        /// </summary>
        /// <returns>O resultado da operação matemática, seja qual for.</returns>
        /// <exception cref="DivideByZeroException">Um dos denominadores em <see cref="MathOperation.Numbers"/> é igual a zero e uma operação de divisão foi feita!</exception>
        public abstract double Run();
    }
}
