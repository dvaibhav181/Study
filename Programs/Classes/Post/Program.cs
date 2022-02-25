using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            int choice;

            do
            {
                System.Console.Write("Enter 1 - Create Post\n2. Show Post\n3. Upvote Post\n4. Downvote Post\n0. Quit\n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        System.Console.WriteLine("Enter Title for the Post: ");
                        var title = Console.ReadLine();
                        System.Console.WriteLine("Enter Description for the Post: ");
                        var desc = Console.ReadLine();
                        var postdate = DateTime.Now;
                        post.CreatePost(title,desc,postdate);
                        post.ShowPost();
                        break;

                    case 2:
                        Console.WriteLine(post.ShowPost());
                        break;

                    case 3:
                        post.UpVote();
                        Console.WriteLine(post.ShowPost());
                        break;

                    case 4:
                        post.DownVote();
                        Console.WriteLine(post.ShowPost());
                        break;

                }
            } while (choice !=0);
            
        }
    }
}
