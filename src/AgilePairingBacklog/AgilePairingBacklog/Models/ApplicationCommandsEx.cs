using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AgilePairingBacklog.Models
{
    static class ApplicationCommandsEx
    {
        private static RoutedCommand exitCommand;
        private static RoutedCommand viewTeamCommand;
        private static RoutedCommand viewPeopleBoardCommand;
        private static RoutedCommand viewTasksBoardCommand;
        private static RoutedCommand enterEditModeCommand;
        private static RoutedCommand exitEditModeCommand;

        static ApplicationCommandsEx()
        {
            exitCommand = new RoutedCommand("Exit", typeof(ApplicationCommandsEx));
            viewTeamCommand = new RoutedCommand("ViewTeam", typeof(ApplicationCommandsEx));
            viewPeopleBoardCommand = new RoutedCommand("ViewPeopleBoard", typeof(ApplicationCommandsEx));
            viewTasksBoardCommand = new RoutedCommand("ViewTasksBoard", typeof(ApplicationCommandsEx));
            enterEditModeCommand = new RoutedCommand("EnterEditMode", typeof(ApplicationCommandsEx));
            exitEditModeCommand = new RoutedCommand("EnterEditMode", typeof(ApplicationCommandsEx));
        }

        public static RoutedCommand Exit
        {
            get
            {
                return ApplicationCommandsEx.exitCommand;
            }
        }

        public static RoutedCommand ViewTeam
        {
            get
            {
                return ApplicationCommandsEx.viewTeamCommand;
            }
        }

        public static RoutedCommand ViewPeopleBoard
        {
            get
            {
                return ApplicationCommandsEx.viewPeopleBoardCommand;
            }
        }

        public static RoutedCommand ViewTasksBoard
        {
            get
            {
                return ApplicationCommandsEx.viewTasksBoardCommand;
            }
        }

        public static RoutedCommand EnterEditMode
        {
            get
            {
                return ApplicationCommandsEx.enterEditModeCommand;
            }
        }

        public static RoutedCommand ExitEditMode
        {
            get
            {
                return ApplicationCommandsEx.exitEditModeCommand;
            }
        }
    }
}
