using System;
using System.Collections.Generic;
using System.Windows;

namespace DataGridUsuarios
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private readonly string http;

        public Window1()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23), ImageUrl = http://www.wpf-tutorial.com/images/misc/john_doe.jpg});
            users.Add(new User() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            users.Add(new User() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });

            dgsUsers.ItemsSource = users;
        }

        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Birthday { get; set; }
            public string ImageUrl { get; set; }
        }
    }
}