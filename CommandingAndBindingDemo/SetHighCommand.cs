﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandingAndBindingDemo
{
    class SetHighCommand : ICommand
    {
        private TemperatureVM _viewmodel;

        public SetHighCommand(TemperatureVM viewmodel)
        {
            this._viewmodel = viewmodel;
        }
        public bool CanExecute(object parameter)
        {
            if (_viewmodel == null)
            {
                return false;
            }
            return _viewmodel.Temperature <= 200;
        }

        public void Execute(object parameter)
        {
            _viewmodel.Temperature = 300;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
