﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ECD011_TP_Grupo8.src.math
{
    /// <summary>
    /// Classe abstrata de uma operação matemática qualquer. 
    /// </summary>
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
        /// Lista de números nos quais o método <see cref="Run"/> será executado
        /// </summary>
        public List<double> Numbers { get; set; } = new List<double>();

        private ICollectionView _numbersView;
        /// <summary>
        /// My property summary
        /// </summary>
        public ICollectionView NumbersView
        {
            get => _numbersView;
            set => SetField(ref _numbersView, value);
        }

        /// <summary>
        /// Executa a operação matemática
        /// </summary>
        public abstract double Run();
    }
}
