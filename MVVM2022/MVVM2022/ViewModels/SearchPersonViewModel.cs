using MVVM2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM2022.ViewModels
{
    public class SearchPersonViewModel : ViewModelBase
    {
        string filter;
        public string Filter
        {
            get { return filter; }
            set
            {
                if (filter != value)
                {
                    filter = value;
                    OnPropertyChanged();
                }
            }
        }


        string result;
        public string Result
        {
            get { return result; }
            set
            {
                if (result != value)
                {
                    result = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Search { protected set; get; }

        public SearchPersonViewModel()
        {
            Search = new Command(() =>
            {

                //Obtener la data 
                PersonService service = new PersonService();

                //Expresiones Lambda y Linq
                var person = service.GetPeople().Where(x => x.FirstName.Contains(filter)).FirstOrDefault();

                if (person!=null)
                    Result = person.LastName;
            });
        }

        }
}
