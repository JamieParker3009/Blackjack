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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Blackjack_Project
{
    public partial class MainWindow : Window
    {
        Hand player = new Hand("Player"); //Create a new hand for player and dealer
        Hand dealer = new Hand("Dealer");

        Deck gameDeck = new Deck(); //Create a new game deck

        int click = 0; //Variable for starting the game
        int piteration = 1; //Variable for displaying card images (player)
        int diteration = 1; //Variable for displaying card images (dealer)

        public MainWindow()
        {
            InitializeComponent();

            gameDeck.CreateDeck(1); //Create and shuffle deck
            gameDeck.Shuffle(10);
        }

        // CREATING FUNCTIONS ------------------------------------------------//
        private void DisplayHandPlayer(Hand hand, int iteration) //Function that checks the amount of cards in hand and displays the appropriate card in the correct place
        {
            foreach (var card in hand.hand) 
            {
                if (iteration == 1)
                {
                    this.IMG1_p.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG1_p.Opacity = 100;
                    WHITE1_p.Opacity = 100;
                }
                else if (iteration == 2)
                {
                    this.IMG2_p.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG2_p.Opacity = 100;
                    WHITE2_p.Opacity = 100;
                }
                else if (iteration == 3)
                {
                    this.IMG3_p.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG3_p.Opacity = 100;
                    WHITE3_p.Opacity = 100;
                }
                else if (iteration == 4)
                {
                    this.IMG4_p.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG4_p.Opacity = 100;
                    WHITE4_p.Opacity = 100;
                }
                else if (iteration == 5)
                {
                    this.IMG5_p.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG5_p.Opacity = 100;
                    WHITE5_p.Opacity = 100;
                }
                else if (iteration == 6)
                {
                    this.IMG6_p.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG6_p.Opacity = 100;
                    WHITE6_p.Opacity = 100;
                }
            }
        }

        private void DisplayHandDealer(Hand hand, int iteration) //Dealer version of above function
        {
            foreach (var card in hand.hand)
            {
                if (iteration == 1)
                {
                    this.IMG1_d.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG1_d.Opacity = 100;
                    WHITE1_d.Opacity = 100;
                }
                else if (iteration == 2)
                {
                    this.IMG2_d.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG2_d.Opacity = 100;
                    WHITE2_d.Opacity = 100;
                }
                else if (iteration == 3)
                {
                    this.IMG3_d.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG3_d.Opacity = 100;
                    WHITE3_d.Opacity = 100;
                }
                else if (iteration == 4)
                {
                    this.IMG4_d.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG4_d.Opacity = 100;
                    WHITE4_d.Opacity = 100;
                }
                else if (iteration == 2)
                {
                    this.IMG5_d.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG5_d.Opacity = 100;
                    WHITE5_d.Opacity = 100;
                }
                else if (iteration == 2)
                {
                    this.IMG6_d.Source = new BitmapImage(new Uri($@"/Images/{card.imagename}", UriKind.Relative));
                    IMG6_d.Opacity = 100;
                    WHITE6_d.Opacity = 100;
                }
            }
        }

        private void CardDraw(Hand Player, Deck Deck) //Function for drawing a card
        {
            Player.GetCards(Deck.deck);
        }

        private void CheckHand(Hand Player) //Function to check if the player or dealer bust/blackjack
        {
            if (Player.hand_total > 21)
            {
                if (Player == player)
                {
                    LBL5.Content = "YOU LOST!";
                    if (MessageBox.Show("You Bust! \n Do you want to play again?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {
                        System.Windows.Application.Current.Shutdown();
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                        System.Windows.Application.Current.Shutdown();
                    }
                }
                else if (Player == dealer)
                {
                    LBL5.Content = "YOU WIN!";
                    if (MessageBox.Show("The Dealer Bust... You Win! \n Do you want to play again?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {
                        System.Windows.Application.Current.Shutdown();
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                        System.Windows.Application.Current.Shutdown();
                    }
                }
            }
            else if (Player.hand_total == 21)
            {
                if (Player == player)
                {
                    LBL5.Content = "YOU WIN!";
                    if (MessageBox.Show("You got a BlackJack! \n Do you want to play again?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {
                        System.Windows.Application.Current.Shutdown();
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                        System.Windows.Application.Current.Shutdown();
                    }
                }
                else if (Player == dealer)
                {
                    LBL5.Content = "YOU LOSE!";
                    if (MessageBox.Show("The Dealer got a BlackJack!... You Lost! \n Do you want to play again?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {
                        System.Windows.Application.Current.Shutdown();
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                        System.Windows.Application.Current.Shutdown();
                    }
                }
                
            }
        }

        //END OF CREATING FUNCTIONS ---------------------------//

        private void BTN1_Click(object sender, RoutedEventArgs e) //If the "HIT" button is pressed:
        {
            CardDraw(player, gameDeck); //Draw a card
            DisplayHandPlayer(player, piteration); //Update the images to show the new card
            LBL2.Content = player.hand_total; //Update the "player total" label to show the new card's value
            CheckHand(player); //Check to make sure the player isn't bust/got a blackjack
            piteration++; //Increase the iteration counter (used for displaying the images)
        }

        private void BTN2_Click_1(object sender, RoutedEventArgs e)
        {
            while (dealer.hand_total < 17) //The dealer MUST hit if they are under 17
            {
                CardDraw(dealer, gameDeck);
                DisplayHandDealer(dealer, diteration);
                LBL2.Content = player.hand_total;
                LBL4.Content = dealer.hand_total;
                CheckHand(dealer);
                diteration++;
            }

            if (player.hand_total > dealer.hand_total) //Win conditions
            {
                LBL5.Content = "YOU WIN!";
                if (MessageBox.Show("Your hand beats the dealer's.. You Win! \n Do you want to play again?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                { //IF NO (close app)
                    System.Windows.Application.Current.Shutdown();
                }
                else //IF YES (restart app)
                {
                    System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                    System.Windows.Application.Current.Shutdown();
                }
            }

            else if (dealer.hand_total > player.hand_total)
            {
                LBL5.Content = "YOU LOST!";
                if (MessageBox.Show("The dealer's hand beats yours... You Lost! \n Do you want to play again?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    System.Windows.Application.Current.Shutdown();
                }
                else
                {
                    System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                    System.Windows.Application.Current.Shutdown();
                }
            }

            else if (player.hand_total == dealer.hand_total)
                LBL5.Content = "IT'S A TIE!";
                if (MessageBox.Show($"Both hands add up to {player.hand_total}!... It's a Tie! \n Do you want to play again?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    System.Windows.Application.Current.Shutdown();
                }
                else
                {
                    System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                    System.Windows.Application.Current.Shutdown();
                }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Would you like to Quit? ( you will lose :C )", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
            }
            else
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void BTN4_Click(object sender, RoutedEventArgs e) //On clicking the start button (important for ensuring the starting card images are displayed properly)
        {
            click++; //Increaes the "click" var

            if (click == 1) //If the click var is 1
            {
                CardDraw(player, gameDeck); //Draw the first card
                DisplayHandPlayer(player, 1); //Update the image
                LBL2.Content = player.hand_total; //Update the total
                CardDraw(dealer, gameDeck); 
                DisplayHandDealer(dealer, 1);
                LBL4.Content = dealer.hand_total;
                BTN4.Content = "Start Game"; //Change the button to say "Start Game"
            }
            else if (click == 2) //If the "Start Game" button is clicked
            {
                BTN4.IsEnabled = false; //Remove the button
                BTN4.Opacity = 0; //Make it invisible
                BTN1.IsEnabled = true; //Enable the Hit button
                BTN2.IsEnabled = true; //Enable the Stand button

                CardDraw(player, gameDeck); //Draw the second starting card
                LBL2.Content = player.hand_total;
                CardDraw(dealer, gameDeck);
                LBL4.Content = dealer.hand_total;

                DisplayHandPlayer(player, 2);
                DisplayHandDealer(dealer, 2);

                piteration = 3;
                diteration = 3;
            }
        }
    }
}
