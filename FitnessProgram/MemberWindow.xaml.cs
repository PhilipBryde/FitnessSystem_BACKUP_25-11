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
    /// Interaction logic for MemberWindow.xaml
    /// </summary>
    public partial class MemberWindow : Window
    {
        List<Member> memberList = new List<Member>(); //liste hvor de forskellige medlemmer bliver tilføjet ind i

        public MemberWindow()
        {
            InitializeComponent();

            //Opretter medlemmer med givende id, navn og køn
            memberList.Add(new Member(1, "Mathias", 'M'));
            memberList.Add(new Member(2, "Anders", 'M'));
            memberList.Add(new Member(3, "Sofie", 'F'));
            memberList.Add(new Member(4, "Caroline", 'F'));
            memberList.Add(new Member(5, "Rasmus", 'M'));
            memberList.Add(new Member(6, "Johan", 'M'));
            memberList.Add(new Member(7, "Ida", 'F'));
            memberList.Add(new Member(8, "Emma", 'F'));
            memberList.Add(new Member(9, "Victor", 'M'));
            memberList.Add(new Member(10, "Gertrud", 'F'));
            memberList.Add(new Member(11, "Richard", 'M'));
            memberList.Add(new Member(12, "Lasse", 'M'));
            memberList.Add(new Member(13, "Maya", 'F'));
            memberList.Add(new Member(14, "Victoria", 'F'));
            memberList.Add(new Member(15, "Magnus", 'M'));

            ShowMembers(); //Kalder på ShowMembers funktionen som printer medlemmerne ud
            
        }

        public void ShowMembers()
        {
            StringBuilder allMembers = new StringBuilder(); //Opretter en StringBuilder som samler alt fra listen på en hukommelseseffektiv måde
            //string allMembers = "";
            for (int i = 0; i < memberList.Count; i++) //For løkke der printer alle medlemmer ud
            {
                var member = memberList[i];
                allMembers.AppendLine($"ID: {member.id} Navn: {member.name} Køn: {member.gender}"); //printer hvert variabel i hver sin linje, da StringBuilder gør det til én stor string
                
            }
            MemberBlock.Text = allMembers.ToString(); //Laver vores StringBuilder om til den endelige string og ligger det ind i vores TextBlock
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NextWindow next = new NextWindow();
            next.Show();
            this.Close();
        }
    }
}
