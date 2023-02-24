using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SimsProjekat2020
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string USER_FILE = "../../Resource/Data/User.csv";
        private const string CSV_DELIMITER = ",";

        private const string DATETIME_FORMAT = "dd.MM.yyyy.";
        public App()
        {
           // var userRepository = new UserRepository();
        }
    }
}
