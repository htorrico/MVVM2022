using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM2022.ViewModels
{
    public class OperationsViewModel : ViewModelBase
    {
        

        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }


        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }


        int resultadoSuma;
        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }


        int resultadoResta;
        public int ResultadoResta
        {
            get { return resultadoResta; }
            set
            {
                if (resultadoResta != value)
                {
                    resultadoResta = value;
                    OnPropertyChanged();
                }
            }
        }


        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }


        public OperationsViewModel()
        {
            Sumar = new Command(() =>
            {                
                ResultadoSuma = Valor1 + Valor2;
            });

            Restar = new Command(() =>
            {
                ResultadoResta = Valor1 - Valor2;
            });

        }


    }
}
