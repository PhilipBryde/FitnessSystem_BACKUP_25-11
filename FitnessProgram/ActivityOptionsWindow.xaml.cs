using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FitnessProgram
{
    /// <summary>
    /// Interaction logic for ActivityOptionsWindow.xaml
    /// </summary>
    public partial class ActivityOptionsWindow : Window
    {
        public ActivityOptionsWindow(string activityName) // ← now takes fitness too
        {
            Fitness fitness = new Fitness();
            InitializeComponent();

            ActivityName.Content = activityName;

            var members = fitness.GetMembersForActivity(activityName); // use the shared fitness

            if (members.Count == 0)
            {
                MemberBlock.Text = "Ingen medlemmer tilmeldt endnu";
            }
            else
            {
                MemberBlock.Text = string.Join("\n", members.Select(m => $"{m.name} (ID: {m.id})"));
            }
        }
    }
}
    