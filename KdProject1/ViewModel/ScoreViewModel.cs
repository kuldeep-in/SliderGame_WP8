using GalaSoft.MvvmLight;
using KdProject1.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdProject1.ViewModel
{
    public class ScoreViewModel : ViewModelBase
    {
        private ObservableCollection<ResultModel> _myResultList;
        public ObservableCollection<ResultModel> MyResultList
        {
            get { return _myResultList; }
            set
            {
                if (MyResultList != value)
                {
                    _myResultList = value;
                    RaisePropertyChanged("MyResultList");
                }
            }
        }
    }
}
