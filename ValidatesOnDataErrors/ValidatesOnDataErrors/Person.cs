using System;
using System.ComponentModel;

namespace ValidatesOnDataErrors
{
    public class Person : INotifyPropertyChanged, IDataErrorInfo
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;

                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get 
            {
                string result = string.Empty;

                if (columnName == "Name")
                {
                    if (!string.IsNullOrEmpty(Name))
                        if (Name.Length < 5)
                            result = "Der Name benötigt mindestens 5 Zeichen!";
                }

                return result;
            }
        }
    }
}
