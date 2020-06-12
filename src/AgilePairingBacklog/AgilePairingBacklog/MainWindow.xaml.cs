using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AgilePairingBacklog.Models;

namespace AgilePairingBacklog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Attached property used to tag when items are in edit mode.
        public static readonly DependencyProperty IsInEditModeProperty = DependencyProperty.RegisterAttached("IsInEditMode", typeof(bool), typeof(MainWindow));
        
        public static bool GetIsInEditMode(DependencyObject d)
        {
            return (bool)d.GetValue(IsInEditModeProperty);
        }

        public static void SetIsInEditMode(DependencyObject d, bool value)
        {
            d.SetValue(IsInEditModeProperty, value);
        }

        public AgilePairingBacklogProject BacklogProject
        {
            get { return (AgilePairingBacklogProject)GetValue(BacklogProjectProperty); }
            set { SetValue(BacklogProjectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BacklogProject.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BacklogProjectProperty =
            DependencyProperty.Register("BacklogProject", typeof(AgilePairingBacklogProject), typeof(MainWindow), new PropertyMetadata(null));

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExecuteNewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var Dwayne = new Person { Id = "dwaynen", Name = "Dwayne", Role = "Lead, Developer" };
            var Martha = new Person { Id = "marthami", Name = "Martha", Role = "Developer" };
            var Ashley = new Person { Id = "atravers", Name = "Ashley", Role = "Tester" };
            var Cory = new Person { Id = "coryf", Name = "Cory", Role = "Developer" };
            var Dylan = new Person { Id = "dywu", Name = "Dylan", Role = "Developer" };
            var Sreekanth = new Person { Id = "sreekany", Name = "Sreekanth", Role = "Tester" };
            var Movses = new Person { Id = "mbabaya", Name = "Movses", Role = "Developer" };
            var Ozgur = new Person { Id = "oarman", Name = "Ozgur", Role = "Developer" };
            var Richard = new Person { Id = "richrund", Name = "Richard", Role = "Program Manager" };
            var Sina = new Person { Id = "sikhakab", Name = "Sina", Role = "Developer" };

            var backlogProject = new AgilePairingBacklogProject();

            backlogProject.TeamMembers.Add(Dwayne);
            backlogProject.TeamMembers.Add(Martha);
            backlogProject.TeamMembers.Add(Ashley);
            backlogProject.TeamMembers.Add(Cory);
            backlogProject.TeamMembers.Add(Dylan);
            backlogProject.TeamMembers.Add(Sreekanth);
            backlogProject.TeamMembers.Add(Movses);
            backlogProject.TeamMembers.Add(Ozgur);
            backlogProject.TeamMembers.Add(Richard);
            backlogProject.TeamMembers.Add(Sina);

            var fakeDataTask = new Task { Name="Transfer fake data", Description="Transfer fake protection data from blob into SOLR", Status=TaskStatus.Review};
            fakeDataTask.Pairings.Add(new Pairing {FirstPerson=Ozgur, SecondPerson=Cory, Task=fakeDataTask});
            fakeDataTask.Pairings.Add(new Pairing {FirstPerson=Cory, SecondPerson=Ozgur, Task=fakeDataTask});
            fakeDataTask.Pairings.Add(new Pairing {FirstPerson=Ozgur, SecondPerson=Sina, Task=fakeDataTask});
            backlogProject.Tasks.Add(fakeDataTask);

            var statusBladeTask = new Task { Name="Status Blade", Description="Make a component for displaying our protection and threats status.", Status=TaskStatus.Active};
            statusBladeTask.Pairings.Add(new Pairing {FirstPerson=Ashley, SecondPerson=Dylan, Task=statusBladeTask});
            statusBladeTask.Pairings.Add(new Pairing {FirstPerson=Dylan, SecondPerson=Cory, Task=statusBladeTask});
            statusBladeTask.Pairings.Add(new Pairing {FirstPerson=Cory, SecondPerson=Dwayne, Task=statusBladeTask});
            backlogProject.Tasks.Add(statusBladeTask);

            var realQueryTask = new Task { Name="Create Real Query", Description="Construct the real SOLR queries for the overview tile from our fake data.", Status=TaskStatus.Active};
            realQueryTask.Pairings.Add(new Pairing {FirstPerson=Ozgur, SecondPerson=Martha, Task=realQueryTask});
            backlogProject.Tasks.Add(realQueryTask);

            var protectionBladeTask = new Task { Name="Protection Blade Summary Tile", Description="Implement the summary tile for the protection blade.", Status=TaskStatus.Completed};
            protectionBladeTask.Pairings.Add(new Pairing {FirstPerson=Sreekanth, SecondPerson=Martha, Task=protectionBladeTask});
            protectionBladeTask.Pairings.Add(new Pairing {FirstPerson=Martha, SecondPerson=Dylan, Task=protectionBladeTask});
            backlogProject.Tasks.Add(protectionBladeTask);

            var genFakeDataTask = new Task { Name="Generate Fake Data", Description="Generate fake data from the last watermark, doc MDS troubleshooting.", Status=TaskStatus.Active};
            genFakeDataTask.Pairings.Add(new Pairing {FirstPerson=Sina, SecondPerson=Ashley, Task=genFakeDataTask});
            backlogProject.Tasks.Add(genFakeDataTask);

            var protectionDataTask = new Task { Name="DataSource for Protection Blade", Description="Create the datasource component to bind to the protection blade.", Status=TaskStatus.Completed};
            protectionDataTask.Pairings.Add(new Pairing {FirstPerson=Movses, SecondPerson=Martha, Task=protectionDataTask});
            backlogProject.Tasks.Add(protectionDataTask);

            var threatsMetadataTask = new Task { Name="Facts for Threats", Description="Create the metadata for the threats schema.", Status=TaskStatus.Proposed};
            backlogProject.Tasks.Add(threatsMetadataTask);

            var odsEndpointTask = new Task { Name="ODS endpoint for protection data", Description="Create the ODS endpoint for protection data.", Status=TaskStatus.Active};
            odsEndpointTask.Pairings.Add(new Pairing {FirstPerson=Movses, SecondPerson=Dylan, Task=odsEndpointTask});
            backlogProject.Tasks.Add(odsEndpointTask);

            BacklogProject = backlogProject;
        }

        private void ExecuteEnterEditModeCommand(object sender, ExecutedRoutedEventArgs e)
        {
            ((UIElement)e.OriginalSource).SetValue(MainWindow.IsInEditModeProperty, true);
        }

        private void ExecuteExitEditModeCommand(object sender, ExecutedRoutedEventArgs e)
        {
            ((UIElement)e.OriginalSource).SetValue(MainWindow.IsInEditModeProperty, false);
        }
    }
}
