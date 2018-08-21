using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Mail;



namespace wpfExchangeTool
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private  int  folder = 0;
        private int usermailbox = 0;
       

  
       
        public MainWindow()
        {
            

         
                var splash = new SplashScreen("SplashScreen1.png");
                splash.Show(false);
                splash.Close(TimeSpan.FromSeconds(2));
                InitializeComponent();
           
                
          
        }
        
        

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
                btnSenden.Visibility = Visibility.Visible;
                txtMail.Visibility = Visibility.Visible;
            lblMail.Visibility = Visibility.Visible;



        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            btnSenden.Visibility = Visibility.Hidden;
            txtMail.Visibility = Visibility.Hidden;
            lblMail.Visibility = Visibility.Hidden;
        }

       

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Close();
        }

        private void BtnShow_Click_1(object sender, RoutedEventArgs e)
        {
            var lastLine = File.ReadLines("Text-File-Path").Last();
            Char delimiter = '|';
            String[] substrings = lastLine.Split(delimiter);
            foreach (var substring in substrings)
            {
                LstBox.Items.Add(substring);
            }

            
        }

        private void btnSenden_Click(object sender, RoutedEventArgs e)
        {
            if (!txtMail.Text.Contains('@') || !txtMail.Text.Contains('.'))
            {
                lblMail.Content = "Bitte geben sie eine Email-Adresse ein!" ;
               lblMail.BorderBrush = Brushes.Red;
                lblMail.Foreground = Brushes.Red;
            }
            else
            {
                var emailAdress = txtMail.Text;

                try
                {
                    var mail = new MailMessage($"E-Mail-Adresse", "{emailAdress}");
                    var client = new SmtpClient();
                    client.Port = 0;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Host = "smtp.gmail.com";
                    mail.Subject = "SPLA & SAL infos";
                    mail.Body = $"Guten Tag!" +
                                $"" +
                                $"Es wurden {usermailbox} Mailbox-Konten" +
                                $" und {folder} öffentliche Ordner festgestellt!" +
                                $"" +
                                $"Dies ist eine automatische generierte Email.";
                    client.Send(mail);
                }
                catch (Exception except)
                {
                    lblMail.Content = except.ToString();
                }
                finally
                {
                    txtMail.Text = "";

                    lblMail.Content = "Die Email wurde versandt!";
                    lblMail.BorderBrush = Brushes.Green;
                    lblMail.Foreground = Brushes.Green;


                }
            }
            




        }
    }
}
