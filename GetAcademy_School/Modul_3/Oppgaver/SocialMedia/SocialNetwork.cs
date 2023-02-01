using SocialMedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    class SocialNetwork
    {
        public List<Profile> ListOfUsers { get; set; }
        private Profile loggedInProfile;

        public SocialNetwork()
        {
            loggedInProfile = new Profile("Bossman", "0");

            ListOfUsers = new List<Profile>();
            ListOfUsers.Add(new Profile("Andreas", "1"));
            ListOfUsers.Add(new Profile("Lars", "2"));
            ListOfUsers.Add(new Profile("Per", "3"));
            ListOfUsers.Add(new Profile("Askeladden", "4", "Hakkebakkeskogem", "bossman@twitter.com"));

            // Create a infinite while loop that starts over whenever another method is finished.
            while (true)
            {
                 PrintMenu();
                 var userInput = Console.ReadLine(); 
                 Console.Clear();
                 HandleMenuOption(userInput);

            }

        }

        private void ShowUsers()
        {
            foreach (var user in ListOfUsers)
            {
                Console.WriteLine($"| {user.Id}: {user.Name} ");
            }
        }

      
        private void PrintMenu()
        {
            Console.WriteLine("Welcome to Friendface");
            Console.WriteLine("*--------------------------------------*");
            loggedInProfile.CountFriends();
            Console.WriteLine("| 1: Add friend");
            Console.WriteLine("| 2: Remove friend");
            Console.WriteLine("| 3: Print friends");
            Console.WriteLine("| 4: Show friends info");
            Console.WriteLine("| 5: Show all users on the Social Network");
            Console.WriteLine("*--------------------------------------*");
            Console.WriteLine("| Pick a number");
        }

        private void HandleMenuOption(string menuOption)
        {
            if (menuOption == "1")
            {
                Console.Clear();
                Console.WriteLine("MenuOption 1: Add friend:");
                Console.WriteLine("*--------------------------------------*");
                ShowUsers();
                Console.WriteLine("*--------------------------------------*");
                Console.WriteLine("| Choose the id of the user you want to add");
                var chosenUserId = Console.ReadLine();
                var userProfile = GetUserProfile(chosenUserId);
                loggedInProfile.AddFriend(userProfile);
            }

            if (menuOption == "2")
            {
                Console.WriteLine("MenuOption 2: Remove friend:");
                Console.WriteLine("*--------------------------------------*");
                loggedInProfile.ShowFriends();
                loggedInProfile.CountFriends();
                Console.WriteLine("*--------------------------------------*");
                Console.WriteLine("Choose witch friend to remove");
                var friendId = Console.ReadLine();
                var friendToRemove = GetUserProfile(friendId);
                loggedInProfile.RemoveFriend(friendToRemove);

            }

            if (menuOption == "3")
            {
                loggedInProfile.ShowFriends();
            }

            if (menuOption == "4")
            {
                loggedInProfile.ShowFriends();
                var friendId = Console.ReadLine();  

                // Note!!:.
                // here we return back the correct user form the list and store it in the profile variable.
                // So the "profile" variable now becomes the "user object"
                // So the line profile.PrintProfileInfo(); - > Example: Askeladden.PrintProfileInfo.
                // meaning it wil look at that users method and show that user's info
                var profile = GetUserProfile(friendId);
                profile.PrintProfileInfo();
            }

            if (menuOption == "5")
            {
                GetAllSocialNetworkUsers();
            }
        }


        private Profile GetUserProfile(string id)
        {
            foreach (var user in ListOfUsers)
            {
                if (user.Id == id) return user;
            }

            return null;
        }

        private void GetAllSocialNetworkUsers()
        {
            foreach (var user in ListOfUsers)
            {
                Console.WriteLine($"| Name: {user.Name}");  
                Console.WriteLine($"| Address: {user.Address}");  
                Console.WriteLine($"| Twitter: {user.TwitterHandle}");
                Console.WriteLine("-------------------------------------------");
            }
        }


    }
}
