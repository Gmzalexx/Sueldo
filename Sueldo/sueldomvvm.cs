using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo
{
    partial class sueldomvvm : ObservableObject
    {
        [ObservableProperty]
        public string sueldoActual;

        [ObservableProperty]
        public string nuevoSueldo;

        [RelayCommand]
        private void CalcularNuevoSueldo()
        {
            if (double.TryParse(SueldoActual, out double sueldoActualValue))
            {
                if (sueldoActualValue < 1000)
                {
                    double nuevoSueldoValue = sueldoActualValue * 1.15;
                    NuevoSueldo = nuevoSueldoValue.ToString("F2"); 
                }
                else
                {
                    double nuevoSueldoValue = sueldoActualValue * 1.12;
                    NuevoSueldo = nuevoSueldoValue.ToString("F2"); 
                }
            }
            else
            {
                NuevoSueldo = "Ingresa un número válido para el sueldo";
            }
        }
    }
}
