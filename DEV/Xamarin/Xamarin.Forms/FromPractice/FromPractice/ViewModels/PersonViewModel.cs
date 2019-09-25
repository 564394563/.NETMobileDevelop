﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FromPractice.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        string name;
        double age;
        string skills;

        /// <summary>
        /// 属性更新事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            set { SetProperty(ref name, value); }
            get { return name; }
        }

        public double Age
        {
            set { SetProperty(ref age, value); }
            get { return age; }
        }

        public string Skills
        {
            set { SetProperty(ref skills, value); }
            get { return skills; }
        }

        public override string ToString()
        {
            return $"{Name},age {Age},{Skills}";
        }

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
            {
                return false;
            }
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
