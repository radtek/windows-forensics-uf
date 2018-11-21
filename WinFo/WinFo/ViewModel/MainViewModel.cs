﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFo.View;

namespace WinFo.ViewModel
{
    /// <summary>
    /// The view model for the application hub
    /// </summary
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// The command which loads windows based on names passed as parameters
        /// </summary>
        public ViewModelCommand LoadWindowCommand { get; set; }

        /// <summary>
        /// Load a window
        /// </summary>
        /// <param name="parameter">The window name</param>
        public void LoadWindow(object parameter = null)
        {
            if (parameter is string)
            {
                string windowName = (string)parameter;

                switch (windowName)
                {
                    case ("Shares"):
                        {
                            ShareView sv = new ShareView();
                            sv.Show();
                            break;
                        }
                    case ("Network Adapters"):
                        {
                            NetworkAdapterView nav = new NetworkAdapterView();
                            nav.Show();
                            break;
                        }
                    case ("IP4 Routes"):
                        {
                            IP4RoutingTableView iprv = new IP4RoutingTableView();
                            iprv.Show();
                            break;
                        }
                    case ("User Sessions"):
                        {
                            UserSessionView usv = new UserSessionView();
                            usv.Show();
                            break;
                        }
                    case ("Computer Sessions"):
                        {
                            ComputerSessionView csv = new ComputerSessionView();
                            csv.Show();
                            break;
                        }
                    case ("Computer System"):
                        {
                            ComputerSystemView cosv = new ComputerSystemView();
                            cosv.Show();
                            break;
                        }
                }
            }
            
        }
        
        /// <summary>
        /// Check if loading the window is possible
        /// </summary>
        /// <param name="parameter">The parameter</param>
        /// <returns></returns>
        public bool CanLoadWindow(object parameter = null)
        {
            return true;
        }

        public MainViewModel()
        {
            LoadWindowCommand = new ViewModelCommand(LoadWindow, CanLoadWindow);
        }

    }

    
}